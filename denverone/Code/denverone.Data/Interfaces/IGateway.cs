using MongoDB.Driver;

namespace denverone.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
