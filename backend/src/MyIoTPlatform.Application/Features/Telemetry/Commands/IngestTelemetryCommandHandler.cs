using MediatR;
using MyIoTPlatform.Domain.Entities;
using MyIoTPlatform.Domain.Interfaces.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace MyIoTPlatform.Application.Features.Telemetry.Commands;

public class IngestTelemetryCommandHandler : IRequestHandler<IngestTelemetryCommand>
{
    private readonly ITelemetryRepository _telemetryRepository;

    public IngestTelemetryCommandHandler(ITelemetryRepository telemetryRepository)
    {
        _telemetryRepository = telemetryRepository;
    }

    public async Task Handle(IngestTelemetryCommand request, CancellationToken cancellationToken)
    {
        foreach (var item in request.TelemetryData)
        {
            var telemetry = new TelemetryData
            {
                DeviceId = request.DeviceId,
                Timestamp = request.Timestamp,
                Key = item.Key,
                Value = item.Value
            };
            await _telemetryRepository.AddAsync(telemetry, cancellationToken);
        }
        //có thể cần gọi SaveChangesAsync nếu bạn đang sử dụng UnitOfWork pattern
    }
}