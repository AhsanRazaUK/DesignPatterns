using System;

namespace Creational
{
    public sealed class SingletonPatternThreadSafe : IDisposable
    {
        private bool _disposed;

        public static volatile SingletonPatternThreadSafe _instance;
        public static readonly object _synclock = new object();
        private SingletonPatternThreadSafe() { }

        public static SingletonPatternThreadSafe Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (_synclock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonPatternThreadSafe();
                    }
                }

                return _instance;
            }
        }
        public int SomeValue { get; set; }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed == true) return;

            if (disposing == true)
            {
                // clean up the instance
                _instance = null;
            }

            _disposed = true;
        }
        ~SingletonPatternThreadSafe()
        {
            Dispose(false);
        }
    }
}
