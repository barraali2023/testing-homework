using System.Reflection;
using unitTestingDemo.core;

using unitTestingDemo.core;

namespace unitTestingDemo.Tests;

public class DivideAndIseven
{
    
   

                // اختبار دالة القسمة
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10, b = 2;
        // Act
        int result = Class1.Divide(a, b);
        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByOne_ReturnsSameNumber()
    {
        // Arrange
        int a = 7, b = 1;
        // Act
        int result = Class1.Divide(a, b);
        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Divide_NegativeByPositive_ReturnsNegative()
    {
        // Arrange
        int a = -10, b = 2;
        // Act
        int result = Class1.Divide(a, b);
        // Assert
        Assert.Equal(-5, result);
    }


[Fact]
public void IsEven_EvenNumber_ReturnsTrue()
{
    // Arrange
    int a = 8;
    // Act
    bool result = Class1.IsEven(a);
    // Assert
    Assert.True(result);
}

[Fact]
public void IsEven_OddNumber_ReturnsFalse()
{
    // Arrange
    int a = 7;
    // Act
    bool result = Class1.IsEven(a);
    // Assert
    Assert.False(result);
}

[Fact]
public void IsEven_Zero_ReturnsTrue()
{
    // Arrange
    int a = 0;
    // Act
    bool result = Class1.IsEven(a);
    // Assert
    Assert.True(result);
}


}


// وظيفة باقي لاختبارات