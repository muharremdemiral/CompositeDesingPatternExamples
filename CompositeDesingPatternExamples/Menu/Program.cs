using System;

namespace MenuExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new Menu("Ana Menü");
            
            var drinksMenu = new Menu("İçecekler Menüsü");
            drinksMenu.Add(new MenuItem("Coca Cola", 25.00));
            drinksMenu.Add(new MenuItem("Portakal Suyu", 40.00));
            drinksMenu.Add(new MenuItem("Çay", 7.50));

            var foodMenu = new Menu("Yiyecekler Menüsü");
            foodMenu.Add(new MenuItem("Çorba", 25.00));
            foodMenu.Add(new MenuItem("Mantı", 90.00));
            
            mainMenu.Add(drinksMenu);
            mainMenu.Add(foodMenu);

            mainMenu.Display();

            Console.ReadLine();
        }
    }
}
