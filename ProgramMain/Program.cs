using DataBase;
using System;

var rep = new Repository();
//var order = rep.GetOrderById(1);
//var order1 = rep.GetOrderWithItemsById(2);

var a = rep.GetOrderById(2);
var custom1 = rep.GetCustomerWithOrderById(2);
var price = rep.GetPriceByOrderId(2);

//var fff = rep.GetCustomerByOrderId(2);
var discounts1 = rep.GetDiscountsForOrderId(2);

var order2 = rep.GetOrderWithItemsById(2);
var pricetotal2 = rep.GetTotalPriceInOrder(2);


var a1 = rep.GetOrderById(5);
var custom11 = rep.GetCustomerWithOrderById(5);
var price1 = rep.GetPriceByOrderId(5);

//var fff1 = rep.GetCustomerByOrderId(5);
var order21 = rep.GetOrderWithItemsById(5);
var discounts = rep.GetDiscountsForOrderId(5);
var pricetotal5 = rep.GetTotalPriceInOrder(5);
var totalTotalTotal = rep.GetTotalWithDelivery(5);


Console.ReadLine();