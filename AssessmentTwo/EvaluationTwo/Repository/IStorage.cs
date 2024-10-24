using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.Repository
{
    internal interface IStorage<T>
    {
        void Add( T obj);

        List<T> GetAll();

        void Update( T obj );

        void Delete (int id);
    }
}
