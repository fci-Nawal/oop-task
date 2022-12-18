using System;
namespace nawal;
public class person{

	public string Name;
	public int Age;
	public person(string name;int age){
		this.Name=name;
		this.Age=age;
	}
	public virtual void Print(){
		Console.WriteLine($"My name is{name},my age is{age}");
	}  
}
public class student:person{
	public int Year;
	public float Gpa;
	public student(string name,int age,int year,float gpa){
		this.Year=year;
		this.Gpa=gpa;
	}
	public override void Print(){
		Console.WriteLine($"My name is{name},my age is{age},my gpa is{gpa}");
	}
}
public class Databass{
	public person[] pepole = new person[50];
	private int currentIndex=0;
	public void AddStudent(Student std){
		people[currentIndex++]=std;
	}
		public void AddStaff(Staff staff){
			people[currentIndex++]=staff;
		}
		public void AddPerson(Person person){
			people[currentIndex++]=person;
		}
		public void PrintAll(){
			for(int i=0;i<=currentIndex;i++){
				People[i].Print();
			}

		}
}
public class Staff:Person{
	public double Salary;
	public int JoinYear;
	public Staff(string name,int age,double salary,int joinyear){
		Salary=salary;
		JoinYear=joinyear;
	}
	public override void Print(){
		Console.WriteLine($"My name is{name},my age is{age},my salary is{salary}");
	}
}
public class Program{
private static void main(){
	Console.WriteLine("enter a number 1)student 2)staff 3)print all peaple 4)person \"not a student and not a staff\"");
    int x=1;
    var database=new Database();
    while (x!=0)
    {
        Console.Write("Option: ");
        x=Convert.ToInt32(Console.ReadLine());
        switch (x)
    {
        case 1:
        Console.Write("Name: ");
        var name=Console.ReadLine();
        Console.Write("Age: ");
        var age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        var year =Convert.ToInt32(Console.ReadLine());
        Console.Write("Gpa: ");
        var gpa = Convert.ToSingle(Console.ReadLine());
            var student =new Student(name,age,year,gpa);
            database.AddStudent(std);
        break;
        case 2:
        Console.Write("Name: ");
        name=Console.ReadLine();
        Console.Write("Age: ");
        age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Salary: ");
        var salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("JoinYear: ");
        var joinyear = Convert.ToInt32(Console.ReadLine());
            var staff =new Staff(name,age,salary,joinyear);
            database.AddStaff(staff);
        break;
        case 3:
            database.PrintAll();
        break;
                
        case 4:
        Console.Write("Name: ");
        name=Console.ReadLine();
        Console.Write("Age: ");
        age =Convert.ToInt32(Console.ReadLine());
            var person=new Person(name,age);
            database.AddPerson(person);
        break;
                
        default:
        return;
    }
    }

}
}
