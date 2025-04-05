using MediatR;
using System;
using System.Collections.Generic;

namespace MyIoTPlatform.Application.Features.Telemetry.Commands;

public record IngestTelemetryCommand(Guid DeviceId, DateTime Timestamp, Dictionary<string, string> TelemetryData) : IRequest;