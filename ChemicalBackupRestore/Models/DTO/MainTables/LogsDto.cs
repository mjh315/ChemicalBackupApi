public class LogsDto : IBackupable
{
    public required string IdLog { get; set; }
    public string? Message { get; set; }
    public string? Level { get; set; }
    public DateTime TimeStamp { get; set; }
    public string? Exception { get; set; }
    public string? LogEvent { get; set; }
    public string? UserId { get; set; }
    public string? Username { get; set; }
    public string? ClientIp { get; set; }


    public int IdLogApp { get; set; }


    public Guid BackupStatusId { get; set; }
}

