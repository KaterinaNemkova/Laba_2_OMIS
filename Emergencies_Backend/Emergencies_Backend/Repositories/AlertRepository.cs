using Emergencies_Backend.Models;


namespace Emergencies_Backend.Repositories
{
    public interface AlertRepository
    {
        void FindAll();
        void Save(Alert alert);
    }
}
