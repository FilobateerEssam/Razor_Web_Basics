using Abby_Razor.Data;
using Abby_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContex _db;

        // to Retrieve All (bind )

        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContex db)
        {
             _db = db;
        }
        public void OnGet()
        {
            // for all 
            Categories = _db.Category;
        }
    }
}
