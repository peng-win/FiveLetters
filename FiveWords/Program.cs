// See https://aka.ms/new-console-template for more information

Console.WriteLine("Добро пожаловать в игру!");
Console.WriteLine();
Console.WriteLine("Вам нужно отгадать слово, состоящее из пяти букв");
Console.WriteLine("Если буква стоит на нужном месте - она выделяется зеленым цветом");
Console.WriteLine("Если буква есть в слове, но стоит не на своем месте - она выделяется желтым цветом");
Console.WriteLine("Если буквы в слове нет - она останется белой");

List<string> Words = new List<string>();

//Слова, которые нужно угадать
Words.Add("аборт");
Words.Add("авеню");
Words.Add("автор");
Words.Add("агент");
Words.Add("адрес");
Words.Add("азарт");
Words.Add("азиат");
Words.Add("актер");
Words.Add("актив");
Words.Add("акула");
Words.Add("акция");
Words.Add("алиби");
Words.Add("алмаз");
Words.Add("ангар");
Words.Add("ангел");
Words.Add("анонс");
Words.Add("аорта");
Words.Add("арбуз");
Words.Add("ареал");
Words.Add("арена");
Words.Add("арест");
Words.Add("атака");
Words.Add("багаж");
Words.Add("балет");
Words.Add("балка");
Words.Add("банан");
Words.Add("басня");
Words.Add("бегун");
Words.Add("белка");
Words.Add("белок");
Words.Add("берег");
Words.Add("бетон");
Words.Add("билет");
Words.Add("бирка");
Words.Add("блюдо");
Words.Add("бобер");
Words.Add("богач");
Words.Add("бомба");
Words.Add("бочка");
Words.Add("бровь");
Words.Add("бокал");
Words.Add("букет");
Words.Add("булка");
Words.Add("буран");
Words.Add("бутон");
Words.Add("буфет");
Words.Add("вагон");
Words.Add("валет");
Words.Add("вальс");
Words.Add("варан");
Words.Add("варяг");
Words.Add("веник");
Words.Add("венок");
Words.Add("весна");
Words.Add("ветка");
Words.Add("волна");
Words.Add("война");
Words.Add("виток");
Words.Add("висок");
Words.Add("выход");
Words.Add("вьюга");
Words.Add("вызов");
Words.Add("гроза");
Words.Add("говор");
Words.Add("гамма");
Words.Add("десна");
Words.Add("донос");
Words.Add("дымка");
Words.Add("егерь");
Words.Add("еврей");
Words.Add("есаул");
Words.Add("жираф");
Words.Add("жабры");
Words.Add("желоб");
Words.Add("жилье");
Words.Add("запас");
Words.Add("загон");
Words.Add("зефир");
Words.Add("завод");
Words.Add("игрок");
Words.Add("изъян");
Words.Add("испуг");
Words.Add("крыша");
Words.Add("кивок");
Words.Add("каток");
Words.Add("кость");
Words.Add("ковер");
Words.Add("лампа");
Words.Add("линия");
Words.Add("лейка");
Words.Add("масло");
Words.Add("мойка");
Words.Add("мафия");
Words.Add("налог");
Words.Add("наука");
Words.Add("обряд");
Words.Add("обгон");
Words.Add("паста");
Words.Add("пират");
Words.Add("парик");
Words.Add("петух");
Words.Add("рулон");
Words.Add("радио");
Words.Add("схема");
Words.Add("сачок");
Words.Add("свист");
Words.Add("товар");
Words.Add("табло");
Words.Add("тесть");
Words.Add("тупик");
Words.Add("узник");
Words.Add("уклон");
Words.Add("ферзь");
Words.Add("факир");
Words.Add("хиппи");
Words.Add("хомут");
Words.Add("хмель");
Words.Add("хруст");
Words.Add("цапля");
Words.Add("цифра");
Words.Add("часть");
Words.Add("честь");
Words.Add("череп");
Words.Add("чепец");
Words.Add("чугун");
Words.Add("шасси");
Words.Add("шайка");
Words.Add("шатун");
Words.Add("шланг");
Words.Add("щетка");
Words.Add("щиток");
Words.Add("щепка");
Words.Add("этнос");
Words.Add("эмаль");
Words.Add("эпоха");
Words.Add("юрист");
Words.Add("юниор");
Words.Add("юноша");
Words.Add("ясень");
Words.Add("ягода");
Words.Add("ягуар");
//140 слов

Random wordNumber = new Random();

int random = 0;

for (int i = 0; i < 1; i++)
{
    random = wordNumber.Next(0, 139);
}

//string theWord = (Words[random]);
string theWord = "пират";

Console.WriteLine();
Console.WriteLine("Введите слово");
Console.WriteLine();

string answer = Convert.ToString(Console.ReadLine());

char[] letterAnswer = answer.ToCharArray();
char[] letterWord = theWord.ToCharArray();

int count = 0;

for (int i = 0; i < 5; i++)
{
    if (letterAnswer[i] == letterWord[i])
    {
        count += 1;
    }
}

if (count == 5)
{
    Console.WriteLine("Вы выиграли!");
}

//if (answer == theWord)
//{
//    Console.WriteLine("fdffd");
//}
//else if ((letterAnswer[0] == letterWord[1] || letterAnswer[0] == letterWord[2] || letterAnswer[0] == letterWord[3] || letterAnswer[0] == letterWord[4]) && letterAnswer[0] != letterWord[0])
//{
//    Console.WriteLine("ddd");
//}

Console.ReadLine();


//private void BtnEnter_Click(object sender, RoutedEventArgs e)
//{
//    int random = 0;
//    string theWord = (Words[random]);

//    if (TxtBox00.Text != null && TxtBox01.Text != null && TxtBox02.Text != null && TxtBox03.Text != null && TxtBox04.Text != null)
//    {
//        string a = TxtBox00.Text;
//        string b = TxtBox01.Text;
//        string c = TxtBox02.Text;
//        string d = TxtBox03.Text;
//        string f = TxtBox04.Text;

//        string aa = theWord[0].ToString();
//        string bb = theWord[1].ToString();
//        string cc = theWord[2].ToString();
//        string dd = theWord[3].ToString();
//        string ff = theWord[4].ToString();

//        if (a == aa)
//        {

//        }

//        if (a == aa && b == bb && c == cc && d == dd && f == ff)
//        {
//            MessageBox.Show(null);
//        }

//    }
//}
