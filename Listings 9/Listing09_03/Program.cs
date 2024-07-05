using System;
// Класс со свойством:
class MyClass
{
    // Открытые целочисленные поля:
    public int first;
    public int last;
    // Контруктор с двумя аргументами:
    public MyClass(int a, int b)
    {
        first = a;  // Значение первого поля
        last = b;   // Значение второго поля
    }
    // Целочисленное свойство (доступно только для чтения):
    public int sum
    {
        // Метод вызывается при считывании значения свойства:
        get
        {
            // Значение свойства:
            return first + last;
        }
    }
}
// Класс с главным методом:
class WithoutSetDemo
{
    // Главный метод:
    static void Main()
    {
        // Создание объекта:
        MyClass obj = new MyClass(1, 9);
        // Проверка значения свойства:
        Console.WriteLine("Сумма полей: " + obj.sum);
        // Присваивание значения полю:
        obj.first = 6;
        // Проверка значения свойства:
        Console.WriteLine("Сумма полей: " + obj.sum);
        // Присваивание значения полю:
        obj.last = 2;
        // Проверка значения свойства:
        Console.WriteLine("Сумма полей: " + obj.sum);
    }
}