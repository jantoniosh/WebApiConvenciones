using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Convenciones.TestUnit
{
    public class ConvencionesTest
    { 
        public static DbContextOptions<DemoConvencionesDBContext> dbContextOptions { get; set; }
    private static string connectionString = "Data Source=LAPTOP-K0T01G6Q\\TEW_SQLEXPRESS;Initial Catalog=DemoConvencionesDB;Integrated Security=True;MultipleActiveResultSets=True";
    static ConvencionesTest()
    {
        dbContextOptions = new DbContextOptionsBuilder<DemoConvencionesDBContext>()
            .UseSqlServer(connectionString)
            .Options;
    }
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}