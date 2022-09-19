// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// При написании программы опирался исключительно на программу обучения, кроме метода Replace и метода вывода в консоль через "[{0}]" - тут я обратился к поиску)
// Надеюсь я правильно понял условия задачи, а именно о формировании нового массива, а не простого вывода нужных элементов через цикл
// Не нашел решения вывода каждого элемента массива в кавычках
// Буду рад комментариям)



Console.Write("Введите число строк: ");
int size = Convert.ToInt32(Console.ReadLine()); //На этом этапе не нашел толкового решения на ввод не числа, нас этому не обучали...
string [] array = new string [size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите строку: ");
    string s = Console.ReadLine().Replace(" ", "");
    if(s != "")array[i] = s;
    else i--;
}
Console.Write("[{0}]", string.Join(", ", array));

string [] GetElementsMaxLength (string[]inpArray, int maxSymbols)
{
    int count = 0;
    int temp_i = 0;
    string [] emptyArray = new string [] { };
    for (int i = 0; i < inpArray.Length; i++) 
        {
            if (inpArray[i].Length <= maxSymbols) count++;
        }
    if (count == 0) return emptyArray;
    string [] resultArray = new string [count];
    for (int j = 0; j < inpArray.Length || temp_i < maxSymbols; j++)
    {
        if (inpArray[j].Length <= maxSymbols)
        {
            resultArray[temp_i] = inpArray[j];
            temp_i++;
        } 
    }
    return resultArray;
}
Console.WriteLine($" -> [{string.Join(", ", GetElementsMaxLength(array, 3))}]");