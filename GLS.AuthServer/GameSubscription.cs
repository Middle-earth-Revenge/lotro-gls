using System;

namespace GLS
{
    public class GameSubscription
    {
        public String Game { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String[] ProductTokens { get; set; }
        public String[] CustomerServiceTokens { get; set; }
        public String ExpirationDate { get; set; }
        public String Status { get; set; }
        public String NextBillingDate { get; set; }
        public String PendingCancelDate { get; set; }
        public String AutoRenew { get; set; }
        public String BillingSystemTime { get; set; }
        public String AdditionalInfo { get; set; }

    }
}