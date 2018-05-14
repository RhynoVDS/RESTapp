using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ITableRepository
    {
        object GetRecord(string table, string id);
        object CreateRecord(string table, object record);
        object UpdateRecord(string table, string id, object record);
    }
}
