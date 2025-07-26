public class EtelatHamlonaghlDto : IBackupable
{
    public required string IdEtelatHamlonaghl { get; set; }



    public string? RaveshHamlonaghl { get; set; }
    public string? AdadHamloNaghlSazmanMelal { get; set; }
    public string? GroupDasteBandi { get; set; }
    public string? ZorofEstandardHamlonaghl { get; set; }
    public string? EhtiyatatVijheHamlonaghl { get; set; }
    public string? HamlonaghlDaryaei { get; set; }




    public int IdEtelatHamlonaghlApp { get; set; }
    public int TAllmadehIdApp { get; set; }





    public Guid BackupStatusId { get; set; }

}

