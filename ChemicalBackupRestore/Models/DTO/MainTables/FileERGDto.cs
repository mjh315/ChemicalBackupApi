public class FileERGDto : IBackupable
{
    public int IdFileERGApp { get; set; }
    public string? Url { get; set; }
    public string? Format { get; set; }
    public string? Onvan { get; set; }
    public DateTime? DateCreate { get; set; }
    public string? UserId { get; set; }


    public Guid BackupStatusId { get; set; }
}

