using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestClass : AssignmentBase
{
    /// <summary>
    /// Return a string
    /// </summary>
    /// <param name="cheese"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string stringCheese(string cheese)
    {
        return cheese;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Return the sum of c + e
    /// </summary>
    /// <param name="c"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int numberOfCheese(int c, int e)
    {
        return c + e;
        throw new NotImplementedException();
    }

    public bool returnsTinkatonIfZero(int num)
    {
        if (num == 0)
        {
            return true;
            Console.WriteLine("TINKATON!");
        }
        else
        {
            return false;
            Console.WriteLine("Pikachu");
        }
        throw new NotImplementedException();
    }

    /*
    Tests
    */
    [Assignment(1)]
    public void TestStringCheese()
    {
        string cheese = "the stringiest of cheese";
        Assert.Equal(stringCheese(cheese), cheese);
    }

    [Assignment(2)]
    public void TestnumberOfCheese()
    {
        int[] expected = { 16, 78, 9, 2, -6 };
        Assert.Equal(numberOfCheese(4, 12), expected[0]);
        Assert.Equal(numberOfCheese(76, 2), expected[1]);
        Assert.Equal(numberOfCheese(4, 5), expected[2]);
        Assert.Equal(numberOfCheese(1, 1), expected[3]);
        Assert.Equal(numberOfCheese(-4, -2), expected[4]);
    }

    [Assignment(3)]
    public void TestReturnTinkaton()
    {
        string tinkaton = "TINKATON";
        string pikachu = "Pikachu";
        Assert.True(returnsTinkatonIfZero(0), tinkaton);
        Assert.False(returnsTinkatonIfZero(1), pikachu);

    }
}