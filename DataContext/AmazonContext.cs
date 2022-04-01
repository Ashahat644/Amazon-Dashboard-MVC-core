using System;
using Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Admin.Data
{
    public partial class AmazonContext : DbContext
    {
        public AmazonContext()
        {
        }

        public AmazonContext(DbContextOptions<AmazonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AllCategory> AllCategories { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartProduct> CartProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Creditcard> Creditcards { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProducts { get; set; }
        public virtual DbSet<CustomerProductsRate> CustomerProductsRates { get; set; }
        public virtual DbSet<GetSellerContactInfo> GetSellerContactInfos { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<ListProduct> ListProducts { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderData> OrderData { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductOption> ProductOptions { get; set; }
        public virtual DbSet<ProductQA> ProductQAs { get; set; }
        public virtual DbSet<SelectTopProduct> SelectTopProducts { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SellerContact> SellerContacts { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<ViewContact> ViewContacts { get; set; }
        public virtual DbSet<ViewProductOption> ViewProductOptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-O7GDQ3B\OMAR;Initial Catalog=Amazon2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllCategories");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CartProduct>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.ProductId });

                entity.ToTable("Cart_Products");

                entity.Property(e => e.CartId).HasColumnName("Cart_id");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Products_Cart");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Products_Product");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdminId).HasColumnName("Admin_id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_Contact_Admin");
            });

            modelBuilder.Entity<Creditcard>(entity =>
            {
                entity.Property(e => e.CreditcardId)
                    .ValueGeneratedNever()
                    .HasColumnName("Creditcard_id");

                entity.Property(e => e.CardExpiredate)
                    .HasColumnType("date")
                    .HasColumnName("Card_expiredate");

                entity.Property(e => e.CardNumber).HasColumnName("Card_Number");

                entity.Property(e => e.CardPin).HasColumnName("Card_pin");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CartId).HasColumnName("Cart_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK_Customer_Cart");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.Id });

                entity.ToTable("Customer_address");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode).HasColumnName("Postal_Code");

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_address_Customer");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.CustomerId });

                entity.ToTable("Customer_contacts");

                entity.Property(e => e.ContactId).HasColumnName("Contact_id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_contacts_Contact");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_contacts_Customer");
            });

            modelBuilder.Entity<CustomerProduct>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId });

                entity.ToTable("Customer_Products");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Products_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Products_Product");
            });

            modelBuilder.Entity<CustomerProductsRate>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId });

                entity.ToTable("Customer_Products_Rates");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RateNumber).HasColumnName("Rate_number");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProductsRates)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Products_Rates_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProductsRates)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Products_Rates_Product");
            });

            modelBuilder.Entity<GetSellerContactInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("getSellerContactInfo");

                entity.Property(e => e.AdminId).HasColumnName("Admin_id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Privacy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Lists)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_List_Customer");
            });

            modelBuilder.Entity<ListProduct>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.ProductId });

                entity.ToTable("List_products");

                entity.Property(e => e.ListId).HasColumnName("List_id");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("options");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.OptionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreditcardId).HasColumnName("Creditcard_id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.EstimatedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Estimated_Delivery_Date");

                entity.Property(e => e.OrderAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Order_address");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_date");

                entity.HasOne(d => d.Creditcard)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CreditcardId)
                    .HasConstraintName("FK_Orders_Creditcards");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Orders_Customer");
            });

            modelBuilder.Entity<OrderData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("order_data");

                entity.Property(e => e.CreditcardId).HasColumnName("Creditcard_id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_id");

                entity.Property(e => e.EstimatedDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Estimated_Delivery_Date");

                entity.Property(e => e.OrderAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Order_address");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_date");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("product_name");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.ToTable("Order_products");

                entity.Property(e => e.OrderId).HasColumnName("Order_id");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("Seller_id");

                entity.Property(e => e.Shipping)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubcategoryId).HasColumnName("Subcategory_id");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Seller");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Subcategory");
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.OptionId });

                entity.ToTable("product_options");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.ProductOptions)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_options_options");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOptions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_options_Product");
            });

            modelBuilder.Entity<ProductQA>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.QuestionId });

                entity.ToTable("Product_Q&A");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.Property(e => e.QuestionId).HasColumnName("Question_id");

                entity.Property(e => e.Answer)
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductQAs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Q&A_Product");
            });

            modelBuilder.Entity<SelectTopProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_top_products");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("product_name");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("Seller");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode).HasColumnName("Postal_Code");
            });

            modelBuilder.Entity<SellerContact>(entity =>
            {
                entity.HasKey(e => new { e.ContactId, e.SellerId });

                entity.ToTable("Seller_contacts");

                entity.Property(e => e.ContactId).HasColumnName("Contact_id");

                entity.Property(e => e.SellerId).HasColumnName("Seller_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.SellerContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_contacts_Contact");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.SellerContacts)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_contacts_Seller");
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.ToTable("Subcategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.Discription)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subcategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Subcategory_Category");
            });

            modelBuilder.Entity<ViewContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_contacts");

                entity.Property(e => e.AdminId).HasColumnName("Admin_id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewProductOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewProduct_Option");

                entity.Property(e => e.OptionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("option_name");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
