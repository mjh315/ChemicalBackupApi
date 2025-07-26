public class OnvanShoghliDto : IBackupable
{


    public required string ID_OnvanShoghli { get; set; }
    public string? Onvan_Shoghli { get; set; }
    public string? Sharhe_Shoghli { get; set; }



    public int ID_OnvanShoghliApp { get; set; }
    public int T_Vaheds_ID { get; set; }





    public Guid BackupStatusId { get; set; }
}


