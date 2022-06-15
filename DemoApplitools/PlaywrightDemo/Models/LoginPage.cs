using Microsoft.Playwright;
using System.Threading.Tasks;

namespace DemoApplitools.PlaywrightDemo.Models
{
    public class LoginPage
    {
        private IPage _page;

        //Constructor
        public LoginPage(IPage page)
        {
            _page = page;
        }

        //Locators
        private ILocator _usernameText => _page.Locator("#username");
        private ILocator _passwordText => _page.Locator("#password");
        private ILocator _signInButton => _page.Locator("#log-in");

        //Methods
        public async Task LoginWebsite(string username, string password)
        {
            await _usernameText.FillAsync(username);
            await _passwordText.FillAsync(password);
            await _signInButton.ClickAsync();
        }
    }
}
