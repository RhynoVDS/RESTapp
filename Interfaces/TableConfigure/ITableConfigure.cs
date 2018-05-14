using Interfaces.TableConfigure;
using System;

namespace Interfaces
{
    public interface ITableConfigure
    {
        void AddTable(TableMetaData table);
        void AddColumn(ColumnMetaData column);
        void DeleteColumn(string tableName, string columnName);
        void DeleteTable(string tableName);
    }
}
