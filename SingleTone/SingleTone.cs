using System;

namespace SingleTone
{
    class SingleTone
    {
        private static SingleTone instance;
        private static Object sync = new object();
        private string data;

        protected SingleTone() { }

        public static SingleTone GetInstance()
        {
            lock (sync)
            {
                if (instance == null)
                {
                    return instance = new SingleTone();
                }
                return instance;
            }
        }

        public void Test(string s)
        {
            this.data = s;
        }

        public override string ToString()
        {
            return data;
        }
    }
}
