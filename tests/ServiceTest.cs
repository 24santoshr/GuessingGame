namespace Test;

using System.Reflection;
using Game;


public class ServiceTest
{
    [Fact]
    public void TestGenerateOutput_WithVaildValues()
    {

        // Arrange
        Type type = typeof(Service);
        MethodInfo method = type.GetMethod("GenerateOutput", BindingFlags.Public | BindingFlags.Static);

        // Act
        var result = (string)method.Invoke(null, new object[] { 2, 3, 5 });

        // Assert
        var expected = typeof(string);
        Assert.IsType(expected, result);
    }

    [Fact]
    public void TestGetFinalResult_WithVaildValues()
    {

        // Arrange
        Type type = typeof(Service);
        MethodInfo method = type.GetMethod("GetFinalResult", BindingFlags.Public | BindingFlags.Static);

        // Act
        var result = (string)method.Invoke(null, new object[] { 2, 3, 5, 6, 5 });

        // Assert
        var expected = typeof(string);
        Assert.IsType(expected, result);
    }
}