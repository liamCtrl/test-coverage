namespace AtmServices.Test;

using AtmServices;
public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {

        testAtm = new Atm(initialBalance);

    }



    [Fact]

    public void Test_Withdraw()

    {
        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());
        
        var result2 = testAtm.withdraw(200);

        Assert.False(result2);

        Assert.Equal(75, testAtm.getBalance());
        
    }
    

    [Fact]

    public void Test_Deposit()
    {
        var result = testAtm.deposit(25);

        Assert.True(result);

        Assert.Equal(125, testAtm.getBalance());

        var result2 = testAtm.deposit(-50);

        Assert.False(result2);

        Assert.Equal(125, testAtm.getBalance());

    }

}
