using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the to do list!");
      Console.WriteLine("Would you like to add an item or view your list? type (Add or View)");
      string userInput = Console.ReadLine();
      
      List<Item> newList = new List<Item>{};
      if (userInput == "Add")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string itemDescription = Console.ReadLine();
        Item newDescription = new Item(itemDescription);
        string newItem = newDescription.Description;
        Console.WriteLine(newItem + " has been added to your list.");
        Main();
      }
      else if (userInput == "View")
      {
        List<Item> result = Item.GetAll();
        foreach (Item thisItem in result)
        counter = 0
        ++
        Console.WriteLine("Output: " + thisItem.Description);
        Main();
      }
      else
      {
        Main();
      }
    }  
  }
}