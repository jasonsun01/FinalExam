using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JasonFinalExam.DataAccessLayer
{
    public class FinalExamRepository<T> : IDataRepository<T> where T : class
    {
        private FinalExameDbContext _context;

        public void Add(params T[] items)
        {
            using (_context = new FinalExameDbContext())
            {
                foreach (var item in items)
                {
                    _context.Entry<T>(item).State = EntityState.Added;

                }

                _context.SaveChanges();
            }
        }

        public T Get(int ID)
        {
            using (_context = new FinalExameDbContext())
            {
                return _context.Set<T>().Find(ID);
            }
        }

        public void Remove(params T[] items)
        {
            using (_context = new FinalExameDbContext())
            {
                foreach (var item in items)
                {
                    _context.Entry<T>(item).State = EntityState.Deleted;

                }

                _context.SaveChanges();
            }
        }

        public void Update(params T[] items)
        {
            using (_context = new FinalExameDbContext())
            {
                foreach (var item in items)
                {
                    _context.Entry<T>(item).State = EntityState.Modified;

                }

                _context.SaveChanges();
            }
        }
    }
}
