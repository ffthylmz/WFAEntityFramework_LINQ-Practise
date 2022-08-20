using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEntity200822A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Query Söz Dizmi ile LINQ ;
            //5'ten küçük sayıları bir listeye çekelim.

            var bestenKucukSayilarQ = from sayi in sayilar where sayi < 5 select sayi;

            //Method söz dizimi ile LINQ

            var bestenKucukSayilarM = sayilar.Where(sayi => sayi < 5);

            //LINQ kullanmadan çekme

            List<int> bestenKucukSayilarL = new List<int>();

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 5)
                {
                    bestenKucukSayilarL.Add(sayilar[i]);
                }
            }

            foreach (var item in sayilar)
            {
                if (item < 5)
                {
                    bestenKucukSayilarL.Add(item);
                }
            }

            List<string> liste = new List<string>()
            {
                "masa",
                "sandalye",
                "kitap",
                "kalem",
                "makas",
                "makam",
                "usul"
            };

            List<string> mIcerenler = liste.Where(l => l.Contains("m")).ToList();

            List<string> mIcermeyenler = (from l in liste where !(l.Contains("m")) select l).ToList();


            int[] numbers = { 0, 1, 2, 3, 4 };

            var sonuc1 = numbers.FirstOrDefault(s => s == 7);
            // var sonuc2 = numbers.First(s => s == 7);
            var sonuc3 = numbers.SingleOrDefault(s => s == 7);
            //var sonuc4 = numbers.Single(s => s == 7);


            List<Student> students = new List<Student>();

            students.Add(new Student { Id = 1, Name = "Ramesh", Surname = "Hamedani", Age = 25 });
            students.Add(new Student { Id = 21, Name = "John", Surname = "Rivers", Age = 24 });
            students.Add(new Student { Id = 3, Name = "john", Surname = "Wilson", Age = 33 });

            //Student selectedStudent = students.FirstOrDefault(s => s.Name == "Robert");
            //Student selectedStudent2 = students.First(s => s.Name == "Robert");
            //Student selectedStudent3 = students.LastOrDefault(s => s.Name == "John");

            //ID'YE GÖRE SIRALAYALIM VE YENİ LİSTEYE AKTARALIM;
            students.OrderBy(s => s.Id).ToList();
            List<Student> orderedStudentList = students.OrderBy(s => s.Id).ToList();
            List<Student> orderedStudentList2 = students.OrderBy(s => s.Surname).ToList();
            List<Student> orderedStudentList3 = students.OrderByDescending(s => s.Surname).ToList();

            //İsimlerine göre sırala, sonra isimleri aynı olanları yaşlarına göre azalan olarak sırala.
            List<Student> specificList=students.OrderBy(s=>s.Name).ThenByDescending(s => s.Age).ToList();

            //Yaşların Toplamlarını Bulalım, SUM() ile daha kısa şekilde yapalım;
            int sumOfAges = students.Sum(s => s.Age);  // çözümü tek satırda hallettik.

            int total = 0;       
            foreach (var item in students)
            {
                total += item.Age;
            }
            
            //ID lerin ortalamalarını bulunuz.
            double avgOfID = students.Average(s => s.Id);

            //Min yaşı bulalım. MIN();
            int minOfAge = students.Min(s => s.Age);

            //Max yaşı bulalım. MAX();
            int maxOfAge = students.Max(s => s.Age);


        }
    }
}
