using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class GalleryModel : BaseModel
    {
        [Key]
        public int Id { get; set; }

        public string ImgUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}