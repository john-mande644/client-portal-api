using AutoMapper;
using ClientPortal_API.Data.v1;
using ClientPortal_API.DTOs.v1;
using ClientPortal_API.Schemas.v1;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientPortal_API.Services.v1
{
    public class DashboardService : IDashboardService
    {
        private readonly IMapper _mapper;
        private readonly WidgetService _widgetService;

        public DashboardService(IMapper mapper, WidgetService widgetService)
        {
            _mapper = mapper;
            _widgetService = widgetService;
        }

        /// <summary>
        /// Returns the Client Dashboard with widget data for the given Client Id
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public async Task<DashboardDTO.GetClient> GetClientDashboard(int clientId)
        {
            try
            {
                var clientDashboard = new DashboardDTO.GetClient();

                clientDashboard.PromisesMet = await _widgetService.GetPromisesMetWidget(clientId);
                clientDashboard.TodaysOrders = await _widgetService.GetTodaysOrdersWidget(clientId);
                clientDashboard.Asn = await _widgetService.GetAsnWidget(clientId);
                clientDashboard.Receives = await _widgetService.GetReceivesWidget(clientId);
                clientDashboard.Inventory = await _widgetService.GetInventoryWidget(clientId);

                return clientDashboard;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the Sales Orders Dashboard with data for the given Client Id
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public async Task<DashboardDTO.GetSalesOrders> GetSalesOrdersDashboard(int clientId)
        {
            try
            {
                var salesOrderDashboard = new DashboardDTO.GetSalesOrders();

                salesOrderDashboard.TodaysOrders = await _widgetService.GetTodaysOrdersWidget(clientId);
                salesOrderDashboard.ShippedOrders = await _widgetService.GetShippedOrdersWidget(clientId);
                salesOrderDashboard.SalesOrdersByChannel = await _widgetService.GetSalesOrdersByChannelWidget(clientId);
                salesOrderDashboard.TopSellingItems = await _widgetService.GetTopSellingItemsWidget(clientId);
                salesOrderDashboard.SalesOrdersByShipMethod = await _widgetService.GetSalesOrdersByShipMethodWidget(clientId);

                return salesOrderDashboard;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the Asn & Inventory Dashboard with data for the given Client Id
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public async Task<DashboardDTO.GetAsnInventory> GetAsnInventoryDashboard(int clientId)
        {
            try
            {
                var asnInventoryDashboard = new DashboardDTO.GetAsnInventory();

                asnInventoryDashboard.Inventory = await _widgetService.GetInventoryWidget(clientId);
                asnInventoryDashboard.Asn = await _widgetService.GetAsnWidget(clientId);

                return asnInventoryDashboard;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the Returns Dashboard with data for the given Client Id
        /// </summary>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public async Task<DashboardDTO.GetReturns> GetReturnsDashboard(int clientId)
        {
            try
            {
                var returnsDashboard = new DashboardDTO.GetReturns();

                returnsDashboard.ReturnedOrders = await _widgetService.GetReturnedOrdersWidget(clientId);
                returnsDashboard.AverageReturns = await _widgetService.GetAverageReturnsWidget(clientId);
                returnsDashboard.AverageUnitsReturned = await _widgetService.GetAverageUnitsReturnedWidget(clientId);
                returnsDashboard.ReturnedUnits = await _widgetService.GetReturnedUnitsWidget(clientId);
                returnsDashboard.TopReturnedItems = await _widgetService.GetTopReturnedItemsWidget(clientId);

                return returnsDashboard;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
