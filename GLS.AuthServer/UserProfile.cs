using System;

namespace GLS
{

    public class UserProfile
    {
        // FIXME: this is marked nillable="true", but not in the official service, might be solveable using XmlElementAttribute
        public GameSubscription[] Subscriptions { get; set; }
        public String Ticket { get; set; }
    }
}