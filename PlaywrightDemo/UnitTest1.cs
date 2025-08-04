// using Microsoft.Playwright;
//
// namespace PlaywrightDemo;
//
// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }
//
//     [Test]
//     public async Task Test1()
//     {
//         //Playwright
//         using var playwright = await Playwright.CreateAsync();
//         //Browser
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false
//         });
//         //page
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync($"http://192.168.129.83:8080/");
//         
//         // Wait for the page to load and click on user button
//         await page.WaitForSelectorAsync("button.pi-user");
//         await page.ClickAsync("button.pi-user");
//         
//         // Wait for login form to appear and take screenshot
//         await page.WaitForSelectorAsync("input[placeholder='Enter your email or username']");
//         await page.ScreenshotAsync(new PageScreenshotOptions
//         {
//             Path = "CraftIt.jpg"
//         });
//         
//         // Fill in credentials
//         await page.FillAsync("input[placeholder='Enter your email or username']", "Back");
//         await page.FillAsync("input[placeholder='*******']", "4321");
//         
//         // Wait for submit button to be ready and click it
//         await page.WaitForSelectorAsync("button[type='submit']");
//         await page.ClickAsync("button[type='submit']");
//         
//         // Wait for navigation/page change after login
//         await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
//         
//         // Take screenshot of the page after login
//         await page.ScreenshotAsync(new PageScreenshotOptions
//         {
//             Path = "user.jpg"
//         });
//     }
// }
