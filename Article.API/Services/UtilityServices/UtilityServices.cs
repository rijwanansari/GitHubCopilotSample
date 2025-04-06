using System.Text;
using Blog.API.Model;
namespace Blog.API.Services.UtilityServices;

public class UtilityServices
{
    public void SortNumbers(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }

    public void DisplaySortedNumbers()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 100000; i++)
        {
            numbers.Add(new Random().Next(0, 1000000));
        }

        SortNumbers(numbers);

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static int Fibonacci(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    public void ProcessFile(string filePath)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                StringBuilder sb = new StringBuilder();

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if (word.Length > 0)
                        {
                            sb.Append(word.ToUpper());
                            sb.Append(" ");
                        }
                    }
                }

                File.WriteAllText("ProcessedFile.txt", sb.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n);
        }
    }

    public int WhatIsMax(List<int> nums)
    {
        if (nums.Count == 0)
        {
            return int.MinValue;
        }

        int max = nums[0];
        foreach (var num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }

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