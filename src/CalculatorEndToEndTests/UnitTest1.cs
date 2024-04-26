using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace CalculatorEndToEndTests;


[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public async Task CalculatorUI_Title_IsCalculator()
    {
        await Page.ReloadAsync();
        await Page.GotoAsync("localhost:5194");
        await Expect(Page).ToHaveTitleAsync("Calculator");
    }


    [Test]
    public async Task CalculatorUI_AddInputs_ReturnsSum()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var InputB = Page.GetByLabel("inputB");
        var Add = Page.GetByText("A + B");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("3.5");
        await InputB.FillAsync("4.5");
        await Add.ClickAsync();
        await Expect(Display).ToContainTextAsync("3.5 + 4.5 = 8");

    }

    [Test]
    public async Task CalculatorUI_DivideByZero_DisplaysError()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var InputB = Page.GetByLabel("inputB");
        var Divide = Page.GetByText("A / B");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("3.5");
        await InputB.FillAsync("0");
        await Divide.ClickAsync();
        await Expect(Display).ToContainTextAsync("Not a number");

    }

    [Test]
    public async Task CalculatorUI_AddString_DisplaysError()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var InputB = Page.GetByLabel("inputB");
        var Add = Page.GetByText("A + B");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("3.5");
        await InputB.FillAsync("six");
        await Add.ClickAsync();
        await Expect(Display).ToContainTextAsync("Please enter only valid numbers");

    }

    [Test]
    public async Task CalculatorUI_Clear_DisplaysDefaultMessage()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var InputB = Page.GetByLabel("inputB");
        var Add = Page.GetByText("A + B");
        var Display = Page.GetByLabel("output");
        var Clear = Page.GetByText("Clear");
        await InputA.FillAsync("3.5");
        await InputB.FillAsync("4.5");
        await Add.ClickAsync();
        await Clear.ClickAsync();
        await Expect(Display).ToContainTextAsync("Enter value(s) below and select an operation");
    }

    [Test]
    public async Task CalculatorUI_Divide_DisplaysQuotient()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var InputB = Page.GetByLabel("inputB");
        var Divide = Page.GetByText("A / B");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("20");
        await InputB.FillAsync("5");
        await Divide.ClickAsync();
        await Expect(Display).ToContainTextAsync("4");

    }

    [Test]
    public async Task CalculatorUI_Factorial_DisplaysAnswer()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var Factorial = Page.GetByText("A!");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("6");
        await Factorial.ClickAsync();
        await Expect(Display).ToContainTextAsync("720");

    }

    [Test]
    public async Task CalculatorUI_Sin_DisplaysAnswer()
    {
        
        await Page.GotoAsync("localhost:5194");
        await Page.ReloadAsync();
        var InputA = Page.GetByLabel("inputA");
        var Sin = Page.GetByText("sin A");
        var Display = Page.GetByLabel("output");
        await InputA.FillAsync("90");
        await Sin.ClickAsync();
        await Expect(Display).ToContainTextAsync("0.89399666");
    }

}
