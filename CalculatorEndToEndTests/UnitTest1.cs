using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace CalculatorEndToEndTests;

/*
[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public async Task CalculatorWebUi_PageTitle_IsCalculator()
    {
        const string pageTitle = "Calculator";

        await Page.GotoAsync("http://localhost:5194/");
        
        await Expect(Page).ToHaveTitleAsync(pageTitle);
    }

    [Test]
    public async Task CalculatorUI_Title_IsCalculator()
    {
        await Page.GotoAsync("localhost:5194");
        await Expect(Page).ToHaveTitleAsync("Calculator");
    }
}
*/