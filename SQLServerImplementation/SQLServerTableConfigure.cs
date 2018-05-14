using Interfaces;
using System;
using Interfaces.TableConfigure;
using System.Data.SqlClient;
using System.Dynamic;

namespace SQLServerImplementation
{
    public class SQLServerTableConfigure : ITableConfigure
    {
        private SQLLayer _SQLLayer;
        private ITableRepository tableRepository;

        public SQLServerTableConfigure(SQLLayer sqlLayer, ITableRepository repository)
        {
            tableRepository = repository;
            _SQLLayer = sqlLayer;
        }

        public void AddColumn(ColumnMetaData column)
        {
            tableRepository.CreateRecord("sys_column_metadata",column);

            string commandText = @"ALTER TABLE {0} 
                                      ADD {1} {2}";                                                      

            var tableParamter = (Value: column.TableName, SanitizationType: SanitizationType.TableName);
            var columnParamter = (Value: column.ColumnName, SanitizationType: SanitizationType.TableName);
            var columnTypeParamter = (Value: column., SanitizationType: SanitizationType.TableName);
            _SQLLayer.ExecuteNonQuery(commandText, new(string, SanitizationType)[] { parameter });
        }

        public void AddTable(TableMetaData table)
        {
            tableRepository.CreateRecord("sys_table_metadata",table);

            string commandText = @"CREATE TABLE {0}
                                                        ( 
                                                            sys_id INT IDENTITY(1,1),
                                                            sys_created DATETIME,
                                                            sys_updated DATETIME,
                                                            sys_created_by INT,
                                                            sys_updated_by INT
                                                        )";

            var parameter = (Value: table.TableName, SanitizationType: SanitizationType.TableName);
            _SQLLayer.ExecuteNonQuery(commandText, new(string, SanitizationType)[] { parameter });
        }

        public void DeleteColumn(string tableName, string columnName)
        {
            throw new NotImplementedException();
        }

        public void DeleteTable(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}
