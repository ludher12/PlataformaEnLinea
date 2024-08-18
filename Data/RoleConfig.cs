using Microsoft.AspNetCore.Identity;
using PlataformaEnLinea.Models;

namespace PlataformaEnLinea.Data
{
    public class RoleConfig
    {
        public static async Task Initialize(IServiceProvider serviceProvider, ApplicationDbContext context)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "Student", "Instructor" };

            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Verificar si el usuario admin existe
            var adminEmail = "admin@example.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                // Crear el usuario administrador
                var newAdminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var userPassword = "Admin/123";
                var createAdminUser = await userManager.CreateAsync(newAdminUser, userPassword);

                if (!createAdminUser.Succeeded)
                {
                    // Loguea los errores
                    foreach (var error in createAdminUser.Errors)
                    {
                        Console.WriteLine($"Error al crear el usuario admin: {error.Description}");
                    }
                }
                else
                {
                    // Asignar el rol de Admin al usuario
                    await userManager.AddToRoleAsync(newAdminUser, "Admin");

                    // Crear el modelo Administrator y guardarlo en la base de datos
                    var admin = new Administrator
                    {
                        Name = "Admin",
                        LastName = "Admin",
                        UserId = newAdminUser.Id
                    };

                    context.Administrators.Add(admin); // Suponiendo que tengas un DbSet<Administrator>
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
