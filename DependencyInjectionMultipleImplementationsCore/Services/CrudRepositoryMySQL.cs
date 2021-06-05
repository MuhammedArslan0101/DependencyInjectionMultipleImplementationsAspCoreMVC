using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMultipleImplementationsCore.Services
{
    public class CrudRepositoryMySQL : CrudRepository
    {
        public void Create()
        {
            Debug.WriteLine("Create With MySQL");
        }

        public void Delete()
        {
            Debug.WriteLine("Delete With MySQL");
        }

        public void Update()
        {
            Debug.WriteLine("Update With MySQL");
        }
    }
}
