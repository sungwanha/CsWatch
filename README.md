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


## Prerequisites

- https://github.com/sungwanha/CsWatch --> code에 download.zip 다운로드  

### Starting the program

Watch.exe 더블클릭.

<img width="400px" src="https://github.com/sungwanha/CsWatch/assets/139833681/e33ddc1e-468f-49fd-8026-42dae91139a4" align="center" alt="GitHub Readme Stats" /> 


**초기 실행 방화벽으로 위 창이 나옴.** 
**추가 정보 클릭**


<img width="400px" src="https://github.com/sungwanha/CsWatch/assets/139833681/b86aff8b-f04a-47ca-8887-002065c50bcb" align="center" alt="GitHub Readme Stats" /> 


**실행 클릭.** 


## Clock Function


###  프로그램 상단에 RealTime 표시

1. Alarm

  **좌측 상단 기능 TAP에서 알람 선택**

- 알람 설정 클릭 : 알람 설정창에 원하는 날짜, 시간 입력 후 설정 클릭.
                  설정 완료되면 가운데 알람 시간 확인. 
  
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
- 오늘 날자에 스케줄이 있으면 시간 아래에 자동으로 표시

4. Memo

  **좌측 상단 기능 TAP에서 캘린더 TAP 선택**

- 메모 입력 : 메모창에 간단단 메모를 입력하면 자동으로 저장됨
- 메모 저장 : 프로그램을 끄더라도 작성한 메모는 사라지지 않음

**Option**

  **좌측 상단 옵션 TAP에서 테마 TAP 선택**

- 색깔 선택 : 배경 색을 5가지 색으로 변경할 수 있음.



## program process & describe code.

 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/97cc1ade-bf7c-4862-8964-35ed534107f1" align="center" alt="GitHub Readme Stats" /> 

```
WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseData);

                        // 날씨 정보 출력
                        string weatherdata = $"{weatherData.Weather[0].Description}";
                        string tempdata = $"{weatherData.Main.Temp}°C";
                        string humiddata = $"{weatherData.Main.Humidity}%";
                        string citydata = $"{weatherData.Name}";
                        string winddata = $"{weatherData.Wind.Speed} m/s";
                        TempLabel.Text = tempdata;
                        Weatherlabel.Text = weatherdata;
                        HumidLabel.Text = humiddata;
                        CityLabel.Text = citydata;

private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeLabel.Text = currentTime.ToString("hh:mm:ss tt"); // 현재 시간 표시
            DateLabel.Text = currentTime.ToString("yyyy-MM-dd"); // 현재 날짜 표시
        }
```
- openweather의 api를 이용한 날씨 값 받아오기
- interval 1000(1초)의 타이머 tick 이벤트 생성, 현재시간 불러오기



 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/39f147e6-7394-4d6d-a7ec-d818a42fd5da" align="center" alt="GitHub Readme Stats" /> 
 
```
private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            if (cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute && flag == 1)
            {
                flag = 0;
                MessageBox.Show("Alarm!!!!!");
                
            }
            
        }
```
- interval 60000(1분)의 타이머 tick 이벤트 생성
- 현재시간과 알람시간 비교후 일치하면 알람창.show



 <img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/e748ff7e-a58b-48b0-87d0-2891fec1a8b5" align="center" alt="GitHub Readme Stats"  />

