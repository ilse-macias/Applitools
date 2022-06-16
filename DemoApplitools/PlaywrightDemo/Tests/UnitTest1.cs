using DemoApplitools.PlaywrightDemo.Models;
using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DemoApplitools
{
    public class Tests
    {
        protected IPlaywright playwright;
        protected IBrowser browser;
        protected IPage page;

        [SetUp]
        public async Task SetupAsync()
        {

            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 200
            }
            );

            page = await browser.NewPageAsync();
            await page.GotoAsync("https://demo.applitools.com/");

        }

        [Test, Description("User must log in with valid credentials")]
        public async Task LoginWithValidCredentials()
        {
            //using var playwright = await Playwright.CreateAsync();
            //await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            //{
            //    Headless = false,
            //    SlowMo = 200
            //}
            //);

            //var page = await browser.NewPageAsync();
            //await page.GotoAsync("https://demo.applitools.com/");

            LoginPage loginPage = new LoginPage(page);
            await loginPage.LoginWebsite("demo", "123456");

            Assert.NotNull(loginPage);
        }

        [Test, Description("Verify if the user name is displayed once after logining.")]
        public async Task VerifyUserName()
        {

        }
    }
}