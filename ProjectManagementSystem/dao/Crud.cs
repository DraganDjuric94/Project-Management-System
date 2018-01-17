using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dao
{
    interface Crud<T>
    {
        void Create(T obj);
        List<T> Read(T obj);
        void Update(T obj);
        void Delete(Int32 id);
    }
}
