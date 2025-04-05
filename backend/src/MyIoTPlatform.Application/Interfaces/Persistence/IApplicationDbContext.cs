using MyIoTPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyIoTPlatform.Application.Interfaces.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Device> Devices { get; set; }
        DbSet<TelemetryData> TelemetryDatas { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}