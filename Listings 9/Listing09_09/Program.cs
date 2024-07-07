using System;
// Класс с индексатором:
class MyClass
{
    // Закрытое целочисленное поле:
    private int number;
    // Конструктор с одним аргументом:
    public MyClass(int n)
    {
        // Присванивание значения полю:
        number = n;
    }
    // Целочисленный индексатор с целочисленным индексом:
    public int this[int k]
    {
        // Метод вызывается при считывании значения выражения
        // с проиндексированнным объектом:
        get
        {
            // Целочисленная переменная:
            int n = number;
            // "Отбрасывание" цифр из младших разрядов:
            for(int i = 1; i < k; i++)
            {
                n /= 10;
            }
            // Значение свойства:
            return n % 10;
        }
    }
}
// Класс с главным методом:
class WithoutSetIndexerDemo
{
    // Главный метод:
    static void Main()
    {
        // Создание объекта:
        MyClass obj = new MyClass(12345);
        // Цифры в денсятичном представлении числа:
        for(int k = 1; k < 9; k++)
        {
            Console.Write(" | " + obj[k]);
        }
        Console.WriteLine(" |");
    }
}