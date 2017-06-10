using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace MelhoresCandidatos.Tests
{
    [TestClass()]
    public class MongoDBClientTests
    {
        [TestMethod()]
        public void mainTest()
        {
            MongoDBClient mongo;
            mongo = new MongoDBClient();
            string jsonQuery = "{ sexo : 'Feminino', desempregado : true }";
            List<Curriculos> results = mongo.GetQuery(jsonQuery);

            foreach (Curriculos cur in results)
            {
                Debugger.Break();
            }

            Assert.Fail();
        }
    }
}