namespace Challenge;

/// <summary>
/// Given a string, return boolean if all the parentheses inside match general math conventions.<br/>
///
/// Input constraints: A string of max. 1024 ASCII chars.<br/>
/// Following considered as parentheses pairs: <c>() [] {}</c>.<br/>
///
/// Output examples:
/// <code>
///     var vp = new ValidParentheses();
///     vp.IsValid("5 + 6 * (3 - 2 / (...))") == true;
///     vp.IsValid("({}[]) [{}([])]") == true;
///
///     vp.IsValid("(( [)] )") == false;
///     //              ^ the ] expected
///     vp.IsValid("(( {}[] )") == false;
///     //                   ^ the ) is missing
/// </code>
/// </summary>
public class ValidParentheses
{
    public bool IsValid(string str)
    {
        /*** TODO: Implement me! */
        throw new NotImplementedException();
    }
}
