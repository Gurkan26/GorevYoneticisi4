using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GorevYoneticisi4.Entities
{
    public class Gorevler
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string title { get; set; }


        public DateTime start { get; set; }
        public DateTime end { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string color { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string textColor { get; set; }

    }
}
