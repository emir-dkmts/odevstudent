using System.Reflection.Metadata;

Student student = new Student();
student.Name ="Allahsız";
student.Surname = "Buğra";
student.Age = 23;
student.Field = "Topal Eşşek Ticareti";
student.Languages = "Dat Net";
student.Num = 9061235;
student.Foreignlanguage = true;
student.Address = "Babacım İnşallah Cad. Aynen Abi Öyle Bişey :D:D Mah. Yeter Sok. Melikşah Apt. ";

Console.WriteLine(student);

Student student2 = new Student("Mert Emin", "Emin", 23, "Topal Eşşeklik", "Dat Net", 9071253,true,"Nurtepe Mah. yeter kime sorsanız gösterir ;)))");

StudentManager studentAdmin = new StudentManager();

Console.WriteLine(student2);

Student student3 = new Student("Asım", "K", 15, "Profesyonel Tefeci", "C sharp", 300210, false, " "); 

studentAdmin.Add(student3);







class Student
{
    public Student()
    {

    }

    public Student(string name, string surname, int age, string field, string languages, int num, bool foreignlanguage, string address)
    {
        Name = name;
        Surname = surname;
        Age= age;
        Field = field;
        Languages = languages;
        Num= num;
        Foreignlanguage = foreignlanguage;
        Address = address;

    }

    public string Name;
    public string Surname;
    public int Age;
    public string Field;
    public string Languages;
    public int Num;
    public bool Foreignlanguage;
    public string Address;

    public void Print()
    {
        Console.WriteLine($"Öğrenci Adı: {Name}");
        Console.WriteLine($"Öğrenci Soyadı: {Surname}");
        Console.WriteLine($"Öğrenci Yaşı: {Age}");
        Console.WriteLine($"Öğrenci Alanı: {Field}");
        Console.WriteLine($"Öğrenci Programlama Dilleri: {Languages}");
        Console.WriteLine($"Öprencinin Numarası: {Num}");
        Console.WriteLine($"Öğrenci Yabancı Dil Biliyor Mu ?: {Foreignlanguage}");
        Console.WriteLine($"Öğrencinin Adresi: {Address}");
    }

    public override string ToString()
    {
        return $"Adı: {Name}, Soyadı: {Surname}, Yaşı: {Age}, Alanı: {Field}, Programlama Dilleri: {Languages}," +
        $"Numarası: +{Num}, Yabancı Dil Biliyor Mu ?: {Foreignlanguage} , Adresi:  {Address}";
    }
}

class StudentManager
{
    public void Add(Student student)
    {
        if (student.Name.Length < 2 && student.Surname.Length < 2)
        {
            Console.WriteLine("Öğrencinin adı ve soyadı minimum 2 karakterli olmalıdır.");
            return;
        }

        if (student.Languages.Length < 1)
        {
            Console.WriteLine("Öğrenci En az bir programlama dili bilmelidir.");
            return;
        }

        if (student.Age < 18 || student.Age > 35)
        {
            Console.WriteLine("Öğrencinin Yaş Kriterleri Zortladı.");
            return ;
        }

        if (!NumStartsWith906(student.Num))
        {
            Console.WriteLine("Öğrenci Numarası 906 ile başlamalıdır.");
            return;
        }

        if (string.IsNullOrEmpty(student.Address))
        {
            Console.WriteLine("Adres kısmı zorunludur.");
            return ;
        }

        Console.WriteLine("Öğrenci Eklendi !");
        student.Print();
        Console.WriteLine("********************");

    }

    private bool NumStartsWith906(int num)
    {
        return num.ToString().StartsWith("906");
    }


    public void Remove(Student student)
    {
        Console.WriteLine("Öğrenci Silindi !");
        student.Print();
        Console.WriteLine("*********************");
    }

    public void Update(Student student)
    {
        if (student.Name.Length < 2 && student.Surname.Length < 2)
        {
            Console.WriteLine("Öğrencinin adı ve soyadı minimum 2 karakterli olmalıdır.");
            return;
        }

        if (student.Languages.Length < 1)
        {
            Console.WriteLine("Öğrenci En az bir programlama dili bilmelidir.");
            return;
        }

        if (student.Age < 18 || student.Age > 35)
        {
            Console.WriteLine("Öğrencinin Yaş Kriterleri Zortladı.");
            return;
        }

        if (string.IsNullOrEmpty(student.Address))
        {
            Console.WriteLine("Adres kısmı zorunludur.");
            return;
        }

        Console.WriteLine("Öğrenci Güncellendi !");
        student.Print();
        Console.WriteLine("********************");
    }

}