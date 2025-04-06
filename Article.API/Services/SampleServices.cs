using Blog.API.Infra.Data;
using Blog.API.Model;

namespace Blog.API.Services;

public class SampleServices
{
    public List<string> GetActiveUserEmails_Poor(List<User> users)
    {
        List<string> emails = new List<string>();
        foreach (var user in users)
        {
            if (user.IsActive)
            {
                emails.Add(user.Email);
            }
        }
        return emails;
    }

    public string GetGreetingMessage_Poor(string name)
    {
        string message = "Hello, " + name + ". Today is " + DateTime.Now.ToString("D") + ".";
        return message;
    }

    // public void PrintUserNames_Poor(List<int> userIds, ApplicationDbContext dbContext)
    // {
    //     foreach (var userId in userIds)
    //     {
    //         var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);
    //         Console.WriteLine(user?.Name);
    //     }
    // }

    // public void ProcessLogs(List<AuditLog> logs)
    // {
    //     foreach (var log in logs)
    //     {
    //         if (log.Type == "Login")
    //         {
    //             if (!string.IsNullOrEmpty(log.User))
    //             {
    //                 Console.WriteLine("User logged in: " + log.User);
    //             }
    //         }
    //         else if (log.Type == "DataChange")
    //         {
    //             if (log.Changes != null)
    //             {
    //                 Console.WriteLine("Data changed: " + string.Join(",", log.Changes));
    //             }
    //         }
    //         // other types...
    //     }
    // }

    //generate password hash
    



}
