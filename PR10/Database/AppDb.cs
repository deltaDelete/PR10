using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PR10.Database;

public class AppDb : DbContext {
    public static readonly string
        ConnectionString = "server=10.10.1.24;uid=user_01;password=user01pro;database=pro1_2;";

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        optionsBuilder.LogTo(Console.WriteLine);
    }
}

public class User {
    [Key]
    public int UserId { get; set; }
    public int UserRoleId { get; set; }
    public UserRole UserRole { get; set; } = null!;
    public string FullName { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class UserRole {
    [Key] public int UserRoleId { get; set; }
    public string Name { get; set; } = string.Empty;
}