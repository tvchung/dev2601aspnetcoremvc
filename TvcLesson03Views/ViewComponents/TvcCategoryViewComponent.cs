using Microsoft.AspNetCore.Mvc;

namespace TvcLesson03Views.ViewComponents
{
    public class TvcCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Models.TvcCategory> categories = new List<Models.TvcCategory>
            {
                new Models.TvcCategory { id = 1, Name = "Iphone", isActive = true },
                new Models.TvcCategory { id = 2, Name = "Samsung", isActive = false },
                new Models.TvcCategory { id = 3, Name = "Laptop Dell", isActive = true },
                new Models.TvcCategory { id = 4, Name = "laptop Lenovo", isActive = true },
                new Models.TvcCategory { id = 5, Name = "Cái gì đó", isActive = false }
            };
            return View(categories);
        }
    }
}
