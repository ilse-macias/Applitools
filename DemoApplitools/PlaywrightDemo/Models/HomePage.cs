using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplitools.PlaywrightDemo.Models
{
    public class HomePage
    {
        private IPage _page;

        public HomePage(IPage page)
        {
            _page = page;
        }

        private ILocator _usernameText => _page.Locator(".logged-user-name");
        private ILocator _balanceText => _page.Locator(".balance-value");

        public async Task UsernameVisible()
        {
            string username = await _usernameText.InnerTextAsync();
           // return await username;
        }
    }
}
