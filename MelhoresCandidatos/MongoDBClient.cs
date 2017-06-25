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

        public Curriculos GetCurriculoById(string id)
        {
            Curriculos curriculo = Collection.FindOneByIdAs<Curriculos>(ObjectId.Parse(id));

            return curriculo;
        }

        public List<Curriculos> GetQuery(string jsonQuery)
        {
            BsonDocument doc = BsonSerializer.Deserialize<BsonDocument>(jsonQuery);
            QueryDocument query = new QueryDocument(doc);
            return Collection.FindAs<Curriculos>(query).ToList();
        }

        public string[] DistinctField(string field)
        {
            var result = Collection.Distinct<string>(field).ToList();
            result.Sort();
            return result.ToArray();
        }

        public string[] DistinctFieldWithQuery(string field,QueryDocument query)
        {
            var result = Collection.Distinct<string>(field,query).ToList();
            result.Sort();
            return result.ToArray();
        }

        public ObjectId[] DistinctIDWithQuery(QueryDocument query)
        {
            var result = Collection.Distinct<ObjectId>("_id", query).ToList();
            return result.ToArray();
        }

        public QueryDocument DoQuery(string jsonQuery)
        {
            BsonDocument doc = BsonSerializer.Deserialize<BsonDocument>(jsonQuery);
            QueryDocument query = new QueryDocument(doc);

            return query;
        }
}
}
