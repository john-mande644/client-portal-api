﻿// <auto-generated />
using ClientPortal_API.Data.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClientPortal_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230220164757_SalesOrdersByShipMethod")]
    partial class SalesOrdersByShipMethod
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+Asn", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ArrivedCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "arrivedCount");

                    b.Property<int>("InProcessCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "inProcessCount");

                    b.Property<int>("NonconformingCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "nonconformingCount");

                    b.Property<int>("PendingCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "pendingCount");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_asn", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+AverageReturns", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "total");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_average_returns", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+AverageUnitsReturned", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "total");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_average_units_returned", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+Inventory", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DamagedProductCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "damagedProductCount");

                    b.Property<int>("LowStockProductCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "lowStockProductCount");

                    b.Property<int>("OutOfStockProductCount")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "outOfStockProductCount");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_inventory", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+PromisesMet", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FulfilmentAccuracyPercent")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "fulfilmentAccuracyPercent");

                    b.Property<int>("FulfilmentSavings")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "fulfilmentSavings");

                    b.Property<int>("OnTimePercent")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "onTimePercent");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_promises_met", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+Receives", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Nonconforming")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "nonconforming");

                    b.Property<int>("Total")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "total");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_receives", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+ReturnedOrders", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_returned_orders", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+ReturnedUnits", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_returned_units", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+SalesOrdersByChannel", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_sales_orders_by_channel", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+SalesOrdersByShipMethod", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_sales_orders_by_ship_method", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+ShippedOrders", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_shipped_orders", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+TodaysOrders", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("FulfilmentStatusPercent")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "totalValue");

                    b.Property<int>("OnHold")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "onHold");

                    b.Property<int>("TotalOrders")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "totalOrders");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_todays_orders", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+TopReturnedItems", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "productId");

                    b.Property<int>("Sku")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "sku");

                    b.Property<int>("returnQuantity")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "returnQuantity");

                    b.Property<int>("returnRank")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "soldRank");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_top_returned_items", (string)null);
                });

            modelBuilder.Entity("ClientPortal_API.Schemas.v1.Widget+TopSellingItems", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "productId");

                    b.Property<int>("Sku")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "sku");

                    b.Property<int>("SoldQuantity")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "soldQuantity");

                    b.Property<int>("SoldRank")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "soldRank");

                    b.HasKey("ClientId");

                    b.ToTable((string)null);

                    b.ToView("vw_portal_widget_top_selling_items", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
