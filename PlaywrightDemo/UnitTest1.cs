using Microsoft.Playwright;

namespace PlaywrightDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();
        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        //page
        var page = await browser.NewPageAsync();
        await page.GotoAsync($"http://192.168.129.83:8080/");
        await page.ClickAsync(selector: "text=camp");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "CraftIt.jpg"
        });
    }
}
