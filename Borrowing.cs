using System.Security.Cryptography.X509Certificates;
using System;
public class Borrowing : Resource , IDownloadable
{
    
    int ReferenceNumber;
    string Userid;
    public DateTime StartDate;
    public DateTime EndDate;
    bool PickedUp;
    List<Resource> Resources;

    public Borrowing()
    {
    }

    
    public Borrowing(string Userid, List<Resource> resources)
    {
        this.Userid = Userid;
        this.Resources = resources;
    }

    
    public void ReturnResources(DateTime Time)
    {
        if(Time > EndDate)
        {
            Console.WriteLine("user must pay fine");
        }

        if(Time < EndDate)
        {
            Console.WriteLine("thank you");
        }

        PickedUp = true;
    }

    string IDownloadable.GenerateAccessLink()
    {
        return "Ajhbawsdhg";
    }
}