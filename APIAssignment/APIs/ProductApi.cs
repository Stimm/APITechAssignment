﻿namespace APIAssignment.APIs;

public static class ProductApi
{
    public static void ConfigureProductApi(this WebApplication app)
    {

        app.MapGet("/Products", GetProducts);
        app.MapGet("/Products/{id}", GetProduct);
        app.MapPost("/Products", InsertProduct);
        app.MapDelete("/Products", DeleteProduct);
    }

    private static async Task<IResult> GetProducts(IProductData data)
    {
        try
        {
            return Results.Ok(await data.GetProducts());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProduct(int id, IProductData data)
    {
        try
        {
            var results = await data.GetProduct(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertProduct(ProductModel model, IProductData data)
    {
        try
        {
            await data.InsertProduct(model);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteProduct(int id, IProductData data)
    {
        try
        {
            await data.DeleteProduct(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
