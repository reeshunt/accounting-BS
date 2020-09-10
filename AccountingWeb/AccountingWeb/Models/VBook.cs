using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingWeb.Models
{
    public class VBook
    {
        [Key]
        public int AcID { get; set; }

        public string AcName { get; set; }

        public int BBookID { get; set; }

        public string BookName { get; set; }

        public int MiscBookID { get; set; }

        public DateTime? AcLockFromDate { get; set; }

        public DateTime? AcLockToDate { get; set; }

        public string ShName { get; set; }

        public string ShName1 { get; set; }

        public string BookCode { get; set; }

        public string Add2 { get; set; }

        public string Add3 { get; set; }

        public string BankDetail { get; set; }

        public bool? BIsLedgerEffectReq { get; set; }

        public bool? IsTakaDetailReq { get; set; }

        public int? BBookDefineID { get; set; }

        public string BBookDefineName { get; set; }

        public bool? IsServiceBook { get; set; }

        public int? BMasterAcID { get; set; }

        public string BMasterAcName { get; set; }

        public string BookShName { get; set; }

        public int? PurposeID { get; set; }

        public bool? IsAutoBarcodeReq { get; set; }

        public string Pincode { get; set; }

        public int SubTransactionTypeID { get; set; }
        }
    }

