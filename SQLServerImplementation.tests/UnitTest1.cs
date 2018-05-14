using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQLServerImplementation.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SQLLayer sqlLayer = new SQLLayer("Data Source=(localdb)\\MSSQLLocalDB;Database=test;Integrated Security=SSPI");
            SQLServerTableConfigure configure = new SQLServerTableConfigure(sqlLayer, new SQLServerTableRepository(null)); 
            configure.AddTable(new Interfaces.TableConfigure.TableMetaData() { TableLabel = "testing", TableName = "test" });
        }
    }
}
