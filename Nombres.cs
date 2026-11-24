using System;
class Program
{
    static void Main()
    {
      Random rd = new Random();
      string[] nombres = {
            "Juan", "Pedro", "Luis", "Carlos", "Jose",
            "Miguel", "Diego", "Angel", "Daniel", "Fernando",
            "Alejandro", "Jorge", "Ricardo", "Eduardo", "Andres",
            "Gabriel", "Rafael", "David", "Emilio", "Ivan",
            "Sofia", "Maria", "Ana", "Laura", "Valeria",
            "Camila", "Daniela", "Fernanda", "Andrea", "Lucia",
            "Paola", "Mariana", "Gabriela", "Regina", "Natalia",
            "Elena", "Isabella", "Renata", "Victoria", "Ximena",
            "Mateo", "Sebastian", "Santiago", "Nicolas", "Emmanuel",
            "Adrian", "Bruno", "Pablo", "Samuel", "Martin",
            "Alberto", "Arturo", "Oscar", "Hector", "Victor",
            "Diana", "Alejandra", "Claudia", "Patricia", "Monica",
            "Rosa", "Teresa", "Carolina", "Julia", "Amanda",
            "Alicia", "Elisa", "Irene", "Miriam", "Abril",
            "Esteban", "Rodrigo", "Axel", "Gael", "Leonardo",
            "Dario", "Marco", "Tomas", "Erick", "Alan",
            "Jimena", "Melissa", "Bianca", "Paulina", "Carla",
            "Zoe", "Luna", "Aitana", "Alma", "Clara",
            "Roberto", "Francisco", "Manuel", "Guillermo", "Ramon",
            "Julian", "Maximiliano", "Cristian", "Alex", "Noe"
        };
      string[] apellidos = {
            "Alvarez", "Verde", "Garcia", "Lopez", "Martinez",
            "Hernandez", "Gonzalez", "Perez", "Rodriguez", "Sanchez",
            "Ramirez", "Torres", "Flores", "Rivera", "Gomez",
            "Diaz", "Cruz", "Morales", "Reyes", "Ortiz",
            "Gutierrez", "Castillo", "Romero", "Vargas", "Mendoza",
            "Ramos", "Jimenez", "Ruiz", "Aguilar", "Medina",
            "Castro", "Vazquez", "Herrera", "Rojas", "Silva",
            "Delgado", "Campos", "Contreras", "Salazar", "Luna",
            "Ibarra", "Pena", "Cortes", "Soto", "Molina",
            "Nunez", "Mejia", "Espinoza", "Navarro", "Acosta",
            "Valdez", "Fuentes", "Carrillo", "Orozco", "Miranda",
            "Santos", "Cervantes", "Pacheco", "Arias", "Bravo",
            "Rios", "Padilla", "Vega", "Leon", "Escobar",
            "Maldonado", "Figueroa", "Solis", "Bautista", "Montes",
            "Cabrera", "Rosales", "Gallegos", "Zamora",
            "Del Rio", "Meza", "Cano", "Valencia", "Franco",
            "Tapia", "Lara", "Aguirre", "Benitez", "Ponce",
            "Castañeda", "Robles", "Macias", "Trejo", "Avila",
            "Palacios", "Barrera", "Padron", "Rangel", "Villanueva",
            "Arellano", "Esquivel", "Cisneros", "Montoya", "Zuniga"
        };
      bool[] nombresUsados = new bool[100];
      bool[] apellidosUsados = new bool[100];
      Console.WriteLine("=====GENERADOR DE NOMBRES=====");
      for (int i = 1; i <= 20; i++)
        {
          int n = rd.Next(nombres.Length);
          while (nombresUsados[n] == true)
            {
                n = rd.Next(nombres.Length);
            }
          nombresUsados[n] = true;
          int n2 = rd.Next(nombres.Length);
          while (nombresUsados[n2] == true)
            {
                n2 = rd.Next(nombres.Length);
            }
          nombresUsados[n2] = true;
          int a = rd.Next(apellidos.Length);
          while (apellidosUsados[a] == true)
            {
                a = rd.Next(apellidos.Length);
            }
          apellidosUsados[a] = true;
          int a2 = rd.Next(apellidos.Length);
          while (apellidosUsados[a2] == true)
            {
                a2 = rd.Next(apellidos.Length);
            }
           apellidosUsados[a2] = true;
          Console.WriteLine(i + ". " + nombres[n] + " " +
                nombres[n2] + " " + apellidos[a] + " " + apellidos[a2]);
        }
    }
}
