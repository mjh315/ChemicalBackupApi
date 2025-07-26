
public class TajhizatHefazatfardiDto : IBackupable
{

    public string? HefazatCheshm { get; set; }
    public string? HefazatDast { get; set; }
    public string? HefazatBadan { get; set; }
    public string? HefazatSystemtanafosi { get; set; }
    public string? HefazatPa { get; set; }
    public string? FaktorhayeHefazatTanafosi { get; set; }
    public string? HoodoodMojazBiologic { get; set; }
    public string? EghdamatControliMohandesi { get; set; }
    public string? VasayelHefazatiHararati { get; set; }



    public int IdTajhizatHefazatfardiApp { get; set; }
    public int TAllmadehIdApp { get; set; }



    public Guid BackupStatusId { get; set; }
}

