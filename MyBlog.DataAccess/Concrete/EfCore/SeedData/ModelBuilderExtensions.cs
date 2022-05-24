using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete.EfCore.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region SeedDatasOfRolesTable
            builder.Entity<Role>().HasData(
                new Role
                    {
                        Id = 1,
                        Name = "Admin",
                        Description = "Admin Rolü Tüm Haklara Sahiptir.",
                        IsActive = true,
                        IsDeleted = false,
                        CreatedByName = "InitialCreate",
                        CreatedDate = DateTime.Now,
                        ModifiedByName = "InitialCreate",
                        ModifiedDate = DateTime.Now,
                        Note = "Admin Rolüdür."
                    }
            );
            #endregion

            #region SeedDatasOfUsersTable
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    RoleId = 1,
                    FirstName = "Adem",
                    LastName = "Kınataş",
                    UserName = "ademkinatas",
                    Email = "ademkinatas@gmail.com",
                    PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500"),
                    Description = "Software Developer",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Admin Kullanıcı.",
                    Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU"
                }
            );
            #endregion

            #region SeedDatasOfCategoriesTable
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Yazılım Dünyası",
                    Description = "Yazılım ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Yazılım Blog Kategorisi."
                },
                new Category
                {
                    Id = 2,
                    Name = "Satranç",
                    Description = "Satranç ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Satranç Blog Kategorisi."
                },
                new Category
                {
                    Id = 3,
                    Name = "Edebiyat",
                    Description = "Edebiyat ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Edebiyat Blog Kategorisi."
                }
            );
            #endregion

            #region SeedDatasOfArticlesTable
            builder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 ve .Net 5 yenilikleri",
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C# 9.0 ve .Net 5 yenilikleri",
                    SeoTags = "C#, C# 9, .Net 5, .Net Core, .Net Framework",
                    SeoAuthor = "Adem Kınataş",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .Net 5 yenilikleri.",
                    UserId = 1,
                    ViewsCount = 121,
                    CommentCount = 1
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Adaylar turnuvasına çok az kaldı",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "Adaylar turnuvasına çok az kaldı",
                    SeoTags = "Satranç, Chess, Adaylar Turnuvası",
                    SeoAuthor = "Adem Kınataş",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Adaylar turnuvasına çok az kaldı.",
                    UserId = 1,
                    ViewsCount = 255,
                    CommentCount = 1
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Yerli Edebiyatımızın Dostoyevski'si",
                    Content = "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "Yerli Edebiyatımızın Dostoyevski'si",
                    SeoTags = "Oğuz Atay, Tutunamayanlar, Tehlikeli Oyunlar, Albayım, Turgut Özben, Hikmet Benol",
                    SeoAuthor = "Adem Kınataş",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Yerli Edebiyatımızın Dostoyevski'si.",
                    UserId = 1,
                    ViewsCount = 27,
                    CommentCount = 1
                }
            );
            #endregion

            #region SeedDatasOfCommentsTable
            builder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    ArticleId = 1,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Yazılım Makale Yorumu.",
                },
                new Comment
                {
                    Id = 2,
                    ArticleId = 2,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Satranç Makale Yorumu.",
                },
                new Comment
                {
                    Id = 3,
                    ArticleId = 3,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Edebiyat Makale Yorumu.",
                }
            );
            #endregion
        }
    }
}
