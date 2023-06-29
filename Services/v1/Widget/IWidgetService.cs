using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API.Services.v1
{
    public interface IWidgetService
    {
        Task<WidgetDTO.GetTodaysOrders> GetTodaysOrdersWidget(int clientId);
        Task<List<WidgetDTO.GetShippedOrders>> GetShippedOrdersWidget(int clientId);
        Task<List<WidgetDTO.GetSalesOrdersByChannel>> GetSalesOrdersByChannelWidget(int clientId);
        Task<List<WidgetDTO.GetTopSellingItems>> GetTopSellingItemsWidget(int clientId);
        Task<List<WidgetDTO.GetSalesOrdersByShipMethod>> GetSalesOrdersByShipMethodWidget(int clientId);
        Task<WidgetDTO.GetPromisesMet> GetPromisesMetWidget(int clientId);
        Task<WidgetDTO.GetAsn> GetAsnWidget(int clientId);
        Task<WidgetDTO.GetReceives> GetReceivesWidget(int clientId);
        Task<WidgetDTO.GetInventory> GetInventoryWidget(int clientId);
        Task<List<WidgetDTO.GetReturnedOrders>> GetReturnedOrdersWidget(int clientId);
        Task<WidgetDTO.GetAverageReturns> GetAverageReturnsWidget(int clientId);
        Task<WidgetDTO.GetAverageUnitsReturned> GetAverageUnitsReturnedWidget(int clientId);
        Task<List<WidgetDTO.GetReturnedUnits>> GetReturnedUnitsWidget(int clientId);
        Task<List<WidgetDTO.GetTopReturnedItems>> GetTopReturnedItemsWidget(int clientId);
    }
}
