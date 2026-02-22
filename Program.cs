    //1.) Triaje médico y prioridad de atención
    Console.WriteLine("MENU");
    Console.WriteLine("Presione 1 para Emergencia");
    Console.WriteLine("Presione 2 para Consulta");
    Console.WriteLine("Presione 3 para Pediatría");
    Console.WriteLine("Presione 4 para Traumatología");

    int opcion = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su edad");
    int edad = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su temperatura");
    double temperatura = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su oxigeno");
    double oxigeno = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su nivel de dolor");
    int dolor = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su presión sistólica ");
    int sistolica = int.Parse(Console.ReadLine());


if (edad < 0 || edad > 120)
{
    Console.WriteLine("ERROR, FUERA DE RANGO");
}
else if (temperatura < 35 || temperatura > 50)
{
    Console.WriteLine("ERROR FUERA DE RANGO");
}

else if (oxigeno < 0 || oxigeno > 100)
{
    Console.WriteLine("ERROR FUERA DE RANGO");
}

else if (dolor < 0 || dolor > 10)
{
    Console.WriteLine("ERROR FUERA DE RANGO");
}

else if (sistolica < 50 || dolor > 250)
{
    Console.WriteLine("ERROR FUERA DE RANGO");
}

else
{

    string prioridad = "";
    string accion = "";

    switch (opcion)
    {
        case 1:

           

                break;
        case 2:

           
                break;


        case 3:

            


                break;

        case 4:

           

                break;


        default:
            Console.WriteLine("Opción ingresada incorrecta");
            break;


           


    }




}


