using Abby_Razor.Data;
using Abby_Razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_Razor.Pages.Categories
{
    [BindProperties]

    public class EditModel : PageModel
    {
        private readonly ApplicationDbContex _db;
        public Category Category { get; set; }

        public EditModel(ApplicationDbContex db)
        {
            _db = db;

        }
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            //Category = _db.Category.FirstOrDefault(u => u.Id == id);
            //Category = _db.Category.SingleOrDefault(u => u.Id == id);
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(String.Empty, "DisplayOrder cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                 _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
