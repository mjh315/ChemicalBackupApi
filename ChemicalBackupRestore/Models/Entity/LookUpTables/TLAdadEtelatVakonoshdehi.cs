using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public partial class TLAdadEtelatVakonoshdehi : IBackupable
    {
        [Key]
        public required string IdAdadEtelatVakonoshdehi { get; set; }
        public int IdAdadEtelatVakonoshdehiApp { get; set; }
        public string? TitelsAdadEtelatVakonoshdehi { get; set; }
        public string? CodeEtalatVakonoshdehi { get; set; }



        // navigation
        public virtual IList<TAllmadeh>? TAllmadeh { get; set; }

                public Guid BackupStatusId { get; set; }
        // Navigation
        [ForeignKey("BackupStatusId")]
        public virtual BackupStatus BackupStatus { get; set; }
    }

