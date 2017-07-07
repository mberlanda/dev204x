using System;

namespace ModuleSixUbuntu {
    class Calculator : IDisposable {
        private bool disposed = false;

        // Constructor
        public Calculator(){
            Console.WriteLine("Calculator being created");
        }
        // Public Divide method
        public int Divide(int first, int second)
        {
            return first / second;
        }
        // Destructor
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public void Dispose()
        {
            if (!this.disposed)
                Console.WriteLine("Calculator being disposed");
            this.disposed = true;
            GC.SuppressFinalize(this);
        }

    }
}