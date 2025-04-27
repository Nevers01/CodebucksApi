using CodebucksService.Models.Helper;

namespace CodebucksService.Models.Interface
{
    public interface ICoreService<T> where T : CoreEntity
    {
        // Ekle
        bool Create(T entity);

        // Güncelle
        bool Update(T entity);

        // Sil
        bool Delete(T entity);

        // Listele
        List<T> GetAll();

        // Tek Kayıt
        T Get(int id);
    }
}