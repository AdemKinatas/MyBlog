using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Concrete.EfCore.Configurations
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(100);

            builder.Property(c => c.Description).HasMaxLength(500);

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(100);

            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(100);

            builder.Property(c => c.CreatedDate).IsRequired();

            builder.Property(c => c.ModifiedDate).IsRequired();

            builder.Property(c => c.IsActive).IsRequired();

            builder.Property(c => c.IsDeleted).IsRequired();

            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Categories");
        }
    }
}
