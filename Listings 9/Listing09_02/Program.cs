using System;
// Класс со свойством:
class MyClass
{
    // Закрытые целочисленные поля:
    private int first;
    private int last;
    // Контруктор с двумя аргументами:
    public MyClass(int a, int b)
    {
        first = a;  // Значение первого поля
        last = b;   // Значение второго поля
    }
    // Переопределение метода ToString():
    public override string ToString()
    {
        // Формирование текстового значения:
        string txt = "Поля объекта: ";
        txt += first + " и " + last;
        // Результат метода:
        return txt;
    }
    // Целочисленное свойство:
    public int number
    {
        // Метод вызывается при считывании значения свойства:
        get
        {
            // Запоминается значение второго поля:
            int t = last;
            // Новое значение второго поля:
            last = first;
            // Новое значение первого поля:
            first = t;
            // Значение свойства:
            return t;
        }
        // Метод вызывается при присваивании
        // значения свойству:
        set
        {
            // Новое значение второго поля:
            last = first;
            // Присваивание значения первому полю:
            first = value;
        }
    }
}
// Класс с главным методом:
class MorePropsDemo
{
    // Главный метод:
    static void Main()
    {
        // Создание объекта:
        MyClass obj = new MyClass(1, 9);
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
        // Проверка значения свойства:
        Console.WriteLine("Свойство number: {0}", obj.number);
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
        // Присваивание значения свойству:
        obj.number = 5;
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
        // Проверка значения свойства:
        Console.WriteLine("Свойство number: {0}", obj.number);
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
        // Проверка значения свойства:
        Console.WriteLine("Свойство number: {0}", obj.number);
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
        // Присваивание значения свойству:
        obj.number = 3;
        // Проверка значений полей объекта:
        Console.WriteLine(obj);
    }
}