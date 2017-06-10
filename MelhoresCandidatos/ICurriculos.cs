using MongoDB.Bson;

namespace MelhoresCandidatos
{
    public interface ICurriculos
    {
        ObjectId _id { get; set; }
        bool desempregado { get; set; }
        string sexo { get; set; }
    }
}
