using DotNet_Demo.Pages;
using Microsoft.Playwright;

namespace DotNet_Demo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    
    [Test]
    public async Task TestPOM()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();
       
        //Browser 
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless  = true
           
        });
       
        //Page 
        var page = await browser.NewPageAsync();

    
       // await page.GotoAsync("https://demoqa.com/");
       // await page.SetViewportSizeAsync( width: 1920, height: 1080 );

        Formpage formpage = new Formpage(page);
        await formpage.NavigateToPageAsync();
        await formpage.SetViewportSize();
        await formpage.ClickForms();
        await formpage.ClickPracticeForm();
        await formpage.TextFname();
        await formpage.TextLname();
        await formpage.TextEmail();
        await formpage.CheckGender();
        await formpage.TextMobile();
        await formpage.SelectHobbie();
        await formpage.ClickSubmit();

    }
    
    [Test]
     public async Task TestPOM2()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();
       
        //Browser 
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless  = false
           
        });
       
        //Page 
        var page = await browser.NewPageAsync();

        
        //await page.GotoAsync("https://demoqa.com/");
        //await page.SetViewportSizeAsync( width: 1920, height: 1080 );

        Formpage formpage = new Formpage(page);
        await formpage.NavigateToPageAsync();
        await formpage.SetViewportSize();
        await formpage.ClickForms();
        await formpage.ClickPracticeForm();
        await formpage.TextFname();
        await formpage.TextLname();
        await formpage.TextEmail();
        await formpage.CheckGender();
        await formpage.TextMobile();
        await formpage.SelectHobbie();
        await formpage.SelectSubject();
        await formpage.ClickSubmit();
        

    }
} 