using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_GameProject.Abstract
{
    interface IGenericService<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
