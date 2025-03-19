
using Loader;
using Microsoft.EntityFrameworkCore;

var _context = new ECommerceContext();


//var product1 = new Product { Name = "Laptop", Price = 1500m };
//var product2 = new Product { Name = "Smartphone", Price = 800.00m };
//var product3 = new Product { Name = "Headphones", Price = 200.00m };

//_context.Products.AddRange(product1, product2, product3);


//var customer1 = new Customer { FirstName = "Samir", LastName = "Heyderov" };
//var customer2 = new Customer { FirstName = "Elnur", LastName = "Axundov" };
//var customer3 = new Customer { FirstName = "Resad", LastName = "Ceferov" };

//_context.Customers.AddRange(customer1, customer2, customer3);

//var order1 = new Order { Customer = customer1, Product = product1 };
//var order2 = new Order { Customer = customer2, Product = product2 };
//var order3 = new Order { Customer = customer3, Product = product3 };

//_context.Orders.AddRange(order1, order2, order3);




//await _context.SaveChangesAsync();


//1-Eager Loading

//var customersWithOrders = await _context.Customers
//                .Include(c => c.Orders) 
//                .ThenInclude(o => o.Product) 
//                .ToListAsync();



//foreach (var customer in customersWithOrders)
//{
//    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
//    foreach (var order in customer.Orders)
//    {
//        Console.WriteLine($" - {order.Product.Name}: {order.Product.Price} AZN");
//    }
//}


//2-Explicit

//var customer = await _context.Customers
//               .FirstOrDefaultAsync(c => c.FirstName == "Samir");


//if (customer != null)
//{
//    await _context.Entry(customer)
//        .Collection(c => c.Orders) 
//        .LoadAsync();

 
//    foreach (var order in customer.Orders)
//    {
//        await _context.Entry(order)
//            .Reference(o => o.Product) 
//            .LoadAsync();
//    }

    
//    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
//    foreach (var order in customer.Orders)
//    {
//        Console.WriteLine($" - {order.Product.Name}: {order.Product.Price} AZN");
//    }
//}
        