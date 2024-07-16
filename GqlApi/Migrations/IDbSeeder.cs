using Microsoft.EntityFrameworkCore;

namespace Migrations;

public interface IDbSeeder<in TContext> where TContext : DbContext
{
    Task SeedAsync(TContext context);
}