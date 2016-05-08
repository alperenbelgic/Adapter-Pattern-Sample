using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyCRMApplication
{
public class CRMApplication
{
    private ICRMPersistent CRMPersistent;

    public CRMApplication(ICRMPersistent crmPersistent)
    {
        this.CRMPersistent = crmPersistent;
    }

    public void DoImportantJobs()
    {
        // ...
        var customers = this.CRMPersistent.GetCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine(string.Format("Our Dear Customer: {0}", customer.CustomerName));
        }
    }
}

    public interface ICRMPersistent
    {
        IEnumerable<ICRMCustomer> GetCustomers();
    }

    public interface ICRMCustomer
    {
        string CustomerName { get; set; }
        string CustomerEmailAddress { get; set; }
    }
}
