using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GLS
{
    /// <summary>
    /// The GLS AuthServer service is responsible for handling front end authentication requests and managing authentication tickets for clients. It is consumed by the game launcher and provides profile and subscription information.
    /// </summary>
    [WebService(Namespace = "http://www.turbine.com/SE/GLS", Description = "The GLS AuthServer service is responsible for handling front end authentication requests and managing authentication tickets for clients. It is consumed by the game launcher and provides profile and subscription information.", Name = "Global Login System Authentication Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service : System.Web.Services.WebService
    {

        /// <summary>
        /// Authenticates the supplied user credentials. If the supplied username and password are verified by the back-end billing system, this method will return an authentication ticket that can be used to hand off authentication status to other services (such as the game server) as well as a user profile that describes the subscriptions available to this user. Unsuccessful authentication attempts will cause an exception to be thrown which may contain information from the billing system. If that happens, either the username does not exist, or the password was incorrect. The authentication ticket that is returned is valid for a fixed period of time. If it is necessary to maintain an authentication context for longer than a few minutes, the RefreshTicket method should be used to obtain an extended ticket.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="additionalInfo"></param>
        /// <returns></returns>
        [WebMethod(Description = "Authenticates the supplied user credentials. If the supplied username and password are verified by the back-end billing system, this method will return an authentication ticket that can be used to hand off authentication status to other services (such as the game server) as well as a user profile that describes the subscriptions available to this user. Unsuccessful authentication attempts will cause an exception to be thrown which may contain information from the billing system. If that happens, either the username does not exist, or the password was incorrect. The authentication ticket that is returned is valid for a fixed period of time. If it is necessary to maintain an authentication context for longer than a few minutes, the RefreshTicket method should be used to obtain an extended ticket.")]
        public UserProfile LoginAccount(String username, String password, String additionalInfo)
        {
            UserProfile result = new UserProfile();
            GameSubscription gameSubscription = new GameSubscription();
            gameSubscription.Game = "LOTROEU";
            gameSubscription.Name = "1234567";
            gameSubscription.Description = "I HAVE NO IDEA";
            gameSubscription.ProductTokens = new String[] { "AngmarEBPre", "AngmarTrial" };
            gameSubscription.ExpirationDate = "1/1/2010";
            gameSubscription.Status = "Active";
            gameSubscription.NextBillingDate = "1/1/2010";
            gameSubscription.PendingCancelDate = "";
            gameSubscription.AutoRenew = "TRUE";
            gameSubscription.BillingSystemTime = "1/2/2010 12:12:12 AM";
            result.Subscriptions = new GameSubscription[] { gameSubscription };
            result.Ticket = "z1V5/QWoRh8L+tLVgGWqth1YcOx6Tb8ZxMREJwNdswx/7BBmpE8DygrfjtRfn2BaRjsJBxAuJ7HSIj0z0YGZ5ZjxjCOo3cV/ixVGWAXFrHXhIwstvuEdTlnIA3HArPO3qlSIf8BLJ+xmXrrfSXTz/9q8uRyhPIifmvvacXNeQTroOKTkMMRHlHLLZUQ2Oi2DwYH3JJq4jkkv8epsN9I0BZsuJ/CKHHnsUzIwi/SSgLGlJiB+XyQ2sp3K7y3G7Nsp";
            return result;
        }

        /// <summary>
        /// Refreshes an authentication ticket. If a valid ticket is presented, this method will return another ticket that is valid for an extended period of time. This mechanism can be used to keep an authentication context valid for the full period of a user's contact with Turbine services. An exception will be thrown if the ticket cannot be renewed for any reason. In particular, an expired ticket will cause a TicketExpiredException to be thrown. If that happens, a Call to LoginAccount will be necessary to re-authenticate the account.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        [WebMethod(Description = "Refreshes an authentication ticket. If a valid ticket is presented, this method will return another ticket that is valid for an extended period of time. This mechanism can be used to keep an authentication context valid for the full period of a user's contact with Turbine services. An exception will be thrown if the ticket cannot be renewed for any reason. In particular, an expired ticket will cause a TicketExpiredException to be thrown. If that happens, a Call to LoginAccount will be necessary to re-authenticate the account.")]
        public String RefreshTicket(String ticket)
        {
            return ticket;
        }
    }
}
