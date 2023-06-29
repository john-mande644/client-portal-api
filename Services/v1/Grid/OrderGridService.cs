using AutoMapper;
using ClientPortal_API.Data.v1;
using ClientPortal_API.DTOs.v1;
using ClientPortal_API.Schemas.v1;
using Microsoft.EntityFrameworkCore;

namespace ClientPortal_API.Services.v1;

public class OrderGridService : IGridService<GridDTO.GetOrder>
{
    private readonly IMapper _mapper;
    private readonly DataContext _context;

    public OrderGridService(IMapper mapper, DataContext context)
    {
        _mapper = mapper;
        _context = context;
    }
    
    public async Task<List<GridDTO.GetOrder>> GetItemsAsync(int clientId)
    {
        return await _context.Orders.Where(x => x.ClientId == clientId)
            .Select(x => _mapper.Map<Grid.Order, GridDTO.GetOrder>(x)).ToListAsync();
    }
}