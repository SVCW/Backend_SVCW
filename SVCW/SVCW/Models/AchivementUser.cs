﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class AchivementUser
    {
        [Key]
        [Column("achivementId")]
        [StringLength(10)]
        public string AchivementId { get; set; }
        [Key]
        [Column("userId")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column("endDate", TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        [ForeignKey("AchivementId")]
        [InverseProperty("AchivementUser")]
        public virtual Achivement Achivement { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AchivementUser")]
        public virtual User User { get; set; }
    }
}