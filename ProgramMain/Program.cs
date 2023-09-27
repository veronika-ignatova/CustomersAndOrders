using DataBase;
using System;

var rep = new Repository();
//var order = rep.GetOrderById(1);
//var order1 = rep.GetOrderWithItemsById(2);

var a = rep.GetOrderById(2);
rep.GetDiscountsForOrder(a);
rep.GetTotalPriceInOrder(a);

var custom1 = rep.GetCustomerWithOrderById(2);
var price = rep.GetPriceByOrderId(2);

//var fff = rep.GetCustomerByOrderId(2);

var order2 = rep.GetOrderWithItemsById(2);


var a1 = rep.GetOrderById(5);
var custom11 = rep.GetCustomerWithOrderById(5);
var price1 = rep.GetPriceByOrderId(5);

//var fff1 = rep.GetCustomerByOrderId(5);
var order21 = rep.GetOrderWithItemsById(5);
var totalTotalTotal = rep.GetTotalWithDelivery(5);
var order212 = rep.GetOrderWithItemsById(5);


 Console.ReadLine();