using AspNetEcommerce.Data.Entity;

namespace AspNetEcommerce.Data
{
    public class SeedHelper
    {
        public static void Seed()
        {
            using (var context = new AppDbContext())
            {
                if (!context.Users.Any())
                {
                    var admin = new User
                    {
                        Username = "cem",
                        EmailAddress = "cem@site.com",
                        Password = "123",
                        Roles = "Admin",
                        IsActive = true,
                        CreatedAt = DateTime.Now,
                        CreatedBy = 1
                    };
                    context.Users.Add(admin);

                    var user1 = new User()
                    {
                        Username = "sanem",
                        Password = "123",
                        EmailAddress = "sanem@site.com",
                        CreatedAt = DateTime.Now,
                        CreatedBy = 1
                    };
                    context.Users.Add(user1);

                    var user2 = new User()
                    {
                        Username = "jerfi_ali",
                        Password = "123",
                        EmailAddress = "jerfi_ali@site.com",
                        CreatedAt = DateTime.Now,
                        CreatedBy = 1
                    };
                    context.Users.Add(user2);

                    context.SaveChanges();
                }

                if (!context.Categories.Any())
                {
                    var categories = new List<Category>() {
                        new Category { Name = "Elektronik" },
                        new Category { Name = "Kitap" },
                        new Category { Name = "Oyuncak" },
                        new Category { Name = "Giyim" },
                        new Category { Name = "Kozmetik" },
                    };

                    context.Categories.AddRange(categories);
                    context.SaveChanges();

                    var elektronikAltKategoriler = new List<Category> {
                        new Category { ParentId = categories[0].Id, Name = "Bilgisayar" },
                        new Category { ParentId = categories[0].Id, Name = "Tablet" },
                        new Category { ParentId = categories[0].Id, Name = "Foto & Kamera" },
                    };
                    context.Categories.AddRange(elektronikAltKategoriler);

                    var kitapAltKategoriler = new List<Category> {
                        new Category { ParentId = categories[1].Id, Name = "Roman" },
                        new Category { ParentId = categories[1].Id, Name = "Şiir" },
                        new Category { ParentId = categories[1].Id, Name = "Bilimkurgu" },
                        new Category { ParentId = categories[1].Id, Name = "Mühendislik" },
                    };
                    context.Categories.AddRange(kitapAltKategoriler);

                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    var products = new List<Product>() {
                        new Product { Name = "Ürün 1", Description = "Açıklama 1", Price = 29, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 1, ImageUrl = "https://picsum.photos/400/400?1", IsFeatured = true },
                        new Product { Name = "Ürün 2", Description = "Açıklama 2", Price = 124, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 1, ImageUrl = "https://picsum.photos/400/400?2", IsFeatured = true },
                        new Product { Name = "Ürün 3", Description = "Açıklama 3", Price = 87, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 2, ImageUrl = "https://picsum.photos/400/400?3", IsFeatured = true },
                        new Product { Name = "Ürün 4", Description = "Açıklama 4", Price = 77, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 3, ImageUrl = "https://picsum.photos/400/400?4" },
                        new Product { Name = "Ürün 5", Description = "Açıklama 5", Price = 12, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 3, ImageUrl = "https://picsum.photos/400/400?5" },
                        new Product { Name = "Ürün 6 Foto Kamera", Description = "Açıklama Foto Kamera 5", Price = 12, CreatedAt = DateTime.Now, CreatedBy = 1, CategoryId = 8, ImageUrl = "https://picsum.photos/400/400?5" },
                    };

                    context.Products.AddRange(products);
                    context.SaveChanges();
                }
            }
        }
    }
}
