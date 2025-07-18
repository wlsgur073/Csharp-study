using System.Net.Sockets;
using System.Text;

namespace Networkprogramming.Examples
{
    internal class Client01 : IRunnable
    {
        public string Name => "tcp-client";
        public string Description => "TcpClient로 메시지 전송 예제";
        public void Run() 
        {
            TcpClient client = new TcpClient("localhost", 7);
            NetworkStream ns = client.GetStream();
            Console.WriteLine("=== TcpClientExample 클라이언트 실행 ===");
            byte[] buffer = new byte[1024];
            byte[] sendMessage = Encoding.ASCII.GetBytes("Hello, Server!");
            ns.Write(sendMessage, 0, sendMessage.Length);
            int totalCount = 0, readCount = 0;

            while (totalCount < sendMessage.Length)
            {
                readCount = ns.Read(buffer, 0, buffer.Length);
                if (readCount == 0) break; // 서버가 연결을 종료한 경우
                totalCount += readCount;

                string recvMessage = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(recvMessage);
            }

            Console.WriteLine($"받은 바이트 수: {readCount}, 총 바이트 수: {totalCount}");
            ns.Close();
            client.Close();
        }
    }
}
