using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

namespace AuctionService;

public class DbInitializer
{
    public static void InitDb(WebApplication app){
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>())
    }

    private static void SeedData(AuctionDbContext conext)
    {
        conext.Database.Migrate();
    }
}
