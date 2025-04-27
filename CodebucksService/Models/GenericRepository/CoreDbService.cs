using CodebucksService.Models.Interface;
using CodebucksService.Models.Helper;

namespace CodebucksService.Models.GenericRepository
{
    public class CoreDbService<T> : ICoreService<T> where T : CoreEntity
    {
        private readonly CodebucksDbContext _db; // Değeri yok(boş)

        public CoreDbService(CodebucksDbContext context)
        {
            _db = context; // _db İçi Dolu
        }

        public bool Create(T entity)
        {
            try
            {
                // Set<T>() -->  Set metodu tablo ismi olarak T türü ne gönderilirse buraya Sınıfla bağlantı tablo adını otomatik bir şekilde yerleştirecek
                _db.Set<T>().Add(entity); // Ekledik

                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _db.Set<T>().Remove(entity); // Sildik

                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Get(int id) => _db.Set<T>().Find(id)!;

        public List<T> GetAll() => _db.Set<T>().ToList();

        //{
        //    return _db.Set<T>().ToList(); // Refactoring ---> Kodun çalışmasını bozmadan kodda yapılan sadeleştirme işlemine denir.
        //}

        public bool Update(T entity)
        {
            try
            {
                _db.Set<T>().Update(entity); // Güncelledik
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Save()
        {
            return _db.SaveChanges() > 0 ? true : false; // Kaydettik sonucu döndük
        }
    }
}