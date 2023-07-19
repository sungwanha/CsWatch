
// 스톱워치 코드_정재현(~7.18)


using System;

public class TimeObject
{
    private TimeSpan elapsedTime;               // 경과 시간을 저장하는 변수
    private DateTime startTime;                 // 시작 시간을 저장하는 변수
    private bool isRunning;                     // 스톱워치가 작동 중인지 여부를 나타내는 변수

    public TimeObject()
    {
        Reset();                                // TimeObject 인스턴스를 생성할 때 초기화를 수행하는 메서드 호출
    }

    public void Start()
    {
        if (!isRunning)                         // 스톱워치가 작동 중이 아닌 경우에만 실행
        {
            startTime = DateTime.Now - elapsedTime;     // 시작 시간 = 현재 시간 - 경과 시간
            isRunning = true;                           // 스톱워치를 작동 중으로 설정
            Console.WriteLine("스톱워치 작동시작");     // 작동 시작을 알리는 메시지 출력
        }
        else
        {
            Console.WriteLine("스톱워치가 이미 작동하고 있습니다.");    // 이미 작동 중인 경우 메시지 출력
        }
    }

    public void Stop()
    {
        if (isRunning)                                          // 스톱워치가 작동 중인 경우에만 실행
        {
            elapsedTime = DateTime.Now - startTime;             // 경과 시간 = 현재 시간 - 시작 시간
            isRunning = false;                                  // 스톱워치를 정지 상태로 설정
            Console.WriteLine("스톱워치 정지");                 // 정지를 알리는 메시지 출력
        }
        else
        {
            Console.WriteLine("스톱워치가 작동하지 않습니다.");    // 작동 중이 아닌 경우 메시지 출력
        }
    }

    public void Record()
    {
        if (isRunning)                                          // 스톱워치가 작동 중인 경우에만 실행
        {
            TimeSpan currentTime = DateTime.Now - startTime;                   // 현재 시간 - 시작 시간 = 현재 경과 시간
            Console.WriteLine("기록 시간: {0:hh\\:mm\\:ss}", currentTime);    // 경과 시간을 시간:분:초 형식으로 출력
        }
        else
        {
            Console.WriteLine("스톱워치가 작동하고 있지 않습니다. 시간을 기록할 수 없습니다.");    // 작동 중이 아닌 경우 메시지 출력
        }
    }


    public void Reset()
    {
        elapsedTime = TimeSpan.Zero;                    // 경과 시간을 0으로 초기화
        startTime = DateTime.Now;                       // 시작 시간을 현재 시간으로 설정
        isRunning = false;                              // 스톱워치를 정지 상태로 설정
        Console.WriteLine("스톱워치 리셋.");            // 리셋을 알리는 메시지 출력
    }
}

class Program
{
    static void Main(string[] args)
    {
        TimeObject stopwatch = new TimeObject();    // TimeObject 클래스의 인스턴스 생성

        while (true)                                // 무한 반복
        {
            Console.Write("명령을 입력해주세요 (start, stop, record, reset): ");   // 사용자로부터 명령 입력 요청
            string command = Console.ReadLine().ToLower();                                  // 입력된 명령을 소문자로 변환하여 저장

            switch (command)                                            // 명령에 따라 분기
            {
                case "start":
                    stopwatch.Start();                                  // 스톱워치 시작 메서드 호출
                    break;
                case "stop":
                    stopwatch.Stop();     // 스톱워치 정지 메서드 호출
                    break;
                case "record":
                    stopwatch.Record();   // 스톱워치 기록 메서드 호출
                    break;
                case "reset":
                    stopwatch.Reset();    // 스톱워치 리셋 메서드 호출
                    break;
                default:
                    Console.WriteLine("부정확한 명령입니다. 다시 입력해주세요.");    // 잘못된 명령일 경우 메시지 출력
                    break;
            }

            Console.WriteLine();    // 빈 줄 출력
        }
    }
}