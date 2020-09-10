using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountingWeb.Models
{
    public class transmain
    {
        public int TransMainID { get; set; }

        public int MiscAcYearID { get; set; }

        public int FirmID { get; set; }

        public int BookID { get; set; }

        public int SubBookID { get; set; }

        public int AcID { get; set; }

        public int TransactionTypeID { get; set; }

        public string InwardNo { get; set; }

        public string InwardABC { get; set; }

        public DateTime? InwardDate { get; set; }

        public int BillNo { get; set; }

        public string BillNoMask { get; set; }

        public DateTime BillDate { get; set; }

        public string ChallanNo { get; set; }

        public DateTime? ChallanDate { get; set; }

        public int AgainstAcID { get; set; }

        public int? GenTaxationID { get; set; }

        public int? GenCheckByID { get; set; }

        public int? AgentAcID { get; set; }

        public int? GenItemDeptID { get; set; }

        public int? SupplierAcID { get; set; }

        public string SupplierBillNo { get; set; }

        public DateTime? SupplierBillDate { get; set; }

        public int? TransporterAcID { get; set; }

        public string LrNo { get; set; }

        public DateTime? LrDate { get; set; }

        public int? GenDstnID { get; set; }

        public string KSTNo { get; set; }

        public string CASENo { get; set; }

        public int? GenHasteID { get; set; }

        public int? GenThroughID { get; set; }

        public string remarks { get; set; }

        public double? TotalGrossAmt { get; set; }

        public double? TotalAddLessAmt { get; set; }

        public double? TotalNetAmt { get; set; }

        public bool IsOpening { get; set; }

        public int? TDSAcID { get; set; }

        public int? GenTDSTypeID { get; set; }

        public int? MiscTDSCalcOn { get; set; }

        public double? TDSPercentage { get; set; }

        public double? TDSAmount { get; set; }

        public double? TDSSurchargePer { get; set; }

        public double? TDSSurchargeAmt { get; set; }

        public double? TDSCessPer { get; set; }

        public double? TDSCessAmt { get; set; }

        public double? TDSTotalAmt { get; set; }

        public double? TotalPcs { get; set; }

        public double? TotalQty { get; set; }

        public int? DUeDays { get; set; }

        public int? LedgerMainID { get; set; }

        public int? TDSLedgerMainID { get; set; }

        public int? AgentLedgerMainID { get; set; }

        public int? TransporterLedgerMainID { get; set; }

        public bool? ocashcredit { get; set; }

        public int? LotNo { get; set; }

        public string LotNoAbc { get; set; }

        public int? GpNo { get; set; }

        public string GpNoAbc { get; set; }

        public int? USERID { get; set; }

        public DateTime? TRDTTIME { get; set; }

        public int? DlvAddAcID { get; set; }

        public int? Mcid { get; set; }

        public int? PurposeMiscID { get; set; }

        public double? Weigt { get; set; }

        public double? Freight { get; set; }

        public string supplierLrNo { get; set; }

        public string VehicleNo { get; set; }

        public int? GenDivisionID { get; set; }

        public string OrderNo { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? Qty4ReceipeID { get; set; }

        public int? QualID { get; set; }

        public int? FileColorID { get; set; }

        public string Form403 { get; set; }

        public int? StoreBookID { get; set; }

        public int? TransAdLesOpt { get; set; }

        public bool IsCashCreditReq { get; set; }

        public int? ExJvLedgerMainID { get; set; }

        public string Remarks1 { get; set; }

        public string Remarks2 { get; set; }

        public DateTime? BillDueDate { get; set; }

        public int? RateType { get; set; }

        public string xSaleno { get; set; }

        public bool? IsHoldBill { get; set; }

        public DateTime? DtBillDueDate { get; set; }

        public string BookingSt { get; set; }

        public double? AddLessPercentage { get; set; }

        public int? EntryModule { get; set; }

        public bool? IsAbcdDisReq { get; set; }

        public int? RTOLedgerMainID { get; set; }

        public int? RecLedgerMainID { get; set; }

        public double? RTOAmount { get; set; }

        public double? RecAmount { get; set; }

        public int? CommAcID { get; set; }

        public double? PurchaseAmt { get; set; }

        public double? CommAmt { get; set; }

        public int? CommLedgerMainID { get; set; }

        public double? RoundOffAmt { get; set; }

        public DateTime? ImportDate { get; set; }

        public double? CashAmt { get; set; }

        public double? ChequeAmt { get; set; }

        public int? BankAcID { get; set; }

        public int? ChequeLedgerMainID { get; set; }

        public int? SRTransMainID { get; set; }

        public string DlvDetail { get; set; }

        public string RDBatchNo { get; set; }

        public int? RDTransDetailID { get; set; }

        public int? IssTransMainID { get; set; }

        public bool? IsJob { get; set; }

        public bool IsExport { get; set; }

        public string xxHSNCode { get; set; }

        public string GstStatus { get; set; }

        public string EWAYBillNo { get; set; }

    }

}