```

private void Timer_Tick(object sender, EventArgs e)
{
    // 경과 시간을 타이머 Interval 만큼 더해줌
    elapsedTime = elapsedTime.Add(TimeSpan.FromMilliseconds(timer.Interval));
    
    // UpdateTimeLabel 메서드를 호출하여 경과 시간을 UI에 업데이트
    UpdateTimeLabel();
}

// start 기능 실행
private void StartBtn_Click(object sender, EventArgs e)
{
  
    if (!isRunning)  // isRunning : 타이머의 실행 여부 확인
    {
        timer.Start();
        isRunning = true;
    }
}

// stop 기능 실행
private void StopBtn_Click(object sender, EventArgs e)
{
    
    if (isRunning)   // isRunning : 타이머의 실행 여부 확인
    {
        timer.Stop();
        isRunning = false;
    }
}

// record 기능 실행
private void RecordBtn_Click(object sender, EventArgs e)
{
  
    if (isRunning)   // isRunning : 타이머의 실행 여부 확인
    {
        // 경과 시간을 포맷에 맞춰 문자열로 변환
        string lapTime = elapsedTime.ToString(@"mm\:ss\:ff");

        // 현재 랩 획수가(등수를 의미) 5 이하면 "합격", 아니면 "불합격"으로 lapResult 변수에 문자열 설정
        string lapResult = lap_count <= 5 ? "합격" : "불합격";

        // 기록 리스트 박스에 현재 랩의 정보를 추가
        listBox1.Items.Add($"LAP{this.lap_count} {lapTime} - {lapResult}");
    }
    
    // record 누를 때마다 랩 횟수 lap_count를 1 증가
    this.lap_count++;
}

// 리셋 버튼 클릭(기록 초기화)
private void ResetBtn_Click(object sender, EventArgs e)
{
    // 타이머를 정지하고, 상태를 isRunning으로 설정
    timer.Stop();
    isRunning = false;
    
    // 경과 시간을 초기화
    elapsedTime = TimeSpan.Zero;

    // 경과 시간을 UI에 업데이트
    UpdateTimeLabel();

    // 기록 리스트 박스를 비우고 랩 횟수를 1로 초기화
    listBox1.Items.Clear();
    lap_count = 1;
}
```


<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/15edc64c-0a63-47e3-b139-cd7f6c829781" align="center" alt="GitHub Readme Stats" />

```

class Calander
        {
            string[] schedule_time; // 스케쥴이 담긴 일정을 저장해주는 배열 
            string[] schedule_info;// 일정에 대한 상세 스케쥴 내용을 저장하는 배열
            int last_schedule; // 위 배열의 크기를 저장(insert를 하기 위함)
            string Path; // 저장용 텍스트 파일의 경로
            public Calander(string path) // 클래스 생성자 : 객체 생성시에 자동으로 실행
            {
                this.Path = path;
                this.schedule_time = new string[100];
                this.schedule_info = new string[100];
                this.last_schedule = 0;
                if (!File.Exists(Path))// 초기에 저장용 텍스트 파일이 파일 내부에 없을 시 텍스트 파일을 생성
                {
                    File.Create(Path).Close();
                }
            }
            public void Load()// 프로그램을 시작할 때 저장용 텍스트 파일에서 데이터를 불러와
                              // 클래스 객체의 내부 변수에 정리,저장하는 함수
            {
                string[] textValue = System.IO.File.ReadAllLines(this.Path);
                if (textValue.Length > 0)
                {
                    for (int i = 0; i < textValue.Length; i++)
                    {
                        string[] words = textValue[i].Split(',');
                        this.schedule_time[last_schedule] = words[0];
                        this.schedule_info[last_schedule] = words[1];
                        this.last_schedule++;
                    }
                }
            }
            public void Delete_File(string select_time)// 저장용 텍스트 파일에서 데이터가 중복되서 들어가지 않도록 삭제해주는 함수 
            {
                string[] textValue = System.IO.File.ReadAllLines(this.Path);
                int num = Search(select_time);
                if (num >= 0)
                {
                    for (int i = num; i < textValue.Length - 1; i++)
                    {
                        textValue[i] = textValue[i + 1];
                    }
                    List<string> stringlist = new List<string>(textValue);
                    stringlist.RemoveAt(stringlist.Count - 1);
                    textValue = stringlist.ToArray();
                    System.IO.File.WriteAllLines(this.Path, textValue);
                }
            }
            public void Insert(string select_time, string info)// 클래스 내부변수 및 텍스트 파일에 스케줄을 저장하는 함수
            {
                this.schedule_time[last_schedule] = select_time;
                this.schedule_info[last_schedule] = info;
                string message = select_time + "," + info + "\n";
                System.IO.File.AppendAllText(this.Path, message);
                this.last_schedule++;
            }
            public int Search(string select_time)//시간객체 입력을 받으면 저장된 일정에 해당시간이 있는 지 파악하고
            {                                        //일정이 있으면 저장된 배열의 해당 순서 반환, 없으면 -1 반환
                int result = -1;
                for (int i = 0; i < this.last_schedule; i++)
                {
                    if (this.schedule_time[i] == select_time)
                    {
                        result = i;
                        break;
                    }
                }
                return result;
            }
            public string Search_info(string select_time)// 날짜에 맞는 스케줄 일정을 반환하는 함수
            {
                int num = Search(select_time);
                if (num >= 0)
                {
                    return this.schedule_info[num];
                }
                else
                {
                    return "";

                }
            }
            public void Delete(string select_time)// 시간을 넣으면 그 시간에 담긴 일정을 객체 내부변수에서 삭제하는 함수
            {
                int num = Search(select_time);
                if (num >= 0)
                {
                    for (int i = num; i < this.last_schedule - 1; i++)
                    {
                        this.schedule_time[i] = this.schedule_time[i + 1];
                        this.schedule_info[i] = this.schedule_info[i + 1];
                    }
                    this.last_schedule--;
                }
            }
        }
        
```
- 캘린더는 위의 클래스를 통해 데이터를 관리하여 동작할 수 있도록 코드를 제작함.
- Calender_Panel.cs 파일에 들어있는 해당 클래스는 달력에서 사용자가 선택한 날짜와 해당 패널이 추가적으로 띄우는 ScheduleForm.cs창에서 받아오는 스케줄 일정을 종합해 데이터를 배열화하여 저장함. 
- 저장한 데이터는 캘린더에서 일정 표시 등 다양한 기능에 사용됨


 
<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/6ba97985-9013-4bcc-ac7c-1e3f53ed2a89" align="center" alt="GitHub Readme Stats" />

