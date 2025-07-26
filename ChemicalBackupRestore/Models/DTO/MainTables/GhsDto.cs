public class GhsDto : IBackupable
{


    public string? Signal { get; set; }
    public string? BayaneKhatar { get; set; }
    public string? JomleEhtiyati { get; set; }
    public string? Piktogram { get; set; }




    public int IdGhsApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public Guid BackupStatusId { get; set; }
}

