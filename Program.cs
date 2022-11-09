// Задайте массив сохраненных случайных чисел трехзначными числами.
// Напишите программу, которая показывает количество считанных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int [] CreateRandomArray (целый размер, int minValue, int maxValue)
{
    int[] myArray = новый int[size];
    для (int i = 0; i <size; i ++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    вернуть мой массив;
}
void showarray (int [] массив)
{
    Console.WriteLine("Получившийся массив -> ");
    для (int i = 0; i <array.length; i ++)
    {
        Console.write (массив [i] + "");
    }
}
int elementscount (int [] массив)
{
    количество счетчиков = 0;
    для (int i = 0; i <array.length; i ++)
    {
        if (массив [i] % 2 == 0)
        {
            количество++;
        }
    }
    количество возвратов;
}
Console.WriteLine("Ввести размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение элемента");
int min = convert.toint32 (console.readline ());
Console.WriteLine("Включить максимальное значение элемента");
int max = convert.toint32 (console.readline ());
int [] myarray = createrandomarray (a, min, max);
ПоказатьМассив(МойМассив);
int result = elementscount (myarray);
Console.WriteLine($"В этом массиве собраний {result} четных элементов");
*/

// Задайте одномерный массив, заполненный случайными числами.
// Видимое количество элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray (целый размер, int minValue, int maxValue)
{
    int[] myArray = новый int[size];
    для (int i = 0; i <size; i ++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    вернуть мой массив;
}
void showarray (int [] массив)
{
    Console.WriteLine("Получившийся массив -> ");
    для (int i = 0; i <array.length; i ++)
    {
        Console.write (массив [i] + "");
    }
}
недействительным ElementsCount (массив int [])
{
    
    целая суммарезультата = 0;
    для (int i = 0; i <array.length; i ++)
    {
        if(i % 2 != 0)sumresult += array[i];
    
    }
    Console.WriteLine($"сумма чисел в нечетных индексах ->{sumresult}");
}
Console.WriteLine("Ввести размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение элемента");
int min = convert.toint32 (console.readline ());
Console.WriteLine("Включить максимальное значение элемента");
int max = convert.toint32 (console.readline ());
int [] myarray = createrandomarray (a, min, max);
ПоказатьМассив(МойМассив);
Количество элементов (мой массив);
*/

// Задайте массив зарегистрированных чисел. Внешний вид между максимальным и наличием элементов массива.

// [3 7 22 2 78] -> 76


int [] CreateRandomArray ( размер int  , int minValue , int maxValue )  
{
    int [] myArray  =  новый  int [ размер ];
    для ( int  я  =  0 ; я  <  размер ; я ++ )
    {
        myArray [ i ] =  новый  случайный (). Далее ( minValue , maxValue  +  1 );
    }                                                                                                               
    вернуть  мой массив ;
}
недействительным  ShowArray ( массив int [] )
{
    Консоль . WriteLine ( " Полученный массив -> " );
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        Консоль . Написать ( массив [ i ] +  "  " );
    }
}
недействительным  ElementsCount ( массив int [] )
{
    инт  cиферка  =  0 ;
    целое  максимальное число  =  0 ;
     интервал  минум =  0 ;
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        если ( массив [ i ] >  максимальное число )
        {
            максимальное число  =  массив [ я ];
            
            если ( массив [ 1 ] <  minnum ) minnum  =  массив [ i ];
        }
        иначе  minnum  =  массив [ i ];

        ciferka  =  maxnum  -  minnum ;

    
    }
    Консоль . WriteLine ( $" разница между максимальным и реализацией -> { ciferka } " );
}
Консоль . WriteLine ( " Введите массив размера " );
int  а  =  конвертировать . ToInt32 ( Консоль.ReadLine ( ) ) ;
Консоль . WriteLine ( " Введите размерное значение элемента " );
int  мин  =  конвертировать . ToInt32 ( Консоль.ReadLine ( ) ) ;
Консоль . WriteLine ( " Введите максимальное значение элемента " );
int  max  =  Конвертировать . ToInt32 ( Консоль.ReadLine ( ) ) ;
int [] myArray  =  CreateRandomArray ( a , min , max );
ПоказатьМассив ( мойМассив );
ЭлементовСчетчик ( мойМассив );