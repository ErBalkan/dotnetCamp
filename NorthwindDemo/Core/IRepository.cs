namespace Core;

public interface IRepository<T>
where T : class, IEntity, new()
{
    List<T> GetAll();
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}

/*
T : class, IEntity, new() kısıtı:

T bir sınıf olacak,

IEntity arayüzünü implemente edecek,

ve parametresiz bir constructor'a sahip olacak.
*/