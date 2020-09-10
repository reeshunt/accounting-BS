using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingWeb.Models
{
    public class firm
    {
        public int FirmID { get; set; }

        public string FirmName { get; set; }

        public string ShortFirmName { get; set; }

        public string Add1 { get; set; }

        public string Add2 { get; set; }

        public string Add3 { get; set; }

        public int? CityID { get; set; }

        public string Pincode { get; set; }

        public string PhoneNo1 { get; set; }

        public string PhoneNo2 { get; set; }

        public string PhoneNo3 { get; set; }

        public string FaxNo { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

        public string RegistrationNo { get; set; }

        public string CstNo { get; set; }

        public string GstNo { get; set; }

        public string EccNo { get; set; }

        public string RangeNo { get; set; }

        public string DivisionNo { get; set; }

        public string ItNo { get; set; }

        public string CommodityNo { get; set; }

        public string TdaNo { get; set; }

        public string Signature { get; set; }

        public string Commisionerate { get; set; }

        public int? Status { get; set; }

        public string UlNo { get; set; }

        public string PartnerName1 { get; set; }

        public string PartnerName2 { get; set; }

        public byte[] PartnerName3 { get; set; }

        public string DirectorName1 { get; set; }

        public string DirectorName2 { get; set; }

        public string FirmNameGuj { get; set; }

        public string add1Guj { get; set; }

        public string add2Guj { get; set; }

        public int? USERID { get; set; }

        public DateTime? TRDTTIME { get; set; }

        public string FBankName { get; set; }

        public string FIfscode { get; set; }

        public string FBankAcNo { get; set; }

        public int? FirmOpenDate { get; set; }

        public string FirmID4Stock { get; set; }

        public string FirmGSTNO { get; set; }

        public int? FirmStateID { get; set; }

        public string CINNO { get; set; }

        public string InvGstRule1 { get; set; }

    }
}
