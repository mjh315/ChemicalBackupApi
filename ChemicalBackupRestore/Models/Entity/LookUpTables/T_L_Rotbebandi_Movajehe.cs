using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public partial class T_L_Rotbebandi_Movajehe : IBackupable
    {
        [Key]
        public required string ID_L_Rotbebandi_MovajeheApp { get; set; }
        public int ID_L_Rotbebandi_Movajehe { get; set; }

        [StringLength(500)]
        public required string Titels_Rotbebandi_Movajehe { get; set; }

        public bool? Active_bit { get; set; }

        public virtual required ICollection<T_Madeh_Movajehe> T_Madeh_Movajehe { get; set; }
        public Guid BackupStatusId { get; set; }
        // Navigation
        [ForeignKey("BackupStatusId")]
        public virtual BackupStatus BackupStatus { get; set; }
    }

