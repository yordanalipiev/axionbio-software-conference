using Challenge;

namespace Tests;

public class ValidParenthesesTests
{
    [Test]
    public void Should_Pass_On_Valid_Parentheses()
    {
        var par = new ValidParentheses();
        var validParentheses = new string[]
        {
            "", "test",
            "3 - 9 * (5 + 3)",
            "this (is [() {[ () ]} ] is) valid",
            "((   {[({})]} test ((([{}])__[] __ ))))",
        };

        foreach (var s in validParentheses)
        {
            Assert.True(par.IsValid(s), $"Should return True for '{s}'");
        }
    }

    [Test]
    public void Should_Fail_On_Invalid_Parentheses()
    {
        var par = new ValidParentheses();
        var invalidParentheses = new string[]
        {
            "[", "(((a))]",
            "((( ))",
            "({[})"
        };

        foreach (var s in invalidParentheses)
        {
            Assert.False(par.IsValid(s), $"Should return False for '{s}'");
        }
    }
}
