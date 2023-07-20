<p align="center">
 <img width="150px" src="https://simage.mujikorea.net/goods/31/13/90/74/4550344275696_N_N_400.jpg" align="center" alt="GitHub Readme Stats" />
 <h2 align="center">협동로봇 SI교육</h2>
 <p align="center">C#으로 프로그램 만들기 </p>
  <p align="center">**조장 : 하성완 // 조원 : 길성룡,김준호,정재현 </p>
</p>

# Project Title

다양한 기능이 포함된 시계

## Project introduction

<p>"Simple is best" </p>
실생활에 필요한 기능을 간단히 하나의 프로그램으로 만들자. 

## Clock Function


###  프로그램 상단에 RealTime 표시

1. Alarm

  **좌측 상단 기능 TAP에서 알람 선택**

- 알람 설정 클릭 : 알람 설정창에 원하는 날짜, 시간 입력 후 설정 클릭.
                  설정 완료되면 가운데 알람 시간 확인. 
- 카운트 다운 기능 : 원하는 시, 분, 초 입력하면 0일 때 알람 울림.

  
2. Stopwatch
 
  **좌측 상단 기능 TAP에서 스탑워치 TAP 선택**
 
- start 클릭 : 원 내부에 위치한 스톱워치 UI 실행 
- stop 클릭 : 원 내부에 위치한 스톱워치가 정지
- record 클릭 : 현재 작동하고 있는 스톱워치의 기록을 저장하는 별도의 공간(listBox : Lap(1등, 2등 ~) / Time(측정된 기록)
- reset 클릭 : 스톱워치가 초기상태(00:00:00)로 돌아가고 동시에 listBox에 기록된 내용들 전부 초기화

3. Calendar

  **좌측 상단 기능 TAP에서 캘린더 TAP 선택**

- 달력 UI가 열림
- 스케줄 등록 : 특정 날짜에 스케줄을 등록할 수 있음
- 스케줄 수정 : 스케줄이 있는 날짜에 수정 가능.
- 스케줄 저장 : 프로그램을 끄더라도 파일 안의 텍스트 파일을 통해 데이터가 사라지지 않으며 프로그램 실행시 이전에 적어놓은 메모가 자동으로 불러와짐

4. Memo

  **좌측 상단 기능 TAP에서 캘린더 TAP 선택**

- 메모 입력 : 메모창에 간단단 메모를 입력하면 자동으로 저장됨
- 메모 저장 : 프로그램을 끄더라도 작성한 메모는 사라지지 않음

**Option**

  **좌측 상단 옵션 TAP에서 테마 TAP 선택**

- 색깔 선택 : 배경 색을 5가지 색으로 변경할 수 있음.


### Prerequisites

- https://github.com/sungwanha/CsWatch --> code에 download.zip 다운로드  


- Visual Studio 파일은 인터넷 또는 제한 영역에 있거나 파일에 웹 표시가 있으므로 처리할 수 없습니다.
  
   1. Window PowerShell(관리자) 열기
   
<img width="400px" src="https://github.com/sungwanha/CsWatch/assets/139833681/6406e77c-91f7-4e6e-869c-24d70931448c" align="center" alt="GitHub Readme Stats" /> 


   2. "gci -Recurse "C:\workspaces" | Unblock-File " 입력.
       ※ workspaces는 다운로드 폴더의 위치.

<img width="500px" src="https://github.com/sungwanha/CsWatch/assets/139833681/74f89d9a-f3df-432c-98ed-87f11538eb81" align="center" alt="GitHub Readme Stats" /> 


- Newtonsoft.Json 이 없습니다.

 1. 솔루션 탐색기 우클릭 -> 솔루션용 NuGet 패키지 관리 클릭

<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/b68e0c31-a2f1-4cb9-a687-df64ed4de2cb" />  
   
 2. 뜨는 창에서 찾아보기를 누른 뒤 Newtonsoft.Json 검색 후 설치

<img width="700px" src="https://github.com/sungwanha/CsWatch/assets/139833681/42f386ae-6859-43c9-b1d4-3e595fa0fbd1" />  


### Starting the program

Watch.exe 더블클릭.



## program process & describe code.

 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/97cc1ade-bf7c-4862-8964-35ed534107f1" align="center" alt="GitHub Readme Stats" /> 

```

```

 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/39f147e6-7394-4d6d-a7ec-d818a42fd5da" align="center" alt="GitHub Readme Stats" /> 
 
```

```

 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/95717a25-0883-43f8-834d-7b50d0797468" align="center" alt="GitHub Readme Stats"  />

```

```

<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/15edc64c-0a63-47e3-b139-cd7f6c829781" align="center" alt="GitHub Readme Stats" />

```

```

<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/6ba97985-9013-4bcc-ac7c-1e3f53ed2a89" align="center" alt="GitHub Readme Stats" />

```

```


<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/b0e45fb6-a8d8-4880-90c9-f11da5a6831a" align="center" alt="GitHub Readme Stats" />

```

```




## Information
## Error
 
