using System;

namespace SingleTone
{
    class SingleTone
    {
        private static SingleTone instance;

        protected SingleTone() { }

        public static SingleTone GetInstance()
        {
            return instance == null ? instance = new SingleTone() : instance;
        }
    }
}
