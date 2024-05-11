using LiveTimeExample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LiveTimeExample.Pages
{
    public class RowCountModel : PageModel
    {
        private readonly DataContext _dataContext;
        private readonly Repository _repository;


        public int RepositoryCount { get; set; }
        public int DataContextCount { get; set; }

        public RowCountModel(Repository repository, DataContext dataContext)
        {
            _repository = repository;
            _dataContext = dataContext;
        }


        public void OnGet()
        {
            RepositoryCount = _repository.RowCount;
            DataContextCount = _dataContext.RowCount;
        }
    }
}
