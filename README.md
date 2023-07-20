# Winform Clock
### 협동로봇 SI교육 C# Team Project

C#을 이용한 시계 만들기 프로젝트

## Function
1. Alarm
2. Stopwatch
https://www.notion.so/0555e4babe114529936647aaf34f82a9?pvs=4#9ad11a19f0b54702908787ba4c5317f2

- start 클릭 : 원 내부에 위치한 스톱워치가 ui가 실행 (hh:mm:ss 형태)
- stop 클릭 : 원 내부에 위치한 스톱워치가 정지(일시정지. stop 상태에서 start 누르면 재작동)
- record 클릭 : 현재 작동하고 있는 스톱워치의 기록을 저장하는 별도의 공간(listBox : Lap(1등, 2등 ~) / Time(측정된 기록) / Run time(스톱워치가 작동한 전체 시간)
- reset 클릭 : 스톱워치가 초기상태(00:00:00)로 돌아가고 동시에 listBox에 기록된 내용들 전부 초기화
   
4. calendar
5. ..?

## Error
Visual Studio 파일은 인터넷 또는 제한 영역에 있거나 파일에 웹 표시가 있으므로 처리할 수 없습니다.
1. Window PowerShell(관리자)
2. gci -Recurse "C:\workspaces" | Unblock-File
