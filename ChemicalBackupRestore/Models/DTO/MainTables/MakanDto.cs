public class MakanDto : IBackupable
{
    public required string ID_Makan { get; set; }
    public int ID_MakanApp { get; set; }
    public string? OnvanMakan { get; set; }

    public Guid BackupStatusId { get; set; }
}
