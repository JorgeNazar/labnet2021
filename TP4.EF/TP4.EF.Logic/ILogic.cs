using System.Collections.Generic;


namespace TP4.EF.Logic
{
    interface ILogic <T>
    {
        List<T> GetAll();
        T GetByID(string id);
        int Add(T customers);
        void Delete(string id);
        void Modify(T paramCustomers);
    }
}
