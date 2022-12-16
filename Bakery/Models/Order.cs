using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public int TotalPrice { get; set; }
    private static List<Order> _cart = new List<Order> { };    
    

    public Order(string title, string date, string description, int quantity, int price)
    {
      Title = title;
      Date = date;
      Description = description;
      Quantity = quantity;
      Price = price;
      TotalPrice = price * quantity;
      _cart.Add(this);
      Id = _cart.Count;
    }

    public static void ClearAll()
    {
      _cart.Clear();
    }
  }
}