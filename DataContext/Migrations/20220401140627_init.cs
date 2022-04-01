using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataContext.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true),
                    Picture = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creditcards",
                columns: table => new
                {
                    Creditcard_id = table.Column<int>(type: "int", nullable: false),
                    Card_expiredate = table.Column<DateTime>(type: "date", nullable: false),
                    Card_Number = table.Column<int>(type: "int", nullable: false),
                    Card_pin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creditcards", x => x.Creditcard_id);
                });

            migrationBuilder.CreateTable(
                name: "List_products",
                columns: table => new
                {
                    List_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_products", x => new { x.List_id, x.Product_id });
                });

            migrationBuilder.CreateTable(
                name: "options",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    option_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_options", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Order_products",
                columns: table => new
                {
                    Order_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_products", x => new { x.Order_id, x.Product_id });
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Postal_Code = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Message = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: false),
                    Admin_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Admin",
                        column: x => x.Admin_id,
                        principalTable: "Admin",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Cart_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Cart",
                        column: x => x.Cart_id,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subcategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Discription = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    Picture = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategory_Category",
                        column: x => x.Category_id,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seller_contacts",
                columns: table => new
                {
                    Contact_id = table.Column<int>(type: "int", nullable: false),
                    Seller_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller_contacts", x => new { x.Contact_id, x.Seller_id });
                    table.ForeignKey(
                        name: "FK_Seller_contacts_Contact",
                        column: x => x.Contact_id,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seller_contacts_Seller",
                        column: x => x.Seller_id,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_address",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Postal_Code = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Region = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_address", x => new { x.Customer_id, x.Id });
                    table.ForeignKey(
                        name: "FK_Customer_address_Customer",
                        column: x => x.Customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_contacts",
                columns: table => new
                {
                    Contact_id = table.Column<int>(type: "int", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_contacts", x => new { x.Contact_id, x.Customer_id });
                    table.ForeignKey(
                        name: "FK_Customer_contacts_Contact",
                        column: x => x.Contact_id,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_contacts_Customer",
                        column: x => x.Customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "List",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Privacy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List", x => x.Id);
                    table.ForeignKey(
                        name: "FK_List_Customer",
                        column: x => x.customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Order_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Estimated_Delivery_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Order_address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Creditcard_id = table.Column<int>(type: "int", nullable: true),
                    Customer_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Creditcards",
                        column: x => x.Creditcard_id,
                        principalTable: "Creditcards",
                        principalColumn: "Creditcard_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customer",
                        column: x => x.Customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Shipping = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: false),
                    Subcategory_id = table.Column<int>(type: "int", nullable: false),
                    Seller_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Seller",
                        column: x => x.Seller_id,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Subcategory",
                        column: x => x.Subcategory_id,
                        principalTable: "Subcategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cart_Products",
                columns: table => new
                {
                    Cart_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart_Products", x => new { x.Cart_id, x.Product_id });
                    table.ForeignKey(
                        name: "FK_Cart_Products_Cart",
                        column: x => x.Cart_id,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cart_Products_Product",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Products",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Products", x => new { x.Customer_id, x.Product_id });
                    table.ForeignKey(
                        name: "FK_Customer_Products_Customer",
                        column: x => x.Customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Products_Product",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Products_Rates",
                columns: table => new
                {
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Rate_number = table.Column<int>(type: "int", nullable: true),
                    Feedback = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Products_Rates", x => new { x.Customer_id, x.Product_id });
                    table.ForeignKey(
                        name: "FK_Customer_Products_Rates_Customer",
                        column: x => x.Customer_id,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Products_Rates_Product",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "product_options",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false),
                    option_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_options", x => new { x.product_id, x.option_id });
                    table.ForeignKey(
                        name: "FK_product_options_options",
                        column: x => x.option_id,
                        principalTable: "options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_product_options_Product",
                        column: x => x.product_id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_Q&A",
                columns: table => new
                {
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Question_id = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Answer = table.Column<string>(type: "varchar(220)", unicode: false, maxLength: 220, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Q&A", x => new { x.Product_id, x.Question_id });
                    table.ForeignKey(
                        name: "FK_Product_Q&A_Product",
                        column: x => x.Product_id,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Products_Product_id",
                table: "Cart_Products",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Admin_id",
                table: "Contact",
                column: "Admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Cart_id",
                table: "Customer",
                column: "Cart_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_contacts_Customer_id",
                table: "Customer_contacts",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Products_Product_id",
                table: "Customer_Products",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Products_Rates_Product_id",
                table: "Customer_Products_Rates",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_List_customer_id",
                table: "List",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Creditcard_id",
                table: "Orders",
                column: "Creditcard_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_id",
                table: "Orders",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Seller_id",
                table: "Product",
                column: "Seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Subcategory_id",
                table: "Product",
                column: "Subcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_options_option_id",
                table: "product_options",
                column: "option_id");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_contacts_Seller_id",
                table: "Seller_contacts",
                column: "Seller_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategory_Category_id",
                table: "Subcategory",
                column: "Category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart_Products");

            migrationBuilder.DropTable(
                name: "Customer_address");

            migrationBuilder.DropTable(
                name: "Customer_contacts");

            migrationBuilder.DropTable(
                name: "Customer_Products");

            migrationBuilder.DropTable(
                name: "Customer_Products_Rates");

            migrationBuilder.DropTable(
                name: "List");

            migrationBuilder.DropTable(
                name: "List_products");

            migrationBuilder.DropTable(
                name: "Order_products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "product_options");

            migrationBuilder.DropTable(
                name: "Product_Q&A");

            migrationBuilder.DropTable(
                name: "Seller_contacts");

            migrationBuilder.DropTable(
                name: "Creditcards");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "options");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Subcategory");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
