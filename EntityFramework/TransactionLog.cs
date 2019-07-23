//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionLog
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Day { get; set; }
        public int CurrencyID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> SourceEntityID { get; set; }
        public Nullable<int> DestinationEntityID { get; set; }
        public int TransactionTypeID { get; set; }
        public string arg1 { get; set; }
        public string arg2 { get; set; }
        public Nullable<int> SourceWalletID { get; set; }
        public Nullable<int> DestinationWalletID { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Entity Destination { get; set; }
        public virtual Entity Source { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Wallet Wallet { get; set; }
        public virtual Wallet Wallet1 { get; set; }
    }
}