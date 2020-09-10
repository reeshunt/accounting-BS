using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingWeb.Models
{
    public class UserRights
    {
        public int UserRightsID { get; set; }

        public int? UserID { get; set; }

        public int? Tag { get; set; }

        public int? FirmID { get; set; }

        public bool? IsRequire { get; set; }

        public int? AcYearID { get; set; }

        public bool IsAddReq { get; set; }

        public bool IsEditReq { get; set; }

        public bool IsDeleteReq { get; set; }

        public bool IsPrintReq { get; set; }

        public bool IsViewReq { get; set; }

        public int? FormsID { get; set; }

        public int? BookID { get; set; }

        public int? BookTypeID { get; set; }

        public string DisplayCaption { get; set; }

    }
}
