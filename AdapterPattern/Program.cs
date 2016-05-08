using DatabaseConcreteImplementationProject;
using System;
using System.Collections.Generic;
using ThirdPartyCRMApplication;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var crmApplication = new CRMApplication(new CRMPersistent());
            crmApplication.DoImportantJobs();
        }
    }

public class CRMPersistent : MyDataLayer, ICRMPersistent
{
    public IEnumerable<ICRMCustomer> GetCustomers()
    {
        var users = this.GetUsers();
        var crmCustomers = new List<CrmCustomer>();

        foreach (var user in users)
        {
            var crmCustomer = new CrmCustomer()
            {
                CustomerName = user.UserName,
                CustomerEmailAddress = user.UserEmailAddress
            };
            crmCustomers.Add(crmCustomer);
        }

        return crmCustomers;
    }
}
public class CrmCustomer : ICRMCustomer
{
    public string CustomerEmailAddress { get; set; }

    public string CustomerName { get; set; }
}
}
