using System.Net;

namespace Networkprogramming.Examples
{
    public class Dns01 : IRunnable
    {
        public string Name => "dns";
        public string Description => "도메인 이름으로 IP 주소를 조회합니다.";

        public void Run()
        {
            Console.WriteLine("=== DnsExample 실행 ===");
            var host = "www.google.com";
            var addresses = Dns.GetHostAddresses(host);
            foreach (var addr in addresses)
                Console.WriteLine(addr);
        }
    }
}
