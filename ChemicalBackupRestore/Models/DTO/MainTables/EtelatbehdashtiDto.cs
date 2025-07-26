public class EtelatbehdashtiDto : IBackupable
{
    public required string IdEtelatbehdashti { get; set; }

    public string? AlaemMovajehe { get; set; }
    public string? AsaratMozmen { get; set; }
    public string? AsaratHad { get; set; }
    public string? GhabeleyatTahrik { get; set; }
    public string? AndamHadaf { get; set; }
    public string? AsaratKotahModat { get; set; }
    public string? RahhayeMovajehe { get; set; }
    public string? MoayenatPezeshki { get; set; }
    public string? MoayenatPezeshiPasazMovajehe { get; set; }





    public int IdEtelatbehdashtiApp { get; set; }
    public int TAllmadehIdApp { get; set; }






    public Guid BackupStatusId { get; set; }

}
