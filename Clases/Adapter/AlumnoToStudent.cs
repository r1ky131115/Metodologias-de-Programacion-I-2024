using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases.Adapter
{
    public class AlumnoToStudent : Student
    {
        private IAlumno _al;
        public IAlumno alumno
        {
            get { return _al; }
            set { _al = value; }
        }

        public AlumnoToStudent(IAlumno alumno)
        {
            this._al = alumno;
        }

        public bool equals(Student student)
        {
            return _al.SosIgual(((AlumnoToStudent)student).alumno);
        }

        public string getName()
        {
            return _al.GetNombre();
        }

        public bool greaterThan(Student student)
        {
            return _al.SosMayor(((AlumnoToStudent)student).alumno);
        }

        public bool lessThan(Student student)
        {
            return _al.SosMenor(((AlumnoToStudent)student).alumno);
        }

        public void setScore(int score)
        {
            _al.SetCalificacion(score);
        }

        public string showResult()
        {
            return _al.MostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return _al.ResponderPregunta(question);
        }
    }
}