//常見資料型態變數

//字串 string""
//字元 char''
//整數  int
//浮點數 double
//布林值  bool


System.Console.WriteLine("Hello world!"); //字串 string""
System.Console.WriteLine('A'); //字元 char''
System.Console.WriteLine(2); //整數  int
System.Console.WriteLine(2.5); //浮點數 double
System.Console.WriteLine(true); //布林值  bool

string name = "小白";
char sex = 'M';
int age = 23;
double height = 182.3;
bool is_male = true;
System.Console.WriteLine("我的名字是" + name);
System.Console.WriteLine(name + "的性別是" + sex);
System.Console.WriteLine(name + age + "歲");
System.Console.WriteLine(name + height + "公分");
name = "bruce";
System.Console.WriteLine("英文名字是:" + name);


string phrase = "hello";
System.Console.WriteLine(phrase + "world!");

//字串常見用法
System.Console.WriteLine(phrase + "world!");

//換行 \n
System.Console.WriteLine(phrase + "\nworld!");

//雙引號 \"
System.Console.WriteLine(phrase + "\"world!\"");

string phrase2 = "hello world!";
string phrase3 = "HELLO WORLD!";
//0123456789
//計算字串長度 .Length
System.Console.WriteLine(phrase2.Length);

//讓字串都變成大寫 .Toupper()
System.Console.WriteLine(phrase2.ToUpper());

//讓字串都變成小寫 .ToLower
System.Console.WriteLine(phrase3.ToLower());

//判斷字串是否含有特定的詞句 .contains(特定詞句)
System.Console.WriteLine(phrase2.Contains("hello")); //回傳為true
System.Console.WriteLine(phrase2.Contains("bruce")); //回傳為false

//用位置找尋值 [位置]
System.Console.WriteLine(phrase2[0]);

//用值找位置 .Indexof
System.Console.WriteLine(phrase2.IndexOf("h"));
System.Console.WriteLine(phrase2.IndexOf("l"));//若找尋的值為重複的，則會回傳最先找到的位置
System.Console.WriteLine(phrase2.IndexOf("hello"));//若找尋字串，則會回傳該字串開頭的位置
System.Console.WriteLine(phrase2.IndexOf("bruce"));//若找尋的字串不存在，則回傳-1

//切割字串 .Substring(位置)
System.Console.WriteLine(phrase2.Substring(6));//從第六位開始切割
System.Console.WriteLine(phrase2.Substring(6, 3));//從第六位切割後，往後數三個位置
System.Console.WriteLine(phrase2 + phrase2 + phrase2);  
