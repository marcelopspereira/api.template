using System;
using System.Data.Entity;
using api.template.Infra.DataContexts;

namespace api.template.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDataContext _context;
        private bool _disposed;

        public UnitOfWork(AppDataContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            //throw new NotImplementedException();
        }

     
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
