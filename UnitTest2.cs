using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using System.Text.RegularExpressions;


[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task MyTest2()
    {
        await Page.GotoAsync("https://demoqa.com/");

        await Page.Locator("div:nth-child(2) > div > .card-up").ClickAsync();

        await Page.GotoAsync("https://demoqa.com/");

        await Page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Forms$") }).First.ClickAsync();

        await Page.GetByRole(AriaRole.Listitem).ClickAsync();

        await Page.GetByPlaceholder("First Name").ClickAsync();

        await Page.GetByPlaceholder("First Name").FillAsync("test");

        await Page.GetByPlaceholder("Last Name").ClickAsync();

        await Page.GetByPlaceholder("Last Name").FillAsync("test");

        await Page.GetByPlaceholder("name@example.com").ClickAsync();

        await Page.GetByPlaceholder("name@example.com").FillAsync("test@tes.com");

    }
}