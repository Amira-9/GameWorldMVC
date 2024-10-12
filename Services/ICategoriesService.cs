using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace WebApplication2.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
    
}
