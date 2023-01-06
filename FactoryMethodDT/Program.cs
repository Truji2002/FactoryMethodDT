//using FactoryMethodDT;

using FactoryMethodDT;



    //{
    
    Console.WriteLine("Seleccione el equipo del cual desea saber los titulos que tiene:");
    Console.WriteLine("1. Liga");
    Console.WriteLine("2. Independiente del Valle");
    Console.WriteLine("3. Barcelona");
    Console.WriteLine("4. Emelec");
    Console.WriteLine("5. Salir");
    Console.Write("Selecciona una opción: ");

    string opc = Console.ReadLine();

    int opcion = int.Parse(opc);

    Equipos equipo = Creador.CreadorEquipos(opcion);
    switch (opcion)
    {

        case 1:

            Console.WriteLine("Liga tiene " + equipo.titulos() + " titulos");
            break;
        case 2:

            Console.WriteLine("Independiente del Valle tiene " + equipo.titulos() + " titulos");
            break;
        case 3:

            Console.WriteLine("Barcelona tiene " + equipo.titulos() + " titulos");
            break;
        case 4:

            Console.WriteLine("Emelec tiene " + equipo.titulos() + " titulos");
            break;
        case 5:
            
            break;
        default:
            Console.WriteLine("Opción inválida, vuelve a intentarlo.");

            break;
    }

    

