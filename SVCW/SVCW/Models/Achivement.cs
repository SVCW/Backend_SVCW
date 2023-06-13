﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class Achivement
    {
        public Achivement()
        {
            AchivementUser = new HashSet<AchivementUser>();
        }

        [Key]
        [Column("achivementId")]
        [StringLength(10)]
        public string AchivementId { get; set; }
        [Column("achivementLogo")]
        public string AchivementLogo { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("createAt", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("status")]
        public bool Status { get; set; }

        [InverseProperty("Achivement")]
        public virtual ICollection<AchivementUser> AchivementUser { get; set; }
    }
}