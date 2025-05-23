using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using escola.Pages.Models;

namespace escola.Pages
{
    public class IndexModel : PageModel
    {
        private readonly escola.Data.escolaContext _context;

        public IndexModel(escola.Data.escolaContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
