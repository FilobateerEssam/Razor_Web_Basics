using Abby_Razor.Data;
using Abby_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_Razor.Pages.Categories
{
    // help to bind All inside the UI

    [BindProperties]

    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContex _db;
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContex db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(String.Empty , "DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
