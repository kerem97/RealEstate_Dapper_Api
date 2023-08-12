using Humanizer;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;
using System;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
