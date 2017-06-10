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
//        [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<ICurriculos, Curriculos>))]
        public bool desempregado { get; set; }

        [BsonIgnoreIfNull]
  //      [BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<ICurriculos, Curriculos>))]
        public string sexo { get; set; }

    }

}
