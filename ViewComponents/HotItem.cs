using Microsoft.AspNetCore.Mvc;
using PDPDay3View.Models;

namespace PDPDay3View.ViewComponents

{
    public class HotItem : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hp = new List<Item>
            {
                new Item  { Name = "Nồi cơm điện zuno A100 5090", Img = "image/noicom.jpg" },
                new Item  { Name = "Nồi cơm điện zuno A100 5090", Img = "image/noicom.jpg" },
                new Item  { Name = "Nồi cơm điện zuno A100 5090", Img = "image/noicom.jpg" }

            };

            return View(hp);
        }
    }
}
