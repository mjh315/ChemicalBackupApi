
public class VahedDto : IBackupable
{
    public int IdLVahedApp { get; set; }
    public required string TiletVahed { get; set; }
    public required string Map_Name_File { get; set; }
    public Guid BackupStatusId { get; set; }
}
