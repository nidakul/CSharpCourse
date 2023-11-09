using System;
namespace Methods2
{
	public class CartManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("Sepete Eklendi : " + product.Name);
		}
	}
}

