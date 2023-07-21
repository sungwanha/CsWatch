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

- 알람감

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
 
