public class ConfigBackupResDto
{
    public required string BackupName { get; set; }
    public required string BackupDescription { get; set; }
    public required List<string> TableName { get; set; }
    public required DateTime BackupDate { get; set; }
}