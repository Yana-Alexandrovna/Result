<img src="https://media.giphy.com/media/3TVBLvxXJKSCujJgpe/giphy.gif" width="10px]"/>

# ЗАДАЧА:

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно  ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не  рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм выполнения задания: 

<ul><li> [x] Создать репозиторий на GitHub </li><li> 
- [x] Нарисовать блок-схему алгоритма </li><li> 
- [x] Снабдить репозиторий оформленным текстовым описанием решения (файл README.md) </li><li> 
- [x] Написать программу, решающую поставленную задачу </li><li>  
- [x] Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах) 

## Описание решения задания: 
  
void PrintArray(string[] array)  *Метод для вывода массива*    
{  
    for (int i = 0; i < array.Length; i++)  
    {  
        Console.Write($"{array[i]} ");  
    }  
    Console.WriteLine();  
}  

Console.Write("Введите количество элементов массива: "); *Ввод от пользователя*   
int sizearray = Convert.ToInt32(Console.ReadLine());   
string[] array = new string[sizearray];       *Массив пользователя*    
string[] arrayout = new string[sizearray];      *Массив для записи нового массива из старого*    
for (int i = 0; i < sizearray; i++)             *Запись в массив элементов*    
{  
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");  *Ввод от пользователя*    
    string element = Convert.ToString(Console.ReadLine());  
    array[i] = element;                                    *Запись в массив элемента*    
}  
Console.Write("Ваш массив: ");                 
PrintArray(array);                                     *Показываем пользователю его массив*    
int count = 0;  
    for (int i = 0; i < array.Length; i++)        *Проверяем элементы массива на количество символов*    
    {  
    if(array[i].Length <= 3)  
        {  
        arrayout[count] = array[i];          *Если количество символов меньше или равное трем записываем в новый массив*    
        count++;  
        }  
    }  
Console.Write("Ваш новый массив: ");   
PrintArray(arrayout);                    *Показываем пользователю его новый массив*    
