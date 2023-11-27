using Microsoft.Playwright;
using System.Text.RegularExpressions;

namespace DotNet_Demo.Pages;

public class Formpage
{
    private IPage _page;
    private readonly ILocator forms;
    private readonly ILocator practice_form;
    private readonly ILocator fname;
    private readonly ILocator lname;
    private readonly ILocator email;
    private readonly ILocator gender;
    private readonly ILocator mobile;
    private readonly ILocator subjects;
    private readonly ILocator hobbies;
    private readonly ILocator submit_btn;

    public Formpage(IPage page)
    {
        _page = page;
        forms = _page.Locator("(//div[@class='card mt-4 top-card'])[2]");
        practice_form = _page.Locator("//span[normalize-space()='Practice Form']");
        fname = _page.Locator("#firstName");
        lname = _page.Locator("#lastName");
        email = _page.Locator("#userEmail");
        gender = _page.Locator("label[for='gender-radio-1']");
        mobile = _page.Locator("#userNumber");
        hobbies = _page.Locator("//label[normalize-space()='Sports']");
        submit_btn = _page.Locator("#submit");

    }

    public async Task ClickForms() => await forms.ClickAsync();
    public async Task ClickPracticeForm() => await practice_form.ClickAsync();
    public async Task TextFname() => await fname.FillAsync("test");
    public async Task TextLname() => await lname.FillAsync("test");
    public async Task TextEmail() => await email.FillAsync("test@test.com");
    public async Task CheckGender() => await gender.CheckAsync();
    public async Task TextMobile() => await mobile.FillAsync("8095555555");
    public async Task SelectHobbie() => await hobbies.ClickAsync();
    public async Task ClickSubmit() => await submit_btn.ClickAsync();

}



