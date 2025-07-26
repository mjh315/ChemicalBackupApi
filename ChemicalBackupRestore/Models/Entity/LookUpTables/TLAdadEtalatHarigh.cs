using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public partial class TLAdadEtalatHarigh : IBackupable
    {

        [Key]
        public required string IdAdadEtalatHarigh { get; set; }
        public int IdAdadEtalatHarighApp { get; set; }
        public string? TitelsAdadEtalatHarigh { get; set; }
        public string? CodeEtalatHarigh { get; set; }



        //navigation property
        public virtual IList<TAllmadeh>? TAllmadeh { get; set; }
                public Guid BackupStatusId { get; set; }
        // Navigation
        [ForeignKey("BackupStatusId")]
        public virtual BackupStatus BackupStatus { get; set; }
    }

