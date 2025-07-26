using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public partial class TLKhataratKhas : IBackupable
    {
        [Key]
        public required string IdKhataratKhas { get; set; }
        public int IdKhataratKhasApp { get; set; }

        public string? TitelsKhataratKhas { get; set; }
        public string? CodeKhataratKhas { get; set; }




        // navigation
        public virtual IList<TAllmadeh>? TAllmadeh { get; set; }

        public Guid BackupStatusId { get; set; }
        // Navigation
        [ForeignKey("BackupStatusId")]
        public virtual BackupStatus BackupStatus { get; set; }
    }