```
        private void InitializeTextValue()// 초기 파일 생성 및 파일 불러오기
        {
            if (!File.Exists(path))
            {
                // If testtext.txt does not exist, create an empty file.
                File.WriteAllText(path, "");
            }

            string textValue = File.ReadAllText(path);
            richTextBox1.Text = textValue;
        }

        private void TextPanel_Load(object sender, EventArgs e) // 이미 저장되어 있는 텍스트 파일 로드
        {
            InitializeTextValue();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)// richTextBox 컨트롤의 텍스트가 수정될 시
                                                                         // 텍스트 파일에 수정된 텍스트를 저장하는 함수
        {
            File.WriteAllText(path, richTextBox1.Text);
        }
```
- 메모장 패널의 기능은 크게 3가지로 나뉜다.
1. 초기에 저장용 텍스트 파일이 없을 시 텍스트 파일을 생성하는 기능(InitializeTextValue())
2. 이미 저장되어 있는 텍스트 파일을 불러와 패널의 richTextBox 컨트롤에 띄우는 기능(TextPanel_Load())
3. 사용자에 의해 richTextBox 컨트롤의 텍스트가 수정될 시 이를 이벤트로 인식하여 자동으로 텍스트 파일에 수정된 텍스트를 저장하는 기능(richTextBox1_TextChanged())

<img width="300px" src="https://github.com/sungwanha/CsWatch/assets/139833681/b0e45fb6-a8d8-4880-90c9-f11da5a6831a" align="center" alt="GitHub Readme Stats" />

```

```
- 델리게이트를 통한 이벤트 생성, 
- 각 패널과 버튼을 public화 시켜 접근 할 수 있도록 설정
- Theme의 버튼에 할당되어있는 이미지로 BackGroundImage 변경



## Information

**개발기간 : 23.07.18 ~ 21**


## Error
 
