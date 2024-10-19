using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Teacher
    {
        private Collection students;

        public Teacher()
        {
            students = new ListOfStudent();
        }

        public void setStudents(Collection _students)
        {
            students = _students;
        }

        public void goToClass(Student student)
        {
            students.addStudent(student);
        }

        public void teachingAClass()
        {
            Student student;
            IteratorOfStudent iterator = students.getIterator();

            // Pasar lista
            Console.WriteLine("\nGood morning\n");
            Console.WriteLine("I'm going to take attendance");
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                Console.WriteLine("\t" + student.getName() + " is present");
                iterator.next();
            }
            Console.WriteLine("\n");

            // tomar examen
            Console.WriteLine("I'm going to take an exam");
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                takeAnExam(student);
                iterator.next();
            }
            Console.WriteLine("\n");

            // mostrar resultado
            Console.WriteLine("Exam results");
            students.sort();
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                Console.Write(student.showResult() + "\n");
                iterator.next();
            }
        }

        private void takeAnExam(Student student)
        {
            int hit = 0;
            for (int i = 0; i < 10; i++)
            {
                int answer = student.yourAnswerIs(i);
                if (answer == i % 3)
                    hit++;
            }
            student.setScore(hit);

            Console.WriteLine("\t" + student.getName() + "'s score is " + hit.ToString());
        }
    }

    internal class ListOfStudent : Collection
    {
        private List<Student> list = new List<Student>();

        public IteratorOfStudent getIterator()
        {
            return new ListOfStudentIterator(list);
        }

        public void addStudent(Student student)
        {
            list.Add(student);
        }

        public void sort()
        {
            list.Sort(new StudentComparer());
        }
    }

    internal class ListOfStudentIterator : IteratorOfStudent
    {
        private List<Student> list;
        private int index;

        public ListOfStudentIterator(List<Student> _list)
        {
            list = _list;
        }

        public void beginning()
        {
            index = 0;
        }

        public bool end()
        {
            return index >= list.Count;
        }

        public Student current()
        {
            return list[index];
        }

        public void next()
        {
            index++;
        }
    }

    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.equals(s2))
                return 0;
            else
            if (s1.lessThan(s2))
                return 1;
            else
                return -1;
        }
    }
}
