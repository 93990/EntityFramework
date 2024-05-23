using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sakshi_Web_APP.Data;
using Sakshi_Web_APP.Models;

namespace Sakshi_Web_APP.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly  ApplicationDbContext _db;
        public IEnumerable<Categoryies> Category { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Category = _db.Category;
        }
    }
}
