using AutoMapper;
using ClientPortal_API.Data.v1;
using ClientPortal_API.Schemas.v1;
using ClientPortal_API.DTOs.v1;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ClientPortal_API.Services.v1
{
    public class WidgetService : IWidgetService
    {
        private readonly IMapper _mapper;

        private readonly DataContext _context;
        public WidgetService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        /// Todays Orders Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetTodaysOrders> GetTodaysOrdersWidget(int clientId)
        {

            Widget.TodaysOrders todaysOrdersWidgetData = new Widget.TodaysOrders();
            WidgetDTO.GetTodaysOrders todaysOrdersWidgetDTO = new WidgetDTO.GetTodaysOrders();
            try
            {
                todaysOrdersWidgetData = await _context.todaysOrdersWidget.Where(x => x.ClientId.Equals(clientId)).FirstOrDefaultAsync();

                if (todaysOrdersWidgetData != null)
                {
                    todaysOrdersWidgetDTO = _mapper.Map<WidgetDTO.GetTodaysOrders>(todaysOrdersWidgetData);
                }

                return todaysOrdersWidgetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Shipped Orders Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetShippedOrders>> GetShippedOrdersWidget(int clientId)
        {
            List<Widget.ShippedOrders> shippedOrdersWidgetData = new List<Widget.ShippedOrders>();
            List<WidgetDTO.GetShippedOrders> shippedOrdersDTO = new List<WidgetDTO.GetShippedOrders>();
            try
            {
                shippedOrdersWidgetData = await _context.shippedOrdersWidget.Where(x => x.ClientId.Equals(clientId)).ToListAsync();

                if (shippedOrdersWidgetData != null)
                {
                    var groups = shippedOrdersWidgetData.GroupBy(d => new { d.Date });

                    foreach (var group in groups)
                    {
                        var shippedOrders = new WidgetDTO.GetShippedOrders
                        {
                            Date = group.Key.Date.ToString("yyyy-MM-dd"),
                            Channels = group.GroupBy(b => new { b.Channel }).Select(d => new WidgetDTO.Channel
                            {
                                Name = d.Key.Channel,
                                Total = d.Sum(s => s.Total)
                            }).ToList()
                        };

                        shippedOrdersDTO.Add(shippedOrders);
                    }
                }

                return shippedOrdersDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Sales Orders by Channel for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetSalesOrdersByChannel>> GetSalesOrdersByChannelWidget(int clientId)
        {
            List<Widget.ShippedOrders> shippedOrdersWidgetData = new List<Widget.ShippedOrders>();
            List<WidgetDTO.GetSalesOrdersByChannel> salesOrdersByChannelDTO = new List<WidgetDTO.GetSalesOrdersByChannel>();
            try
            {

                return salesOrdersByChannelDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Top Selling Items Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetTopSellingItems>> GetTopSellingItemsWidget(int clientId)
        {
            var topSellingItemsWidgetData = new List<Widget.TopSellingItems>();
            var topSellingItemsWidgetDTO = new List<WidgetDTO.GetTopSellingItems>();

            try
            {
                topSellingItemsWidgetData = await _context.topSellingItemsWidget.Where(x => x.ClientId.Equals(clientId))
                    .ToListAsync();

                if (topSellingItemsWidgetData != null)
                {
                    topSellingItemsWidgetDTO = _mapper.Map<List<WidgetDTO.GetTopSellingItems>>(topSellingItemsWidgetData);
                }
                return topSellingItemsWidgetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Sales Orders by Channel for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetSalesOrdersByShipMethod>> GetSalesOrdersByShipMethodWidget(int clientId)
        {
            List<Widget.SalesOrdersByShipMethod> salesOrdersByShipMethodData = new List<Widget.SalesOrdersByShipMethod>();
            List<WidgetDTO.GetSalesOrdersByShipMethod> salesOrdersByShipMethodDTO = new List<WidgetDTO.GetSalesOrdersByShipMethod>();
            try
            {
                salesOrdersByShipMethodData = await _context.salesOrdersByShipMethodWidget.Where(x => x.ClientId.Equals(clientId)).ToListAsync();

                var groups = salesOrdersByShipMethodData.GroupBy(d => new { d.Date });

                foreach (var group in groups)
                {
                    var shippedOrders = new WidgetDTO.GetSalesOrdersByShipMethod
                    {
                        Date = group.Key.Date.ToString("yyyy-MM-dd"),
                        Methods = group.GroupBy(b => new { b.Method }).Select(d => new WidgetDTO.ShipMethod
                        {
                            Name = d.Key.Method,
                            Total = d.Sum(s => s.Total)
                        }).ToList()
                    };

                    salesOrdersByShipMethodDTO.Add(shippedOrders);
                }

                return salesOrdersByShipMethodDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Promises Mwt Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetPromisesMet> GetPromisesMetWidget(int clientId)
        {
            var promisesMetWidgetData = new Widget.PromisesMet();
            WidgetDTO.GetPromisesMet promisesMetDTO = new WidgetDTO.GetPromisesMet();
            try
            {
                promisesMetWidgetData = await _context.promisesMetWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (promisesMetWidgetData != null)
                {
                    promisesMetDTO = _mapper.Map<WidgetDTO.GetPromisesMet>(promisesMetWidgetData);
                }

                return promisesMetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// ASNs Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetAsn> GetAsnWidget(int clientId)
        {
            var asnWidgetData = new Widget.Asn();
            var asnWidgetDTO = new WidgetDTO.GetAsn();
            try
            {
                asnWidgetData = await _context.asnWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (asnWidgetData != null)
                {
                    asnWidgetDTO = _mapper.Map<WidgetDTO.GetAsn>(asnWidgetData);
                }

                return asnWidgetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Receives Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetReceives> GetReceivesWidget(int clientId)
        {
            var receivesWidgetData = new Widget.Receives();
            var receivesWidgetDTO = new WidgetDTO.GetReceives();
            try
            {
                receivesWidgetData = await _context.receivesWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (receivesWidgetData != null)
                {
                    receivesWidgetDTO = _mapper.Map<WidgetDTO.GetReceives>(receivesWidgetData);
                }
                return receivesWidgetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Inventory for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetInventory> GetInventoryWidget(int clientId)
        {
            var inventoryWidgetData = new Widget.Inventory();
            var inventoryWidgetDTO = new WidgetDTO.GetInventory();
            try
            {
                inventoryWidgetData = await _context.inventoryWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (inventoryWidgetData != null)
                {
                    inventoryWidgetDTO = _mapper.Map<WidgetDTO.GetInventory>(inventoryWidgetData);
                }
                return inventoryWidgetDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returned Orders Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetReturnedOrders>> GetReturnedOrdersWidget(int clientId)
        {
            var returnedOrdersWidgetData = new List<Widget.ReturnedOrders>();
            var returnedOrdersDTO = new List<WidgetDTO.GetReturnedOrders>();
            try
            {
                returnedOrdersWidgetData = await _context.returnedOrdersWidget.Where(x => x.ClientId.Equals(clientId))
                    .ToListAsync();

                if (returnedOrdersWidgetData != null)
                {
                    var groups = returnedOrdersWidgetData.GroupBy(d => new { d.Date });

                    foreach (var group in groups)
                    {
                        var shippedOrders = new WidgetDTO.GetReturnedOrders
                        {
                            Date = group.Key.Date.ToString("yyyy-MM-dd"),
                            Channels = group.GroupBy(b => new { b.Channel }).Select(d => new WidgetDTO.Channel
                            {
                                Name = d.Key.Channel,
                                Total = d.Sum(s => s.Total)
                            }).ToList()
                        };

                        returnedOrdersDTO.Add(shippedOrders);
                    }
                }

                return returnedOrdersDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Average Returns Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetAverageReturns> GetAverageReturnsWidget(int clientId)
        {
            var averageReturnsWidgetData = new Widget.AverageReturns();
            var averageReturnsDTO = new WidgetDTO.GetAverageReturns();
            try
            {
                averageReturnsWidgetData = await _context.averageReturnsWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (averageReturnsWidgetData != null)
                {
                    averageReturnsDTO = _mapper.Map<WidgetDTO.GetAverageReturns>(averageReturnsWidgetData);
                }

                return averageReturnsDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Average Units Returned Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<WidgetDTO.GetAverageUnitsReturned> GetAverageUnitsReturnedWidget(int clientId)
        {
            var averageUnitsReturnedWidgetData = new Widget.AverageUnitsReturned();
            var averageUnitsReturnedDTO = new WidgetDTO.GetAverageUnitsReturned();
            try
            {
                averageUnitsReturnedWidgetData = await _context.averageUnitsReturnedWidget.Where(x => x.ClientId.Equals(clientId))
                    .FirstOrDefaultAsync();

                if (averageUnitsReturnedWidgetData != null)
                {
                    averageUnitsReturnedDTO = _mapper.Map<WidgetDTO.GetAverageUnitsReturned>(averageUnitsReturnedWidgetData);
                }

                return averageUnitsReturnedDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returned Units Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetReturnedUnits>> GetReturnedUnitsWidget(int clientId)
        {
            var returnedUnitsWidgetData = new List<Widget.ReturnedUnits>();
            var returnedUnitsDTO = new List<WidgetDTO.GetReturnedUnits>();
            try
            {
                returnedUnitsWidgetData = await _context.returnedUnitsWidget.Where(x => x.ClientId.Equals(clientId))
                    .ToListAsync();

                if (returnedUnitsWidgetData != null)
                {
                    var groups = returnedUnitsWidgetData.GroupBy(d => new { d.Date });

                    foreach (var group in groups)
                    {
                        var shippedOrders = new WidgetDTO.GetReturnedUnits
                        {
                            Date = group.Key.Date.ToString("yyyy-MM-dd"),
                            Channels = group.GroupBy(b => new { b.Channel }).Select(d => new WidgetDTO.Channel
                            {
                                Name = d.Key.Channel,
                                Total = d.Sum(s => s.Total)
                            }).ToList()
                        };

                        returnedUnitsDTO.Add(shippedOrders);
                    }
                }

                return returnedUnitsDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Top Returned Items Widget for given Client Id
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<List<WidgetDTO.GetTopReturnedItems>> GetTopReturnedItemsWidget(int clientId)
        {
            var topReturnedItemsWidgetData = new List<Widget.TopReturnedItems>();
            var topReturnedItemsDTO = new List<WidgetDTO.GetTopReturnedItems>();
            try
            {
                topReturnedItemsWidgetData = await _context.topReturnedItemsWidget.Where(x => x.ClientId.Equals(clientId))
                    .ToListAsync();

                if (topReturnedItemsWidgetData != null)
                {
                    topReturnedItemsDTO = _mapper.Map<List<WidgetDTO.GetTopReturnedItems>>(topReturnedItemsWidgetData);
                }

                return topReturnedItemsDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
