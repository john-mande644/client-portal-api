
using AutoMapper;
using ClientPortal_API.Schemas.v1;
using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Widget.Asn, WidgetDTO.GetAsn>();
            CreateMap<Widget.AverageReturns, WidgetDTO.GetAverageReturns>();
            CreateMap<Widget.AverageUnitsReturned, WidgetDTO.GetAverageUnitsReturned>();
            CreateMap<Widget.Inventory, WidgetDTO.GetInventory>();
            CreateMap<Widget.PromisesMet, WidgetDTO.GetPromisesMet>();
            CreateMap<Widget.Receives, WidgetDTO.GetReceives>();
            CreateMap<Widget.ReturnedOrders, WidgetDTO.GetReturnedOrders>();
            CreateMap<Widget.ReturnedUnits, WidgetDTO.GetReturnedUnits>();
            CreateMap<Widget.SalesOrdersByChannel, WidgetDTO.GetSalesOrdersByChannel>();
            CreateMap<Widget.SalesOrdersByShipMethod, WidgetDTO.GetSalesOrdersByShipMethod>();
            CreateMap<Widget.ShippedOrders, WidgetDTO.GetShippedOrders>();
            CreateMap<Widget.TodaysOrders, WidgetDTO.GetTodaysOrders>();
            CreateMap<Widget.TopReturnedItems, WidgetDTO.GetTopReturnedItems>();
            CreateMap<Widget.TopSellingItems, WidgetDTO.GetTopSellingItems>();
        }
    }
}