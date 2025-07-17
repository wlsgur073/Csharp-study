using System.Buffers;
using System.Reflection;

namespace Networkprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 모든 IRunnable 구현체 찾기
            var examples = Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(t => typeof(IRunnable).IsAssignableFrom(t) &&
                                               !t.IsInterface && !t.IsAbstract)
                                   .Select(t => (IRunnable)Activator.CreateInstance(t)!)
                                   .ToList();

            // 메뉴 출력
            Console.WriteLine("실행할 예제를 선택하세요:");
            for (int i = 0; i < examples.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {examples[i].Name} - {examples[i].Description}");
            }

            Console.Write("번호 입력: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= examples.Count)
            {
                Console.Clear();
                examples[choice - 1].Run();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            Console.WriteLine("\n엔터를 눌러 종료합니다...");
            Console.ReadLine();
        }
    }
}
