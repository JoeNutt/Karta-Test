namespace cart.tests;
public class Tests
{
    private Product A99; 
     private Product B15;
        private Product C40;
        
    [SetUp]
    public void Setup()
    {
        A99 = new Product()
        {
            name = "A99",
            price = 0.30, 
        }; 
        B15 = new Product()
        {
            name = "B15",
            price = 0.50, 
        };
        C40 = new Product()
        {
            name = "C40",
            price = 2.50, 
        };
    }

    [Test]
   public void ScanTwoProducts()
    {
        var checkout = new Checkout();
        checkout.Scan(A99);
        checkout.Scan(A99);
        double result = checkout.GetTotal();
        Assert.AreEqual(0.60, result);
    }
   
    [Test]
    public void ScanThreeA99Products()
    {
        var checkout = new Checkout();
        checkout.Scan(A99);
        checkout.Scan(A99);
        checkout.Scan(A99);
        double result = checkout.GetTotal();
        Assert.AreEqual(1, result);
    }
    [Test]
    public void ScanTwoB15Products()
    {
        var checkout = new Checkout();
        checkout.Scan(B15);
        checkout.Scan(B15);
        double result = checkout.GetTotal();
        Assert.AreEqual(0.55, result);
    }
}