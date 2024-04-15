using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarkInman.Library.Strings.EmailValidator;

namespace MarkInman.Library.Tests.Strings;

[TestClass]
public class PalindromeCheckerTests
{
    [TestMethod]  
    public void IsPalindrome_SpeltSameBackwardsAndForwards_ReturnTrue()
    {
        var checker = new PalindromeChecker();

        var result = checker.IsPalindrome("mom");

        Assert.IsTrue(result); 
    }

    [TestMethod]
    public void IsPalindrome_SingleCharacter_ReturnTrue()
    {
        var checker = new PalindromeChecker();

        var result = checker.IsPalindrome("a");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPalindrome_NonPalidromeWord_ReturnFalse()
    {
        var checker = new PalindromeChecker();

        var result = checker.IsPalindrome("Mark");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsPalindrome_EmptyString_ReturnFalse()
    {
        var checker = new PalindromeChecker();

        var result = checker.IsPalindrome(string.Empty);

        Assert.IsFalse(result);
    }
}
