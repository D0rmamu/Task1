using Task1.Namber1;
using Task1.Namber2;
using Task1.Namber3;
using Task1.Namber4;


//Address address = new Address();
//address.Index = 0;
//address.Country = "Россия";
//address.City = "Киров";
//address.Street = "Колотушкина";
//address.House = 1;
//address.Apartment = "A";
//Console.WriteLine($" Индекс дома-{address.Index}\n Страна-{address.Country}\n Город-{address.City}\n Улица-{address.Street}\n Номер дома-{address.House}\n Аппартаменты-{address.Apartment}");



//Rectangle rectangle = new Rectangle(1, 1);
//Console.WriteLine("Введите сторону 1");
//rectangle.side1=Convert.ToDouble( Console.ReadLine());
//Console.WriteLine("Введите сторону 2");
//rectangle.side2= Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Площадь: {0}, Периметр: {1}", rectangle.Area, rectangle.Perimeter);
//Thread.Sleep(3000);


//Book book =new Book();
//Title title= new Title();
//Author author= new Author();
//Content content= new Content();
//Console.WriteLine("Книга");
//book.Show();
//Console.WriteLine("Название");
//title.Show();
//Console.WriteLine("Автор");
//author.Show();
//Console.WriteLine("Содержание");
//content.Show();
class Program
{
    static void Main(string[] args)
    {
        Figure figure = new Figure("Нечто");
        Console.WriteLine($"Периметр многоугольника - {figure.CalculatePerimeter()}");
        Console.ReadKey();
    }
}