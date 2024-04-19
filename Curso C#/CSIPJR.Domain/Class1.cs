namespace CSIPJR.Domain
{
    // una clase abstracta garantiza de que una clase no pueda ser accedida
    public abstract class Person
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public abstract void Save();

        public virtual void Load() 
        {
            Console.WriteLine("Cargando los datos ...");
        }

    }

    public interface IBaseEmployee
    {
        public DateTime HireDate { get; set; }
    }



    public class Student : Person
    {
        public DateTime EnrollmnetDate { get; set; }
        public override void Save()
        {
            Console.WriteLine("Guardando la informacion del estudiante");
        }
    }

    public class Instructor : Person, IBaseEmployee
    {
        public DateTime HireDate { get; set; }

        public override void Save()
        {
            Console.WriteLine();
        }
    }

    public class Employee : Person, IBaseEmployee
    {
        public DateTime HireDate { get; set; }
        public override void Save()
        {
            Console.WriteLine("Guardando la informacion del empleado");
        }
    }


    //cual es la diferecia entre un metodo abstracto y uno virtual?
    // el abstracto no tiene un comportamiento definido en cambio el virtual tiene un comportamiento


}