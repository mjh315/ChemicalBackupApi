public class ConfigBackupReqDto
{
    public required int AdminId { get; set; }
    public required string BackupName { get; set; }
    public required string BackupDescription { get; set; }
    public required List<string> TableName { get; set; }
}