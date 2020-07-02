using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint01
{
    public abstract class CloseableResource
    {
        public void Close()
        {

        }
    }

    public class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (disposedValue) return;
            if (disposing)
            {
                Console.WriteLine("Disposing by developer");
            }
            else
            {
                Console.WriteLine("Disposing by GC");
            }
            disposedValue = true;
            base.Close();
        }

        ~DisposePatternImplementer()
        {            
            Close();
            Dispose(disposing: false);            
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
