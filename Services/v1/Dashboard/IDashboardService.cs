using Microsoft.AspNetCore.Mvc;
using ClientPortal_API.Schemas.v1;
using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API.Services.v1
{
    public interface IDashboardService
    {
        Task<DashboardDTO.GetClient> GetClientDashboard(int clinet_id);
        Task<DashboardDTO.GetSalesOrders> GetSalesOrdersDashboard(int client_id);
        Task<DashboardDTO.GetAsnInventory> GetAsnInventoryDashboard(int client_id);
        Task<DashboardDTO.GetReturns> GetReturnsDashboard(int client_id);
    }
}
