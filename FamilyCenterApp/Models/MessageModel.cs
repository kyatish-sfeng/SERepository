using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class MessageModel 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ImgURL { get; set; }
        public int? UserId { get; set; }
    }
}