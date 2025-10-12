using System;
public class StudentClass {
    public string Name {get; set;}
    
    public StudentClass(string name) {
        Name = name;
    }
    
    public void StudentNames() {
        Console.WriteLine($"Student 1: {Name}");
    }
}

public class Program {
    public static void  Main(string[] args) {
        StudentClass student1 = new StudentClass("Jay");
        student1.StudentNames();
    }
} 