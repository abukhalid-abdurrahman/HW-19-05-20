namespace Day_24
{
    class MemoryManager
    {
        private static double memory = 0;

        public static void MemoryClear()
        {
            memory = 0;
        }
        public static double MemoryRecall()
        {
            return memory;
        }
        public static void MemoryStore(double A)
        {
            memory = A;
        }
        public static void MemoryPlus(double A)
        {
            memory += A;
        }
    }
}
