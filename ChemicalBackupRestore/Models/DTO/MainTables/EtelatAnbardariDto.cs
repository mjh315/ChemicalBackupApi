public class EtelatAnbardariDto : IBackupable
{
    public string? DamayeNegahdari { get; set; }

    public string? SharayetNegahdari { get; set; }
    public string? MavadNasazegar { get; set; }
    public string? ModatZamanNegahdari { get; set; }
    public string? SharayetMamnoehAnbaresh { get; set; }
    public string? ZorofMonasebAnbaresh { get; set; }




    public int IdEtelatAnbardariApp { get; set; }
    public int TAllmadehIdApp { get; set; }





    public Guid BackupStatusId { get; set; }

}
