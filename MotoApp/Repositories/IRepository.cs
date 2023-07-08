using TemperatureChecker;
namespace TemperatureChecker.Repositories;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class , IEntity
{


}
