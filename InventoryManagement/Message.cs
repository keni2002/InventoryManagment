﻿namespace InventoryManagement;

public class Message
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Inventory Management Console\n" +
                          "1. Add a new item\n" +
                          "2. Show all items\n" +
                          "Type a option:");
    }
}