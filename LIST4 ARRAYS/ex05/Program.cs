internal class Program
{
    private static void Main(string[] args)
    {
        char[] myPool = GenerateRandomPool();

    }
    /// <summary>
    /// Generates a random pool of results, '1', 'X' or '2'
    /// for each match
    /// </summary>
    /// <returns>an array of 14 chars as the random generated values</returns>
    public static char[] GenerateRandomPool()
    {
        Random r = new Random();
        const int N = 14;
        int partit;
        char[] pool = new char[N];
        for (int i = 0; i < pool.Length; i++)
        {
            partit = r.Next(0, 3);
            switch (partit)
            {
                case 1:
                    pool[i] = '1';
                    break;
                case 2:
                    pool[i] = '2';
                    break;
                case 0:
                    pool[i] = 'X';
                    break;
            }
        }
        return pool;
    }

    public static int Check4Prize(char[] target, char[] winning)
    {
        int i = 0;
        int hits = 14;
        while (i < 14 && hits >= 11)
        {
            if (target[i] != winning[i]) hits--;
            i++;
            
        }
        if (hits == 10) hits = 0; 
        return hits;
    }
}