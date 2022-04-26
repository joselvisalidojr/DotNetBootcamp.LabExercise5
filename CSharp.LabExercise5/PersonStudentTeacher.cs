using System;

namespace CSharp.LabExercise5.Solution2
{

    class PersonStudentTeacher
    {
        public class Person
        {
            protected int age;
            public void Greet()
            {
                Console.WriteLine("Hello!");
            }
            public void SetAge(int n)
            {
                age = n;
            }
        }

        public class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is {0} years old", age);
            }
        }

        public class Teacher : Person
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        }
        public PersonStudentTeacher()
        {
            Console.Clear();
            string teacher = @"
                                                  
    **/                            ,(#%@@&@@@@    
 ,*,***,,                       (@,,#@@@@@@@@@@@& 
    *,,,,                       @&(,,,#,,,,/#@@@@&
    *,,,                        % (.,,,,,,&,@@@@@@
     *,,                       ,,,,,,,*%&,,,#@@@@@
      ...                    (%*,#,,,,,,,,,,*,*@@@
      . *.....              &&&%,,*,,,,,,,**/@@@@@
       .........              (&&/,,,**/%@&&@@@@@@
         ...........              ,,,,,@&@@@@@@@. 
           /.............            .            
              *......................             
                   .*..................           
                         ,,,,/.........           
                        #,,,,,........            
                         /,,,,.......             
             ,(/,,,**     (,,........             
            ***********.../,,........             
                  ,/*,,,,.,,,,........            
                         ..,,,.........           
                          /,,,,.........          
                         ,*,,,,,..........        
                         ##,,,,,,,........        
                         (%%%%%%%%%%%###(((#      
                         .%%%%%#########(((#      
                          #%%%%#########((        
                          %%%%%########*          
                          (%%%%####%.             
                          .%%%%%.                                                       
            ";
            Console.WriteLine(teacher);
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(19);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(28);
            myTeacher.Greet();
            myTeacher.Explain();

            Console.Write("\nPress any key to return...");
            Console.ReadKey();

            MainMenu myMainMenu = new MainMenu();
            myMainMenu.Start();
        }
    }
}