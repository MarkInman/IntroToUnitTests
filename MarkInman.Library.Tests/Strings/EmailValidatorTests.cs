using MarkInman.Library.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkInman.Library.Tests.Strings;

[TestClass]
public class EmailValidatorTests
{
    [TestMethod]
    public void IsValid_ValidEmail_ReturnTrue()
    {
        // Arrange
        var validator = new EmailValidator();

        // Act
        var result = validator.IsValid("lukeskywalker@deathstar.com");

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsValid_EmptyEmail_ReturnFalse()
    {
        var validator = new EmailValidator();

        var result = validator.IsValid(string.Empty);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_EmailWithNoAtSign_ReturnFalse()
    {
        var validator = new EmailValidator();

        var result = validator.IsValid("lukeskywalkerdeathstar.com");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsValid_EmailWithNoPeriod_ReturnFalse()
    {
        var validator = new EmailValidator();

        var result = validator.IsValid("lukeskywalker@deathstarcom");

        Assert.IsFalse(result);
    }
}
