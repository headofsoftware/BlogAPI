using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbmailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BLogCreateDate { get; set; }
        public int ClickCount { get; set; } = 0;
        public bool BlogStatus { get; set; } = true;
        public int CategoryID { get; set; }
        public int UserID { get; set; }
    }
}
