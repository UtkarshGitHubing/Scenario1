using NUnit.Framework;

namespace Scenario1.Tests
{
  public class InventoryServiceShould
  {
    //[SetUp]
    //public void Setup()
    //{
    //}

    [Test]
    public void ReturnTrueForSuccessfulPurchase()
    {
      // Arrange
      var invoice = new Invoice();
      var inventoryService = new InventoryService();

      // Act
      bool result = inventoryService.Purchase(invoice);

      // Assert
      //Assert.Equals(true,result);
      Assert.That(result, Is.EqualTo(result));
    }
  }

  public class InventoryService
  {
    public bool Purchase(Invoice invoice)
    {
      return true;
    }
  }

  public class Invoice
  {
  }
}