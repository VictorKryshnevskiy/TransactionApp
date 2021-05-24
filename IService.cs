using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    interface IService <T> where T : IModel
    {
        void Add(T item);
        string Get(int id);
    }
}
