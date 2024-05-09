namespace LiveTimeExample.Services
{
    public class DataContext
    {
        public readonly Random _rand = new Random();

        
        public DataContext()
        {
            RowCount = _rand.Next(1, 1_000_000_000);
        }

        public int RowCount { get; }

    }
}
