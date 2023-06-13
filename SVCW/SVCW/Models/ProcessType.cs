﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class ProcessType
    {
        public ProcessType()
        {
            Process = new HashSet<Process>();
        }

        [Key]
        [Column("processTypeId")]
        [StringLength(10)]
        public string ProcessTypeId { get; set; }
        [Required]
        [Column("processTypeName")]
        public string ProcessTypeName { get; set; }
        [Required]
        [Column("description")]
        public string Description { get; set; }

        [InverseProperty("ProcessType")]
        public virtual ICollection<Process> Process { get; set; }
    }
}