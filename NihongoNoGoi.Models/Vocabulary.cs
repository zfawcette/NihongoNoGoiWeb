using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoNoGoi.Models
{
    public class Vocabulary
    {
        [Key]
        public int Id { get; set; }
        public string Word { get; set; }
        public string Reading { get; set; }
        public string Meaning { get; set; }
        public int AppLevel { get; set; }
        public int JLPTLevel { get; set; }
        public int SRSLevel { get; set; }
        public DateTime UnlockedDate { get; set; }
        public DateTime NextReviewDate { get; set; }
    }
}
