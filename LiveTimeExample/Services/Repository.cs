namespace LiveTimeExample.Services
{
    public class Repository
    {
        private readonly DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int RowCount => _dataContext.RowCount;
    }
}
