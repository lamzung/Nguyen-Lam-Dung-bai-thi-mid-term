using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_thi_mid
{
    internal class TestStudent 
    {
        //int i = 6;
        static student[] newStudents = new student[10];
        public static void getStudent()

        {
            string id, name, gender;
            int age;
            string dateOfBirth;
            string studentClass;
            double mark1, mark2, mark3;
           for (int i = 0; i < newStudents.Length; i++)
            {
                Console.WriteLine(newStudents[i]);
            }
        }

        public static void searchStudent(string name, student[] newStudents)
        {
            for(int i = 0; i < newStudents.Length; i++)
            {
                if (newStudents[i].Name == name)
                {
                    Console.WriteLine("Id cua student can tim kiem la: {0}", newStudents[i].Id);
                    Console.WriteLine("Gioi tinh cua student can tim kiem la: {0}", newStudents[i].Gender);
                    Console.WriteLine("Tuoi cua student can tim kiem la: {0}", newStudents[i].Age);
                    Console.WriteLine("Ngay sinh cua student can tim kiem la: {0}", newStudents[i].DateOfBirth);
                    Console.WriteLine("Lop hoc cua student can tim kiem la: {0}", newStudents[i].Class);
                    Console.WriteLine("Diem mon hoc 1 cua student can tim kiem la: {0}", newStudents[i].Mark1);
                    Console.WriteLine("Diem mon hoc 2 cua student can tim kiem la: {0}", newStudents[i].Mark2);
                    Console.WriteLine("Diem mon hoc 3 cua student can tim kiem la: {0}", newStudents[i].Mark3);
                }
            }
        }

        public static void rewrite(student studentRewrite)
        {
            int Case;
            string id, name, gender;
            int age;
            string dateOfBirth;
            string studentClass;
            double mark1, mark2, mark3;

            Console.WriteLine("Ban muon thay doi thong tin gi: ");
            Console.WriteLine("1. id");
            Console.WriteLine("2. name");
            Console.WriteLine("3. gioi tinh");
            Console.WriteLine("4. tuoi");
            Console.WriteLine("5. ngay sinh");
            Console.WriteLine("6. lop hoc");
            Console.WriteLine("7. mark 1: ");
            Console.WriteLine("8. mark 2: ");
            Console.WriteLine("9. mark 3: ");
            Case = Convert.ToInt32(Console.ReadLine());
            switch (Case)
            {
                case 1:
                    Console.WriteLine("Xin moi nhap id moi: ");
                    id = Console.ReadLine();
                    studentRewrite.Id = id;
                    break;
                case 2:
                    Console.WriteLine("Xin moi nhap ten moi: ");
                    name = Console.ReadLine();
                    studentRewrite.Name = name;
                    break;
                case 3:
                    Console.WriteLine("Xin moi nhap gioi tinh: ");
                    gender = Console.ReadLine();
                    studentRewrite.Gender = gender;
                    break;
                case 4:
                    Console.WriteLine("Xin moi nhap tuoi moi: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    studentRewrite.Age = age;
                    break;
                case 5:
                    Console.WriteLine("Xin moi nhap ngay sinh moi: ");
                    dateOfBirth = Console.ReadLine();
                    studentRewrite.DateOfBirth = dateOfBirth;
                    break;
                case 6:
                    Console.WriteLine("Xin moi nhap lop hoc moi: ");
                    studentClass = Console.ReadLine();
                    studentRewrite.Class = studentClass;
                    break;
                case 7:
                    Console.WriteLine("Xin moi nhap diem mon hoc 1: ");
                    mark1 = Convert.ToDouble(Console.ReadLine());
                    studentRewrite.Mark1 = mark1;
                    break;
                case 8:
                    Console.WriteLine("Xin moi nhap diem mon hoc 2: ");
                    mark2 = Convert.ToDouble(Console.ReadLine());
                    studentRewrite.Mark2 = mark2;
                    break;
                case 9:
                    Console.WriteLine("Xin moi nhap diem mon hoc 3: ");
                    mark3 = Convert.ToDouble(Console.ReadLine());
                    studentRewrite.Mark3 = mark3;
                    break;
            }
        }

        public static void delete(string id, student[] newStudents)
        {
            Console.WriteLine("Xin moi nhap so ID cua student muon xoa: ");
            id = Console.ReadLine();
            for(int i = 0; i < newStudents.Length; i++)
            {
                if (newStudents[i].Id == id)
                {
                    newStudents[i] = null;
                }
                else
                {
                    Console.WriteLine("Khong co student nao co id nhu the");
                }
            }

        }

        public static void sapXep(student[] newStudent)
        {
            student replace = null;
            for(int i = 0; i < newStudents.Length; i++)
            {
                for(int j = i; j < newStudents.Length; j++)
                {
                    if ((newStudents[j].Mark1 + newStudents[j].Mark2 + newStudents[j].Mark3)/3 
                        < (newStudents[i].Mark1 + newStudents[i].Mark2 + newStudents[i].Mark3) / 3)
                    {
                        replace = newStudents[j];
                        newStudents[j] = newStudents[i];
                        newStudents[i] = replace;
                    }
                }
            }

        }
    }
}
