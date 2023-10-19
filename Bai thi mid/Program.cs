using Bai_thi_mid;

public class Program
{
    static void Main(String[] args)
    {
        int Case;
        student[] newStudent = new student[10];
        string Id;
        string Name;
        string Gender;
        int Age;
        string DateOfBirth;
        string Class;
        double Mark1, Mark2, Mark3;

        Console.WriteLine("Please select an option: ");
        Console.WriteLine("===========================================");
        Console.WriteLine("1. Input information <input details for a student.");
        Console.WriteLine("2. Sorting student ascending by average mark");
        Console.WriteLine("3. Display all the student list");
        Console.WriteLine("4. Search student by Name");
        Console.WriteLine("5. Delete Student by Id");
        Console.WriteLine("6. Exit program");
        Console.WriteLine("===========================================");
        Console.Write("Option: ");
        Case = Convert.ToInt32(Console.ReadLine());
        
        switch (Case)
        {
            case 1:
                for(int i = 0; i < newStudent.Length; i++)
                {
                    Console.WriteLine("Id: ");
                    Id = Console.ReadLine();
                    Console.WriteLine("Ten: ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Gioi tinh: ");
                    Gender = Console.ReadLine();
                    Console.WriteLine("Tuoi: ");
                    Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ngay sinh: ");
                    DateOfBirth = Console.ReadLine();
                    Console.WriteLine("Lop: ");
                    Class = Console.ReadLine();
                    Console.WriteLine("Diem mon 1: ");
                    Mark1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Diem mon 2: ");
                    Mark2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Diem mon 3: ");
                    Mark3 = Convert.ToDouble(Console.ReadLine());
                    newStudent[i] = new student(Id, Name, Gender, Age, DateOfBirth, Class, Mark1, Mark2, Mark3); 
                }break;
            case 2:
                TestStudent.sapXep(newStudent);
                Console.WriteLine("Sau khi sap xep: ");
                for (int i = 0; i < newStudent.Length; i++)
                {
                    Console.WriteLine(newStudent[i]);
                }
                break;
            case 3:
                for (int i = 0; i < newStudent.Length; i++)
                {
                    Console.WriteLine(newStudent[i]);
                }
                break;
            case 4:
                string name;
                Console.WriteLine("xin moi nhap ten cua student: ");
                name = Console.ReadLine();
                TestStudent.searchStudent(name, newStudent);
                break;
            case 5:
                string id;
                Console.WriteLine("xin moi nhap Id cua student: ");
                id = Console.ReadLine();
                TestStudent.delete(id, newStudent);
                break;
            case 6:
                break;
        }

    }
}
