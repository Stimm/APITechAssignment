using APIAssignment.Models;

namespace APIAssignment.APIs;

public static class OrderApi
{
    public static void ConfigureOrderApi(this WebApplication app)
    {
        app.MapGet("/Orders", GetOrders);
        app.MapGet("/Orders/{id}", GetOrder);
        app.MapPost("/Orders", InsertOrder);
        app.MapPut("/Orders", UpdateOrder);
        app.MapDelete("/Orders", DeleteOrder);
        app.MapPut("/Orders/AddProduct", AddProductsToOrder);
    }

    private static async Task<IResult> GetOrders(IOrderData orderdata, IProductData productData)
    {
        try
        {
            var orders = await orderdata.GetOrders();
            List<OrderRequestModel> OrderRequests = new List<OrderRequestModel>();

            foreach (var order in orders)
            {
                OrderRequestModel orderRequestModel = new OrderRequestModel();
                var Products = await productData.GetProductByOrderId(order.OrderId);
                orderRequestModel.OrderId = order.OrderId;
                orderRequestModel.Address = order.Address;
                List<string> productIds = new List<string>();
                foreach (var product in Products)
                {
                    productIds.Add(product.ProductId);
                }
                orderRequestModel.ProductIds = productIds;
                OrderRequests.Add(orderRequestModel);
            }

            return Results.Ok(OrderRequests);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetOrder(int id, IOrderData Orderdata, IProductData productData)
    {
        try
        {
            OrderRequestModel orderRequestModel = new OrderRequestModel();
            var results = await Orderdata.GetOrder(id);
            if (results == null) return Results.NotFound();
            orderRequestModel.OrderId = results.OrderId;
            orderRequestModel.Address = results.Address;
            var Products = await productData.GetProductByOrderId(id);
            List<string> productIds = new List<string>();
            foreach (var product in Products)
            {
                productIds.Add(product.ProductId);
            }

            orderRequestModel.ProductIds = productIds;
            return Results.Ok(orderRequestModel);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertOrder(OrderModel model, IOrderData data)
    {
        try
        {
            await data.InsertOrder(model);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateOrder(OrderModel model, IOrderData data)
    {
        try
        {
            await data.UpdateOrder(model);
            return Results.Ok(data);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> AddProductsToOrder(OrderRequestModel model, IProductData data)
    {
        try
        {
            if (model.ProductIds == null)
            {
                return Results.Problem("nope");
            }
            
            foreach (string id in model.ProductIds)
            {
                var product = await data.GetProduct(id);
                if(product.OrderId != 0)
                {
                    return Results.Problem($" {product.ProductId} is not available, please remove product and try again");
                }
            }

            foreach (string id in model.ProductIds)
            {
                var product = await data.GetProduct(id);
                product.OrderId = model.OrderId;
                await data.UpdateProduct(product);
            }

            return Results.Ok(data);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteOrder(int id, IOrderData orderData, IProductData productData)
    {
        try
        {
            var product = await productData.GetProductByOrderId(id);
            foreach (ProductModel prod in product)
            {
                prod.OrderId = 0;
                await productData.UpdateProduct(prod);
            }

            await orderData.DeleteOrder(id);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
