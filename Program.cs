using System;

namespace Dron
{
    class Program
    {
        //Wykorzystane wzorce:
        //
        //Fabryka prosta - fabryka dronow
        //Budowniczy - klasy w folderze budowniczy
        //Adapter - klasy w folderze Adapter
        //Pełnomocnik - folder Pełnomocnik

        static void Main(string[] args)
        {
            Operator.uruchom();
        }
    }
}
