using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class CalendarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EventText { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime EventDate { get; set; }
        public int? RelationshipId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("RelationshipId")]
        public virtual RelationshipModel Relationship { get; set; }
    }
}