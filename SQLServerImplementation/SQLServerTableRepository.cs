using Interfaces;
using System;

namespace SQLServerImplementation
{
    public class SQLServerTableRepository : ITableRepository
    {
        private IIdentityTracker _identityTracker;
        public SQLServerTableRepository(IIdentityTracker identityTracker)
        {
            _identityTracker = identityTracker;
        }
        public object CreateRecord(string table, object record)
        {
            return null;
        }

        public object GetRecord(string table, string id)
        {
            throw new NotImplementedException();
        }

        public object UpdateRecord(string table, string id, object record)
        {
            throw new NotImplementedException();
        }
    }
}
