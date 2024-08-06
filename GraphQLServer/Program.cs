using GraphQLServer;
using GraphQLServer.Extensions;
using GraphQLServer.GraphQLTypes;
using GraphQLServer.GraphQLTypes.DataLoader;
using GraphQLServer.GraphQLTypes.Types;
using GraphQLServer.Models;
using Microsoft.EntityFrameworkCore;

//services
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(GraphQLAppSettings.ConnectionString));
builder.Services.AddTransient<ApplicationDbContext>();
builder.Services.AddTransient<ModelDataSeeder>();

builder.Services.AddCors(setup =>
{
    setup.AddPolicy("dev", options =>
    {
        options.WithOrigins("http://localhost:5000")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

//GraphQL
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddType<SpeakerType>()
                .AddDataLoader<SpeakerByIdDataLoader>()
                .AddDataLoader<SessionByIdDataLoader>(); 

//use 
var app = builder.Build();

await ExecuteDataSeed.SeedData(app);

app.UseCors("dev");

app.UseRouting();

//GraphQL
app.UseEndpoints(endpoints => {
    _ = endpoints.MapGraphQL("/GraphQL");
});

app.Run();
