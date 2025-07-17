using System.Net;

namespace Networkprogramming.Examples
{
    public class IPAddress01 : IRunnable
    {
        public string Name => "ip";
        public string Description => "문자열을 IPAddress 객체로 변환하고 정보 출력.";

        public void Run()
        {
            Console.WriteLine("=== IPAddressExample 실행 ===");
            var ip = IPAddress.Parse("8.8.8.8");
            Console.WriteLine($"AddressFamily: {ip.AddressFamily}");
            Console.WriteLine($"ToString(): {ip}");
        }
    }
}
