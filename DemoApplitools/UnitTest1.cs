using DemoApplitools.PlaywrightDemo.Models;
using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DemoApplitools
{
    public class Tests
    {
        [SetUp]
        public async Task SetupAsync()
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

        }

        [Test]
        public async Task LoginWithValidCredentials()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 200
            }
            );

            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://demo.applitools.com/");

            LoginPage loginPage = new LoginPage(page);
            await loginPage.LoginWebsite("demo@qa.team", "123456");

            Assert.NotNull(loginPage);
        }
    }
}