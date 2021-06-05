using System.Diagnostics;


namespace DependencyInjectionMultipleImplementationsCore.Services
{
    public class CrudRepositorySqlServer : CrudRepository
    {
        public void Create()
        {
            Debug.WriteLine("Create With SqlServer");
        }

        public void Delete()
        {
            Debug.WriteLine("Delete With SqlServer");
        }

        public void Update()
        {
            Debug.WriteLine("Update With SqlServer");
        }
    }
}
