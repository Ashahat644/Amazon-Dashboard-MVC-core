﻿// <auto-generated />
using System;
using Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataContext.Migrations
{
    [DbContext(typeof(AmazonContext))]
    [Migration("20220401140854_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Admin.Models.Admins", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Admin.Models.AllCategory", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToView("AllCategories");
                });

            modelBuilder.Entity("Admin.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Admin.Models.CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("Cart_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart_Products");
                });

            modelBuilder.Entity("Admin.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Admin.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("Admin_id");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Admin.Models.Creditcard", b =>
                {
                    b.Property<int>("CreditcardId")
                        .HasColumnType("int")
                        .HasColumnName("Creditcard_id");

                    b.Property<DateTime>("CardExpiredate")
                        .HasColumnType("date")
                        .HasColumnName("Card_expiredate");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int")
                        .HasColumnName("Card_Number");

                    b.Property<int>("CardPin")
                        .HasColumnType("int")
                        .HasColumnName("Card_pin");

                    b.HasKey("CreditcardId");

                    b.ToTable("Creditcards");
                });

            modelBuilder.Entity("Admin.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("Cart_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Phone_number");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Admin.Models.CustomerAddress", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("Postal_Code");

                    b.Property<string>("Region")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("State")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("CustomerId", "Id");

                    b.ToTable("Customer_address");
                });

            modelBuilder.Entity("Admin.Models.CustomerContact", b =>
                {
                    b.Property<int>("ContactId")
                        .HasColumnType("int")
                        .HasColumnName("Contact_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.HasKey("ContactId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Customer_contacts");
                });

            modelBuilder.Entity("Admin.Models.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Customer_Products");
                });

            modelBuilder.Entity("Admin.Models.CustomerProductsRate", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<string>("Feedback")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<int?>("RateNumber")
                        .HasColumnType("int")
                        .HasColumnName("Rate_number");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Customer_Products_Rates");
                });

            modelBuilder.Entity("Admin.Models.GetSellerContactInfo", b =>
                {
                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("Admin_id");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToView("getSellerContactInfo");
                });

            modelBuilder.Entity("Admin.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Privacy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("List");
                });

            modelBuilder.Entity("Admin.Models.ListProduct", b =>
                {
                    b.Property<int>("ListId")
                        .HasColumnType("int")
                        .HasColumnName("List_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.HasKey("ListId", "ProductId");

                    b.ToTable("List_products");
                });

            modelBuilder.Entity("Admin.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("OptionName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("option_name");

                    b.HasKey("Id");

                    b.ToTable("options");
                });

            modelBuilder.Entity("Admin.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CreditcardId")
                        .HasColumnType("int")
                        .HasColumnName("Creditcard_id");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<DateTime?>("EstimatedDeliveryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Estimated_Delivery_Date");

                    b.Property<string>("OrderAddress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Order_address");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Order_date");

                    b.HasKey("Id");

                    b.HasIndex("CreditcardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Admin.Models.OrderDatum", b =>
                {
                    b.Property<int?>("CreditcardId")
                        .HasColumnType("int")
                        .HasColumnName("Creditcard_id");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_id");

                    b.Property<DateTime?>("EstimatedDeliveryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Estimated_Delivery_Date");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("OrderAddress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Order_address");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Order_date");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("product_name");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.ToView("order_data");
                });

            modelBuilder.Entity("Admin.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("Order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.ToTable("Order_products");
                });

            modelBuilder.Entity("Admin.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int")
                        .HasColumnName("Seller_id");

                    b.Property<string>("Shipping")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Subcategory_id");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Admin.Models.ProductOption", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("OptionId")
                        .HasColumnType("int")
                        .HasColumnName("option_id");

                    b.HasKey("ProductId", "OptionId");

                    b.HasIndex("OptionId");

                    b.ToTable("product_options");
                });

            modelBuilder.Entity("Admin.Models.ProductQA", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_id");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("Question_id");

                    b.Property<string>("Answer")
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ProductId", "QuestionId");

                    b.ToTable("Product_Q&A");
                });

            modelBuilder.Entity("Admin.Models.SelectTopProduct", b =>
                {
                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("product_name");

                    b.ToView("select_top_products");
                });

            modelBuilder.Entity("Admin.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("Postal_Code");

                    b.HasKey("Id");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("Admin.Models.SellerContact", b =>
                {
                    b.Property<int>("ContactId")
                        .HasColumnType("int")
                        .HasColumnName("Contact_id");

                    b.Property<int>("SellerId")
                        .HasColumnType("int")
                        .HasColumnName("Seller_id");

                    b.HasKey("ContactId", "SellerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Seller_contacts");
                });

            modelBuilder.Entity("Admin.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Category_id");

                    b.Property<string>("Discription")
                        .HasMaxLength(2000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategory");
                });

            modelBuilder.Entity("Admin.Models.ViewContact", b =>
                {
                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("Admin_id");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(220)
                        .IsUnicode(false)
                        .HasColumnType("varchar(220)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToView("view_contacts");
                });

            modelBuilder.Entity("Admin.Models.ViewProductOption", b =>
                {
                    b.Property<string>("OptionName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("option_name");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToView("ViewProduct_Option");
                });

            modelBuilder.Entity("Admin.Models.CartProduct", b =>
                {
                    b.HasOne("Admin.Models.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .HasConstraintName("FK_Cart_Products_Cart")
                        .IsRequired();

                    b.HasOne("Admin.Models.Product", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Cart_Products_Product")
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Admin.Models.Contact", b =>
                {
                    b.HasOne("Admin.Models.Admins", "Admin")
                        .WithMany("Contacts")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("FK_Contact_Admin");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("Admin.Models.Customer", b =>
                {
                    b.HasOne("Admin.Models.Cart", "Cart")
                        .WithMany("Customers")
                        .HasForeignKey("CartId")
                        .HasConstraintName("FK_Customer_Cart");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Admin.Models.CustomerAddress", b =>
                {
                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_address_Customer")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Admin.Models.CustomerContact", b =>
                {
                    b.HasOne("Admin.Models.Contact", "Contact")
                        .WithMany("CustomerContacts")
                        .HasForeignKey("ContactId")
                        .HasConstraintName("FK_Customer_contacts_Contact")
                        .IsRequired();

                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("CustomerContacts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_contacts_Customer")
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Admin.Models.CustomerProduct", b =>
                {
                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_Products_Customer")
                        .IsRequired();

                    b.HasOne("Admin.Models.Product", "Product")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Customer_Products_Product")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Admin.Models.CustomerProductsRate", b =>
                {
                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("CustomerProductsRates")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_Products_Rates_Customer")
                        .IsRequired();

                    b.HasOne("Admin.Models.Product", "Product")
                        .WithMany("CustomerProductsRates")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Customer_Products_Rates_Product")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Admin.Models.List", b =>
                {
                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("Lists")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_List_Customer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Admin.Models.Order", b =>
                {
                    b.HasOne("Admin.Models.Creditcard", "Creditcard")
                        .WithMany("Orders")
                        .HasForeignKey("CreditcardId")
                        .HasConstraintName("FK_Orders_Creditcards");

                    b.HasOne("Admin.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customer");

                    b.Navigation("Creditcard");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Admin.Models.Product", b =>
                {
                    b.HasOne("Admin.Models.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .HasConstraintName("FK_Product_Seller")
                        .IsRequired();

                    b.HasOne("Admin.Models.Subcategory", "Subcategory")
                        .WithMany("Products")
                        .HasForeignKey("SubcategoryId")
                        .HasConstraintName("FK_Product_Subcategory")
                        .IsRequired();

                    b.Navigation("Seller");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("Admin.Models.ProductOption", b =>
                {
                    b.HasOne("Admin.Models.Option", "Option")
                        .WithMany("ProductOptions")
                        .HasForeignKey("OptionId")
                        .HasConstraintName("FK_product_options_options")
                        .IsRequired();

                    b.HasOne("Admin.Models.Product", "Product")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_product_options_Product")
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Admin.Models.ProductQA", b =>
                {
                    b.HasOne("Admin.Models.Product", "Product")
                        .WithMany("ProductQAs")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_Q&A_Product")
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Admin.Models.SellerContact", b =>
                {
                    b.HasOne("Admin.Models.Contact", "Contact")
                        .WithMany("SellerContacts")
                        .HasForeignKey("ContactId")
                        .HasConstraintName("FK_Seller_contacts_Contact")
                        .IsRequired();

                    b.HasOne("Admin.Models.Seller", "Seller")
                        .WithMany("SellerContacts")
                        .HasForeignKey("SellerId")
                        .HasConstraintName("FK_Seller_contacts_Seller")
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Admin.Models.Subcategory", b =>
                {
                    b.HasOne("Admin.Models.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Subcategory_Category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Admin.Models.Admins", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Admin.Models.Cart", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Admin.Models.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("Admin.Models.Contact", b =>
                {
                    b.Navigation("CustomerContacts");

                    b.Navigation("SellerContacts");
                });

            modelBuilder.Entity("Admin.Models.Creditcard", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Admin.Models.Customer", b =>
                {
                    b.Navigation("CustomerAddresses");

                    b.Navigation("CustomerContacts");

                    b.Navigation("CustomerProducts");

                    b.Navigation("CustomerProductsRates");

                    b.Navigation("Lists");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Admin.Models.Option", b =>
                {
                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("Admin.Models.Product", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("CustomerProducts");

                    b.Navigation("CustomerProductsRates");

                    b.Navigation("ProductOptions");

                    b.Navigation("ProductQAs");
                });

            modelBuilder.Entity("Admin.Models.Seller", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SellerContacts");
                });

            modelBuilder.Entity("Admin.Models.Subcategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
