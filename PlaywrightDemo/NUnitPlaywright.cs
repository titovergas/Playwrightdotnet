using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo
{
    public class NUnitPlaywright : PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync(url: "http://eaapp.somee.com");
        }

        [Test]
        public async Task Test1()
        {          
            
            await Page.ClickAsync(selector: "text=Login");
            await Page.FillAsync(selector: "#UserName", value: "admin");
            await Page.FillAsync(selector: "#Password", value: "password");
            await Page.ClickAsync(selector: "text=Log in");
            Expect(Page.Locator(selector: "text='Employee Details'")).ToBeVisibleAsync();

        }
    }
}