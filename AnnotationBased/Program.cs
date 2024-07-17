using AnnotationBased.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddTypeExtension(typeof(BookExtension));

var app = builder.Build();

app.MapGraphQL();

await app.RunWithGraphQLCommandsAsync(args);

app.Run();
