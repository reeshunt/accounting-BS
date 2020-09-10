using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingWeb.Models
{
    public class ucs_users
    {
        [Key]
        public int userID { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public bool IsAdmin { get; set; }

        public int AppTypeID { get; set; }

        public bool? IsAppTheme { get; set; }

        public string AppThemeName { get; set; }

        public int? AppColour { get; set; }

        public int? AppGridColour { get; set; }

        public int? AppAltnateColour { get; set; }

        public int? NoOfDaysEdit { get; set; }

        public int? SiteID { get; set; }

    }

}
