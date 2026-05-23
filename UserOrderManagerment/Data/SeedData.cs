using UserOrderManagerment.Entities;

namespace UserOrderManagerment.Data;

public static class SeedData
{
    public static async Task SeedAsync(AppDbContext db)
    {
        if (db.Users.Any())
        {
            return;
        }

        var adminRole = new Role()
        {
            Name = "Admin",
            CreationTime = DateTime.UtcNow
        };

        var customerRole = new Role
        {
            Name = "Customer",
            CreationTime = DateTime.UtcNow
        };

        var user1 = new User
        {
            FullName = "Nguyen Van A",
            Email = "a@example.com",
            Age = 25,
            CreationTime = DateTime.UtcNow
        };

        var user2 = new User
        {
            FullName = "Tran Thi B",
            Email = "b@example.com",
            Age = 30,
            CreationTime = DateTime.UtcNow
        };

        db.Roles.AddRange(adminRole, customerRole);
        db.Users.AddRange(user1, user2);

        await db.SaveChangesAsync();

        db.UserRoles.AddRange(
            new UserRole { UserId = user1.Id, RoleId = adminRole.Id },
            new UserRole { UserId = user2.Id, RoleId = customerRole.Id }
        );

        db.Orders.AddRange(
            new Order
            {
                UserId = user1.Id,
                TotalAmount = 1000000,
                CreatedAt = DateTime.UtcNow.AddDays(-2),
                Status = "Completed",
                CreationTime = DateTime.UtcNow
            },
            new Order
            {
                UserId = user2.Id,
                TotalAmount = 2500000,
                CreatedAt = DateTime.UtcNow.AddDays(-1),
                Status = "Completed",
                CreationTime = DateTime.UtcNow
            }
        );

        await db.SaveChangesAsync();
    }
}