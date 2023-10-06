using Core.Model;
using DataBase;
using Service;
using System;

var rep = new Repository();
var customerService = new CustomerService(rep);
var orderService = new OrderService(rep);


var order = orderService.GetOrderById(1);
var order2 = orderService.GetOrderById(2);
var order3 = orderService.GetOrderById(3);
order.AddItem += Add;

var item = orderService.GetItemById(5);

order.AddNewItem(item);




static void Add(object obj, string msg)
{
    Console.WriteLine(msg);
}

 Console.ReadLine();