using System.Collections.Generic;

namespace denverone.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
