using System;
namespace OOP1
{
	public class ProductManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("Ürün Eklendi : " + product.Name);
		}

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi : " + product.Name);
        }

		/*
		public int Topla(int number1, int number2)
		{
			return number1 + number2;
		}

        public void Topla2(int number1, int number2)
        {
			Console.WriteLine(number1 + number2);
        }*/
    }
}

