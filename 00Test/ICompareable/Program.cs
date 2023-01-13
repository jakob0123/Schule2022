using ICompareable;

Student stefan = new Student() { Firstname="Stefan",Lastname="Schwödiauer",Birthday= new DateTime(2005,3,28)};
Student gabriel = new Student() { Firstname="Gabriel",Lastname="Steinwander",Birthday = new DateTime(2005,3,29)};
Student florian = new Student() { Firstname = "Florian", Lastname = "Winkler", Birthday = new DateTime(2005, 3, 28) };

List<Student> students = new List<Student>();
students.Add(stefan);
students.Add(gabriel);
students.Add(florian);
students.Sort();

students.ForEach((s) => Console.WriteLine(s));

//foreach (Student s in students)
//{
//    Console.WriteLine(s);
//}

