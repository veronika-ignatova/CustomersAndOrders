using DataBase;
using System;

var rep = new Repository();
var order = rep.GetOrderById(1);
var order1 = rep.GetOrderWithItemsById(5);
var custom1 = rep.GetCustomerWithOrderById(2);
Console.ReadLine();