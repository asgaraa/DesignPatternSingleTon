
using DesignPatternSingleton;

//Singleton
var numbers = Enumerable.Range(0, 10);

Parallel.ForEach(numbers, i =>
{
    var sng = Singleton.GetInstance;
    sng.Registered();
});

//multithreading





MultiTheread fromTeachaer = MultiTheread.Instance;
fromTeachaer.PrintDetails("From Teacher");
MultiTheread fromStudent = MultiTheread.Instance;
fromStudent.PrintDetails("From Student");


//Parallel.Invoke(
//               () => PrintTeacherDetails(),
//               () => PrintStudentdetails()
//               );
//Console.ReadLine();
        
// static void PrintTeacherDetails()
//{
//    MultiTheread fromTeacher = MultiTheread.GetInstance;
//    fromTeacher.PrintDetails("From Teacher");
//}
// static void PrintStudentdetails()
//{
//    MultiTheread fromStudent = MultiTheread.GetInstance;
//    fromStudent.PrintDetails("From Student");











//Singleton fromTeachaer = Singleton.GetInstance;
//fromTeachaer.PrintDetails("From Teacher");
//Singleton fromStudent = Singleton.GetInstance;
//fromStudent.PrintDetails("From Student");
//Console.ReadLine();

//Singleton s1 = Singleton.GetInstance();
//Singleton s2 = Singleton.GetInstance();

//if (s1 == s2)
//{
//    Console.WriteLine("Singleton works, both variables contain the same instance.");
//}
//else
//{
//    Console.WriteLine("Singleton failed, variables contain different instances.");
//}