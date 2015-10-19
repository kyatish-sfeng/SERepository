using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class RelationshipModel
    {
        [Key]
        public int RelationshipId { get; set; }
        public string RelationshipText { get; set; }
    }
}