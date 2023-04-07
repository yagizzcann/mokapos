using System;
using System.Collections.Generic;

namespace MokaPos.Response
{
  
    
    public class PaymentDetail
    {
        public int DealerPaymentId { get; set; }
        public int UserPosPaymentId { get; set; }
        public string UserPosPaymentUrl { get; set; }
        public string OtherTrxCode { get; set; }
        public string CardHolderFullName { get; set; }
        public string CardNumberFirstSix { get; set; }
        public string CardNumberLastFour { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public double RefAmount { get; set; }
        public string CurrencyCode { get; set; }
        public int InstallmentNumber { get; set; }
        public double DealerCommissionAmount { get; set; }
        public bool IsInternationalCard { get; set; }
        public bool IsThreeD { get; set; }
        public string Description { get; set; }
        public int PaymentStatus { get; set; }
        public int TrxStatus { get; set; }
        public string Software { get; set; }
        public string BuyerFullName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerGsmNumber { get; set; }
        public string BuyerEmail { get; set; }
        public string PointDistributionInformation { get; set; }
        public bool IsThreeDModel { get; set; }
        public int MdStatus { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public bool CanBeCanceled { get; set; }
    }

    public class PaymentTrxDetailList
    {
        public int DealerPaymentTrxId { get; set; }
        public int DealerPaymentId { get; set; }
        public string TrxCode { get; set; }
        public DateTime TrxDate { get; set; }
        public double Amount { get; set; }
        public int TrxType { get; set; }
        public int TrxStatus { get; set; }
        public int PaymentReason { get; set; }
        public int VoidRefundReason { get; set; }
        public string VirtualPosOrderId { get; set; }
        public string MokaResultCode { get; set; }
        public string MokaResultMessage { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string EffectiveDate { get; set; }
        public string ExtraRefNo { get; set; }
    }

    public class PaymentDetailResponse
    {
        public bool IsSuccessful { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public int ListItemCount { get; set; }
        public List<PaymentTrxDetailList> PaymentTrxDetailList { get; set; }
    }
}