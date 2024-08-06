using GraphQLServer.Models;

namespace GraphQLServer.Extensions
{
    public class ExecuteDataSeed
    {
        //Seed Data
        public static async Task SeedData(IHost app)
        {
            var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

            using (var scope = scopedFactory.CreateScope())
            {
                var service = scope.ServiceProvider.GetService<ModelDataSeeder>();
                await service.SeedAsync();
            }
        }
    }
}
