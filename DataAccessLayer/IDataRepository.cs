using System;
using System.Collections.Generic;
using System.Text;

namespace JasonFinalExam.DataAccessLayer
{
    public interface IDataRepository<T>
    {
        T Get(int ID);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);       
    }
}
