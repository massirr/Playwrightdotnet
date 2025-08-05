using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightDemo;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //the previous version of setting up the browser is removed
        await Page.GotoAsync($"http://localhost:8080/");
        
        // Wait for the page to load and click on user button
        await Page.WaitForSelectorAsync("button.pi-user");
        await Page.ClickAsync("button.pi-user");
        
        // Fill in credentials
        await Page.FillAsync("input[placeholder='Enter your email or username']", "Back");
        await Page.FillAsync("input[placeholder='*******']", "4321");
        
        // Wait for submit button to be ready and click it
        await Page.WaitForSelectorAsync("button[type='submit']");
        await Page.ClickAsync("button[type='submit']");
        
        // Wait for navigation/page change after login
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }
}
