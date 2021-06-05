
using System.Diagnostics;


namespace DependencyInjectionMultipleImplementationsCore.Services
{
    public class CrudRepositoryMongoDB : CrudRepository
    {
        public void Create()
        {
            Debug.WriteLine("Create With MongoDB");
        }

        public void Delete()
        {
            Debug.WriteLine("Delete With MongoDB");
        }

        public void Update()
        {
            Debug.WriteLine("Update With MongoDB");
        }
    }
}
