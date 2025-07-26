public class PaydarimadehDto : IBackupable
{
    public string? Paydari { get; set; }
    public string? SharayetGhabelEhteraz { get; set; }
    public string? KhataratVakoneshdehi { get; set; }
    public string? MahsolatTajziyeKhatarnak { get; set; }
    public int? AdadVakoneshDehiNfpa { get; set; }




    public int IdPaydarimadehApp { get; set; }
    public int TAllmadehIdApp { get; set; }



    public Guid BackupStatusId { get; set; }

}

