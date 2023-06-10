using Edu.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Edu.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public HeaderViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = _layoutService.GetDatas();
            return await Task.FromResult(View(datas));
        }
    }
}
