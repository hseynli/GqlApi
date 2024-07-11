using GqlApi.Models.Animal;
using GqlApi.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<Dog>()
                .AddType<Cat>()
                .AddType<Parrot>()
                .ModifyOptions(p => 
                { 
                    p.EnableOneOf = true;
                    p.StripLeadingIFromInterface = true; 
                });

var app = builder.Build();

app.MapGraphQL();

await app.RunWithGraphQLCommandsAsync(args);

app.Run();
