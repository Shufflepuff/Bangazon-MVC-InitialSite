# Bangazon-MVC-InitialSite
# Building the First Version of the Bangazon Site

## Table of Contents

1. [Prerequisites](#prerequisites)
1. [What You Will Be Learning](#what-you-will-be-learning)
1. [Requirements](#requirements)
1. [Resources](#resources)

## Prerequisites

* [ERD Development](http://www.draw.io)
* [ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)
* [View templates/layouts](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-view)
* [Models](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-model)
* [Controllers](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-controller)
* [Migrations](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application)

## What You Will Be Learning

### Data Relationships

Launching off the work you did in the first version of the Bangazon Platform API, you will be adding more relationships to your data model.

### Producing an MVC Server-Generated Site

You will be building a server generated HTML site instead of building a single page application like the ones you built in the front end part of the course.

### Entity Framework (Optional)

You can now choose to use ADO.NET, Dapper, or Entity Framework and Code First Migrations.

## Requirements

You will be building an ASP.NET MVC application that will be the first, stable version of the Bangazon Platform product site.

### Models

1. Products will be created by customers, so make sure that you have a column on the `Product` model to store which customer created it.
1. Add a new model named `ProductType`. Add a foreign key to `ProductType` in the `Product` model. It must be non-nullable, which means that you will likely need to provide a default value for your migration to work. The only fields needed are the primary key, and `Label`.
1. Add a model named `PaymentType`.
1. A `Customer` can have many payment types.
1. The `Order` model must have a foreign key field to the `PaymentType` model, but it can be nullable. However, before an order can be completed, there must be a value for the `PaymentType` field.

### Generated Application

Make sure you produce a [layout](https://docs.asp.net/en/latest/mvc/views/layout.html) for the application so that the structure of each page is consistent.

1. In navigation bar, have a select element that allows you to pick which customer is active.
1. List of all product types.
1. Provide a view to show all products that are of a particular product type.
1. List all products, with the name text as a hyperlink to the detail view.
1. Provide a product detail view.
1. List payment types for current customer.
1. On the product detail view, have an `Add to Order` button that, when clicked, either creates a new order for a customer that doesn't have an active one, or adds to an existing open order.
1. In the navigation bar, have an affordance that shows the current customer how many items are in their order.
1. If the user clicks on their order in the navigation bar, take them to the order detail view, which lists products, their prices, and current total for order.
1. On the order detail view, have a button labeled `Complete Order`.
1. When a customer starts to complete an order, show them a list of payment types that are assigned to them. When they select one to add to the order, then the order is complete.


## Resources

### Getting Started

[Getting started with ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)
[Getting Started with Entity Framework 6 Code First using MVC 5](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/)

### ASP.NET Views
##### Ignore anything about .net core in these, for some reason there aren't good ones for regular old asp.net...

Begin reading the [Views Overview](https://docs.asp.net/en/latest/mvc/views/overview.html) documentation, 
Make sure you read about the [Partial Views](https://docs.asp.net/en/latest/mvc/views/partial.html), as it will help you with a crucial feature of the application.  

### Razor Templates

ASP.NET MVC views are generated by the [Razor view engine](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor).

### Form Helpers

Since this site, at a minimum, will have a couple forms (one for product detail and one for order detail), read about how .NET makes it easier to build [dynamic forms](https://docs.asp.net/en/latest/mvc/views/working-with-forms.html).
