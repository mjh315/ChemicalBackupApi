using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public partial class TLAdadEtelatBehdashti : IBackupable
    {
        [Key]
        public required string IdAdadEtelatBehdashti { get; set; }
        public int IdAdadEtelatBehdashtiApp { get; set; }
        public string? TitelsAdadEtelatBehdashti { get; set; }
        public string? CodeEtalatBehdashti { get; set; }




        // navigation
        public virtual IList<TAllmadeh>? TAllmadeh { get; set; }
        
        public Guid BackupStatusId { get; set; }
        // Navigation
        [ForeignKey("BackupStatusId")]
        public virtual BackupStatus BackupStatus { get; set; }
    }

