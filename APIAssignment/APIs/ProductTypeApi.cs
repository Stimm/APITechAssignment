namespace APIAssignment.APIs;

public static class ProductTypeApi
{
    public static void ConfigureProductTypeApi(this WebApplication app)
    {
        app.MapGet("/ProductTypes", GetProductTypes);
        app.MapGet("/ProductType/{id}", GetProductType);
        app.MapPut("/ProductType", UpdateProduct);
    }

    private static async Task<IResult> GetProductTypes(IProductTypeData data)
    {
        try
        {
            return Results.Ok(await data.GetProductTypes());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProductType(int id, IProductTypeData data)
    {
        try
        {
            var results = await data.GetProductType(id);
            if (results == null) return Results.NotFound();   
            return Results.Ok(results); 
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateProduct(ProductTypeModel model, IProductTypeData data)
    {
        try
        {
            await data.UpdateProductType(model);
            return Results.Ok(data);    
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
