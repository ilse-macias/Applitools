using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplitools.PlaywrightDemo.Models
{
    public class BasePage
    {
        private IPage _page;

        public BasePage(IPage page)
        {
            _page = page;
        }

        public async Task Navigate()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 200
            }
            );

            var page = await browser.NewPageAsync();
        }
    }
}
