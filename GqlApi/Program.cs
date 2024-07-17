using Data;
using GqlApi.Models.Animal;
using GqlApi.Types;
using GqlApi.Types.Sorting;
using Microsoft.EntityFrameworkCore;
using Migrations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CatalogContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMigration<CatalogContext, CatalogContextSeed>();

builder.Services.AddGraphQLServer()
                .AddGqlApiTypes()
                .AddProjections()
                .AddFiltering()
                .AddSorting()
                .AddType<Dog>()
                .AddType<Cat>()
                .AddType<Parrot>()
                //.AddType<ProductSortInputType>()
                .ModifyOptions(p => 
                { 
                    p.EnableOneOf = true;
                    p.StripLeadingIFromInterface = true;
                });

var app = builder.Build();

app.MapGraphQL();

await app.RunWithGraphQLCommandsAsync(args);

app.Run();
