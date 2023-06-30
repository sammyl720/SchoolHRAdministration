using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdmininstrationAPI
{
    /**
     * Note: The generic parameter T must be a class that is of type K and have an empty constructor
     */
    public static class FactoryPattern<K, T> where T:class, K, new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}
