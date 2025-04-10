namespace MyIoTPlatform.Domain.Entities;

public class Device
{
    public string Label { get; set; } = string.Empty;
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Ví dụ: "Sensor", "Actuator"
    public string Description { get; set; } = string.Empty;
    public bool Enabled { get; set; }
    public string Status { get; set; } = "Inactive"; // Ví dụ: "Active", "Inactive", "Error"
    public DateTime CreatedAt { get; set; }
    public DateTime? LastActivityAt { get; set; }
    public DateTime? UpdateAt {get; set;}
    public ICollection<TelemetryData> Telemetries { get; set; } = new List<TelemetryData>();
    // Thêm các thuộc tính khác nếu cần
}