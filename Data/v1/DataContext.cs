using ClientPortal_API.DTOs.v1;
using ClientPortal_API.Schemas.v1;
using Microsoft.EntityFrameworkCore;

namespace ClientPortal_API.Data.v1
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // DbSet Widgets - used for widget views
        public DbSet<Widget.Asn> asnWidget => Set<Widget.Asn>();
        public DbSet<Widget.AverageReturns> averageReturnsWidget => Set<Widget.AverageReturns>();
        public DbSet<Widget.AverageUnitsReturned> averageUnitsReturnedWidget => Set<Widget.AverageUnitsReturned>();
        public DbSet<Widget.Inventory> inventoryWidget => Set<Widget.Inventory>();
        public DbSet<Widget.PromisesMet> promisesMetWidget => Set<Widget.PromisesMet>();
        public DbSet<Widget.Receives> receivesWidget => Set<Widget.Receives>();
        public DbSet<Widget.ReturnedOrders> returnedOrdersWidget => Set<Widget.ReturnedOrders>();
        public DbSet<Widget.ReturnedUnits> returnedUnitsWidget => Set<Widget.ReturnedUnits>();
        public DbSet<Widget.SalesOrdersByChannel> salesOrdersByChannelWidget => Set<Widget.SalesOrdersByChannel>();
        public DbSet<Widget.SalesOrdersByShipMethod> salesOrdersByShipMethodWidget => Set<Widget.SalesOrdersByShipMethod>();
        public DbSet<Widget.ShippedOrders> shippedOrdersWidget => Set<Widget.ShippedOrders>();
        public DbSet<Widget.TodaysOrders> todaysOrdersWidget => Set<Widget.TodaysOrders>();
        public DbSet<Widget.TopReturnedItems> topReturnedItemsWidget => Set<Widget.TopReturnedItems>();
        public DbSet<Widget.TopSellingItems> topSellingItemsWidget => Set<Widget.TopSellingItems>();

        // User Auth
        public DbSet<Auth.OwdUsers> owdUsers => Set<Auth.OwdUsers>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Widget.Asn>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_asn");
                    });

            modelBuilder
                .Entity<Widget.AverageReturns>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_average_returns");
                    });

            modelBuilder
                .Entity<Widget.AverageUnitsReturned>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_average_units_returned");
                    });

            modelBuilder
                .Entity<Widget.Inventory>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_inventory");
                    });

            modelBuilder
                .Entity<Widget.PromisesMet>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_promises_met");
                    });

            modelBuilder
                .Entity<Widget.Receives>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_receives");
                    });

            modelBuilder
                .Entity<Widget.ReturnedOrders>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_returned_orders");
                    });

            modelBuilder
                .Entity<Widget.ReturnedUnits>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_returned_units");
                    });

            modelBuilder
                .Entity<Widget.SalesOrdersByChannel>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_sales_orders_by_channel");
                    });

            modelBuilder
                .Entity<Widget.SalesOrdersByShipMethod>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_sales_orders_by_ship_method");
                    });

            modelBuilder
                .Entity<Widget.ShippedOrders>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_shipped_orders");
                    });

            modelBuilder
                .Entity<Widget.TodaysOrders>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_todays_orders");
                    });

            modelBuilder
                .Entity<Widget.TopReturnedItems>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_top_returned_items");
                    });

            modelBuilder
                .Entity<Widget.TopSellingItems>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_portal_widget_top_selling_items");
                    });
        }
    }
}
