using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class ArzyabiDto : IBackupable
{
    public required string IdArzyabi { get; set; }
    public string? UserId { get; set; }
    public string? State { get; set; }
    public string? SathRisk { get; set; }
    public string? OnvaneShoghli { get; set; }

    public DateTime DateCraeted { get; set; }


    public int Id_Matter1 { get; set; }
    public string? DarajeKhatar_Matter1 { get; set; }
    public string? Name_Matter1 { get; set; }

    #region nataej mojood Fields
    // M_ be manaye Mojod
    public string? M_MizanMovajehe_Matter1 { get; set; }
    public string? M_TLV_Matter1 { get; set; }
    public string? M_MianginZaman_Matter1 { get; set; }
    public string? M_TedadDafaat_Matter1 { get; set; }

    #endregion

    #region nataej NAmojood Fields
    // N_ be manaye NaMojod
    public string? N_MizanMadeEstefade_Matter1 { get; set; }
    public string? N_NesbatBeTLV_Matter1 { get; set; }
    public string? N_ModatKarHafte_Matter1 { get; set; }
    public string? N_EghdanatControlli_Matter1 { get; set; }
    public string? N_FesharBokhar_Matter1 { get; set; }
    public string? N_AndazeZarat_Matter1 { get; set; }

    #endregion



    public int Id_Matter2 { get; set; }
    public string? DarajeKhatar_Matter2 { get; set; }
    public string? Name_Matter2 { get; set; }

    #region nataej mojood Fields
    // M_ be manaye Mojod
    public string? M_MizanMovajehe_Matter2 { get; set; }
    public string? M_TLV_Matter2 { get; set; }
    public string? M_MianginZaman_Matter2 { get; set; }
    public string? M_TedadDafaat_Matter2 { get; set; }

    #endregion

    #region nataej NAmojood Fields
    // M_ be manaye NaMojod
    public string? N_MizanMadeEstefade_Matter2 { get; set; }
    public string? N_NesbatBeTLV_Matter2 { get; set; }
    public string? N_ModatKarHafte_Matter2 { get; set; }
    public string? N_EghdanatControlli_Matter2 { get; set; }
    public string? N_FesharBokhar_Matter2 { get; set; }
    public string? N_AndazeZarat_Matter2 { get; set; }

    #endregion


    public int Id_Matter3 { get; set; }
    public string? Name_Matter3 { get; set; }
    public string? DarajeKhatar_Matter3 { get; set; }

    #region nataej mojood Fields
    // M_ be manaye Mojod
    public string? M_MizanMovajehe_Matter3 { get; set; }
    public string? M_TLV_Matter3 { get; set; }
    public string? M_MianginZaman_Matter3 { get; set; }
    public string? M_TedadDafaat_Matter3 { get; set; }

    #endregion

    #region nataej NAmojood Fields
    // M_ be manaye NaMojod
    public string? N_MizanMadeEstefade_Matter3 { get; set; }
    public string? N_NesbatBeTLV_Matter3 { get; set; }
    public string? N_ModatKarHafte_Matter3 { get; set; }
    public string? N_EghdanatControlli_Matter3 { get; set; }
    public string? N_FesharBokhar_Matter3 { get; set; }
    public string? N_AndazeZarat_Matter3 { get; set; }

    #endregion



    public string? SaatKarDarHafte { get; set; }
    public string? NatijeNahaei { get; set; }


    public int Vahed { get; set; }
    public string? Tarikh { get; set; }
    public string? Onvane { get; set; }
    public string? Arzyab { get; set; }















    public int IdArzyabiApp { get; set; }






    public Guid BackupStatusId { get; set; }
}


