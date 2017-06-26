using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MelhoresCandidatos
{

    [BsonIgnoreExtraElements]
    public class Curriculos : ICurriculos
    {

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonIgnoreIfNull]
        public bool desempregado { get; set; }

        [BsonIgnoreIfNull]
        public string sexo { get; set; }

        [BsonIgnoreIfNull]
        public string bairro { get; set; }

        [BsonIgnoreIfNull]
        public string cidade { get; set; }

        [BsonIgnoreIfNull]
        public string estado { get; set; }

        [BsonIgnoreIfNull]
        public int idade { get; set; }

        [BsonIgnoreIfNull]
        public string estado_civil { get; set; }

        [BsonIgnoreIfNull]
        public BsonArray cnh { get; set; }

        [BsonIgnoreIfNull]
        public BsonArray experiencia { get; set; }

        [BsonIgnoreIfNull]
        public BsonDocument objetivos { get; set; }

        [BsonIgnoreIfNull]
        public BsonArray idiomas { get; set; }

        [BsonIgnoreIfNull]
        public BsonArray formacao { get; set; }
    }

}
