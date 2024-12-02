using System;

namespace THE_COOKY_APP.DTO
{
    internal class StudentClassDTO
    {
        public string StatusPayment { get; set; }        // Tương ứng với STATUS_PAYMENT
        public string FormPayment { get; set; }          // Tương ứng với FORM_PAYMENT
        public int CodeMemberDiscount { get; set; }      // Tương ứng với CODE_MEMBER_DISCOUNT
        public int VoucherDiscount { get; set; }         // Tương ứng với VOUCHER_DISCOUNT
        public int DealDiscount { get; set; }             // Tương ứng với DEAL_DISCOUNT
        public int AppDiscount { get; set; }              // Tương ứng với APP_DISCOUNT
        public int Cash { get; set; }                     // Tương ứng với CASH
        public int Quantity { get; set; }                 // Tương ứng với QUANTITY
        public int TotalPayment { get; set; }             // Tương ứng với TOTAL_PAYMENT
        public string IdClass { get; set; }               // Tương ứng với ID_CLASS
        public string IdStudent { get; set; }             // Tương ứng với ID_STUDENT
    }
}