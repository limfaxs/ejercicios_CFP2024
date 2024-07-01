using LibreriaDeStudiante;

namespace TesteoDeStudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstadoAcademico ev1 = new EstadoAcademico(new Alumno("1006", "Pedro", "Angulo"));
            ev1.SetMateria = new Materia("matematicas", 3);

            Console.WriteLine($"alumno: {ev1.Alumno}");
            Console.WriteLine("esta cursando");

            foreach (Materia item in ev1.Materias)
            {
                Console.WriteLine(item.Nombre);
            }

            //
            EstadoAcademico otra = new EstadoAcademico(new Alumno("1006", "Pedro", "Angulo"),new List<Materia>(), "abogacia");
            //
            EstadoAcademico otra2 = new EstadoAcademico(new Alumno(), new List<Materia>()); 


            //
            //Alumno alumno1 = new Alumno("1006", "Pedro", "Angulo");
            //
            // alumno1.Legajo = "1007";
            //Materia matematicas = new Materia("matematicas", 3);

           // Evaluacion ev1 = new Evaluacion(alumno1);

            //ev1.SetMateria = matematicas;

            //Console.WriteLine($"alumno")

            //
            //alumno1.NotaPrimerParcial = 8;
            //alumno1.SetNotaPrimerParcial(8);

            //Console.WriteLine(alumno1.Legajo);


            //Random rand = new Random();

            //List<Alumno> estudiantes = new List<Alumno>()
            //{
            //    new Alumno("1001", "Cuellar", "Pedro"),
            //    new Alumno("1002", "Pugo", "Jeremias"),
            //    new Alumno("1003", "Hidalgo", "Carlo"),
            //    new Alumno("1004", "Aguilar", "Jorge"),
            //    new Alumno("1005", "Puyol", "Jimy"),


            //};

            //foreach (Alumno a in estudiantes)
            //{
            //    a.SetNotaPrimerParcial(rand.Next(1, 10));
            //    a.SetNotaSegundoParcial(rand.Next(1, 10));
            //}

            //foreach (Alumno item in estudiantes)
            //{
            //    Console.WriteLine(item.mostrar());
            //}



            //Estudiante estudiante1 = new Estudiante("Alejo", "Rivera", "A01");
            //Estudiante estudiante2 = new Estudiante("Pedro", "Arakaqui", "A02");
            //Estudiante estudiante3 = new Estudiante("Ricardo", "Puyol", "A03");

            //estudiante1.SetNotaPrimerParcial(7);
            //estudiante1.SetNotaSegundoParcial(9);

            //estudiante2.SetNotaPrimerParcial(6);
            //estudiante2.SetNotaSegundoParcial(7);

            //estudiante3.SetNotaPrimerParcial(3);
            //estudiante3.SetNotaSegundoParcial(2);

            //Console.WriteLine(estudiante1.mostrar());
            //Console.WriteLine(estudiante2.mostrar());
            //Console.WriteLine(estudiante3.mostrar());

        }

    }
}
