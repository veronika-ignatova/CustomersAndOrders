using DataBase;
using System;

var rep = new Repository();
var order = rep.GetOrderById(1);
var order1 = rep.GetOrderWithItemsById(1);
var custom1 = rep.GetCustomerWithOrderById(1);
Console.ReadLine();