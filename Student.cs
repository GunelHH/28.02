using System;
namespace _28._02
{
    class Student
    {
        public  string Groupno;
        public int Age;
        public static string Name;
        public static string Surname;

        public string FullName
        {
            get
            {
                return FullName;
            }
            set
            {
                value = Name + Surname;
            }
        }

        public Student(string fullname,string name,string surname,string groupno,int age)
        {
            Name = name;
            Surname = surname;
            FullName = fullname; 
            Groupno = groupno;
            Age = age;
        }
       
        public  string GetGroupNo()
        {
            for (int i = 0; i < Groupno.Length; i++)
            {
                if(Groupno.Length == 4)
                        
                {
                    char.IsUpper(Groupno[0]);
                    char.IsDigit(Groupno[1]);
                    char.IsDigit(Groupno[2]);
                    char.IsDigit(Groupno[3]);
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin");
                }
               
            }
            return Groupno;
        }
        public static  string GetFullName()
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (char.IsUpper(Name[0]))
                {
                    
                }
                else
                {
                    Console.WriteLine("Ilk herfi boyuk qeyd edin");
                }
            }
            for (int i = 0; i < Surname.Length; i++)
            {
                if (char.IsUpper(Surname[0]))
                {

                }
                else
                {
                    Console.WriteLine("Ilk herfi boyuk qeyd edin");
                }
            }
            return $"{Name} {Surname}";
        }
        public static bool CheckGroupNo( string Groupno)
        {
            if (Groupno.Length==4 && char.IsUpper(Groupno[0]) && char.IsDigit(Groupno[1]) && char.IsDigit(Groupno[2]) && char.IsDigit(Groupno[3]))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //public static bool CheckFullname()
        //{
        //    if ()
        //    {

        //    }
        //}
    }

}
