using TemperatureChecker.Entities;

namespace TemperatureChecker.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);


    }
}
