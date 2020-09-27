using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessRulesEngine.Models
{
    public class OrderDetails
    {        
        public bool Paymentsuccessful { get; set; }
        public Order OrderType { get; set; }
    }

    public enum Order
    {
        PhysicalProduct,
        Book,
        Membership,
        Video
    }

    public enum MembershipStatus
    {
        New,
        Upgrade
    }
}