﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class Vote
    {
        [Key]
        [Column("voteId")]
        [StringLength(10)]
        public string VoteId { get; set; }
        [Required]
        [Column("userVoteId")]
        [StringLength(10)]
        public string UserVoteId { get; set; }
        [Required]
        [Column("userId")]
        [StringLength(10)]
        public string UserId { get; set; }
        [Column("isLike")]
        public bool? IsLike { get; set; }
        [Column("isDislike")]
        public bool? IsDislike { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("VoteUser")]
        public virtual User User { get; set; }
        [ForeignKey("UserVoteId")]
        [InverseProperty("VoteUserVote")]
        public virtual User UserVote { get; set; }
    }
}