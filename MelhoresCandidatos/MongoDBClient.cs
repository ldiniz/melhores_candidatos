using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace MelhoresCandidatos
{
    public class MongoDBClient
    {
        public MongoCollection Collection;

        public MongoDBClient()
        {
            var cliente = new MongoClient("mongodb://localhost:27017");
            var server = cliente.GetServer();
            MongoDatabase Database = server.GetDatabase("melhores_candidatos");
            Collection = Database.GetCollection<Curriculos>("curriculos");

        }

        public List<Curriculos> GetQuery(string jsonQuery)
        {
            BsonDocument doc = BsonSerializer.Deserialize<BsonDocument>(jsonQuery);
            QueryDocument query = new QueryDocument(doc);
            return Collection.FindAs<Curriculos>(query).ToList();
        }

    }
}
