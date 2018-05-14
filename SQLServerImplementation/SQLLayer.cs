using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQLServerImplementation
{
    public enum SanitizationType
    {
        TableName
    }

    public class SQLLayer
    {
        private string _ConnectionString;
        public SQLLayer(string connectionString)
        {
            _ConnectionString = connectionString;
        }
        private string[] SanitizeValues((string Value, SanitizationType SanitizationType)[] values)
        {
            List<string> sanitizedValues = new List<string>();
            foreach((string Value, SanitizationType SanitizationType) value in values)
            {
                string sanitizedParameter = value.Value;

                if (value.SanitizationType == SanitizationType.TableName)
                {
                    sanitizedParameter = sanitizedParameter.Replace("-", string.Empty);
                    sanitizedParameter = sanitizedParameter.Replace(" ", string.Empty);
                    sanitizedParameter = sanitizedParameter.Replace(";", string.Empty);
                    sanitizedParameter = sanitizedParameter.Replace("\\", string.Empty);
                    sanitizedParameter = sanitizedParameter.Replace("/", string.Empty);
                }

                sanitizedValues.Add(sanitizedParameter);
            }

            return sanitizedValues.ToArray();
        }

        public void ExecuteNonQuery(string query, params (string Value,SanitizationType SanitizationType)[] parameters)
        {
            string[] parametersSanitized = SanitizeValues(parameters);
            query = string.Format(query, parametersSanitized);

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
