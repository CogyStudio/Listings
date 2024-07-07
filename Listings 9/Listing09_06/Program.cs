using System;
// Класс со статическим свойством:
class Fibs
{
    // Закрытые целочисленные статические поля:
    private static int last = 1;
    private static int prev = 1;
    // Статическое целочисленное свойство:
    public static int number
    {
        // Метод вызывается при считывании значения свойства:
        get
        {
            // Локальная переменная:
            int res = prev;
            // Изменение значения статическиз полей:
            last = last + prev;
            prev = last - prev;
            // Значение свойства:
            return res;
        }
        // Метод вызывается при присваивании
        // значения свойству:
        set
        {
            // Начальное значение статических полей:
            prev = 1;
            last = 1;
            // Изменение значения статических полей:
            for(int k = 2; k <= value ; k++)
            {
                last = last + prev;
                prev = last - prev;
            }
        }
    }
}
// Класс с главным методом:
class StaticPropsDemo
{
    // Главный метод:
    static void Main()
    {
        // Отображение значения статического свойства:
        for(int k = 1; k <= 10; k++)
        {
            Console.Write("{0, 4}", Fibs.number);
        }
        Console.WriteLine();
        // Присваивание значения статическому свойству:
        Fibs.number = 6;
        // Отображение значения статического свойства:
        for(int k = 1; k <= 10; k++)
        {
            Console.Write("{0, 4}", Fibs.number);
        }
        Console.WriteLine();
        // Присваивание значения статическому свойству:
        Fibs.number = 1;
        // Отображение значения статического свойства:
        for (int k = 1; k <= 10; k++)
        {
            Console.Write("{0, 4}", Fibs.number);
        }
        Console.WriteLine();
    }
}