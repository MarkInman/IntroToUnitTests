using MarkInman.Library.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkInman.Library.Tests.Math;

[TestClass]
public class CalculatorTests
{
    // naming: MethodName_Scenerio_ExpectedOutcome
    [TestMethod]
    public void Add_AddsTwoWholeNumbers_SumOfThoseNumbers()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(1, 2);

        // Assert
        Assert.AreEqual(3, result);
    }
        

}
