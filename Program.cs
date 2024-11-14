
using SeleniumBot;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        var web = new AutomationWeb();
        web.testWeb();
    }
}