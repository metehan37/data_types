namespace data_types;
class Program
{
    static void Main(string[] args)
    {
        byte b = 5;     //1 byte
        sbyte c =5;     //1 byte

        short s =5;     //2 byte
        ushort us = 5;  //2 byte

        Int16 i16= 2 ;  //2 byte
        int i = 2;      //4 byte
        Int32 i32=2;    //4 byte
        Int64 i64=5;    //8 byte

        uint ui= 2 ;    //4 byte
        long l=4;       //8 byte
        ulong ul=4;     //8 byte

        //reel sayılar
        float f= 5;     //4 byte
        double d=5;     //8 byte
        decimal de=5;   //16 byte

        char ch ='2';    //2 byte
        string str ="Mete";//sınırsız

        bool b1=true;
        bool b2=false;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1 ="s";
        object o2 ='1';
        object o3 = 3;
        object o4= 5.2;

        //string ifadeler

        string str1=string.Empty;
        str1= "Metehan Metinoğlu";
        string ad = "Metehan";
        string soyad = "Metinoğlu";
        string fullname=ad + " "+ soyad;

        //integer tanımlama

        int integer1 =2;
        int integer2=3;
        int integer3= integer1 + integer2;

        //boolean

        bool b12= 5<3;

        //Değişken Dönüşümleri

        string str20 ="20";
        int int20 = 20;
        string yenideger = str20 +int20.ToString();
        Console.WriteLine(yenideger); //2020

        int int21= int20 + Int16.Parse(str20);
        Console.WriteLine(int21);//40

        int int22 = int20 + Convert.ToInt16(str20);
        Console.WriteLine(int22);

        //datetime
        string datetime1= DateTime.Now.ToString("dd.MM.yyyy");
        string datetime2= DateTime.Now.ToString("dd/MM/yyyy");

        string datetime3= DateTime.Now.ToString("HH.mm");

        Console.WriteLine(datetime1);
        Console.WriteLine(datetime2);
        Console.WriteLine(datetime3);
    }
}
