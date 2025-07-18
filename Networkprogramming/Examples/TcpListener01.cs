using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Networkprogramming.Examples
{
    internal class TcpListener01 : IRunnable
    {
        public string Name => "tcp_listener";
        public string Description => "TCP 리스너를 생성하고 클라이언트 연결을 기다립니다.";

        public void Run()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 7);
            tcpListener.Start();
            byte[] Buffer = new byte[1024];
            int totalBytesCount = 0, readByteCount = 0;

            Console.WriteLine("=== TcpListenerExample 서버 실행 ===");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();

            while(true)
            {
                readByteCount = ns.Read(Buffer, 0, Buffer.Length);
                if (readByteCount == 0) break; // 클라이언트가 연결을 종료한 경우

                totalBytesCount += readByteCount;
                ns.Write(Buffer, 0, readByteCount); // 클라이언트에게 받은 데이터를 그대로 돌려줌
                Console.WriteLine($"받은 바이트 수: {readByteCount}, 총 바이트 수: {totalBytesCount}");
                Console.WriteLine(Encoding.ASCII.GetString(Buffer));
            }

            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
