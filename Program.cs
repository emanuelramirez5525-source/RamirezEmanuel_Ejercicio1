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

else if (sistolica < 50 || sistolica > 250)
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

            if (oxigeno < 90)
            {
                prioridad = "Prioridad 1";
                accion = "Reanimación inmediata";
            }

            else
            {
                if (temperatura >= 39 && dolor >= 8)
                {
                    prioridad = "Prioridad 2";
                    accion = "Atencion urgente ";
                }

                else
                {
                    prioridad = "Prioridad 3";
                    accion = "Observación";
                }



            }

            break;
        case 2:

            if (dolor <= 4)
            {
                prioridad = "Prioridad baja";
                accion = "Consulta normal";

            }

            else
            {
                prioridad = "Media";
                accion = "Evaluación médica";
            }

            break;


        case 3:

            if (edad < 12)
            {
                if (temperatura > 38.5)
                {
                    prioridad = "Prioridad alta";
                    accion = "Atención medica inmediata";
                }
                else
                {
                    prioridad = "Prioridad normal";
                    accion = "Consulta pedriatica";
                }
            }
            else
            {
                prioridad = "Derivar a consulta general";
                accion = "No corresponde pediatría";
            }


            break;

        case 4:

            if (dolor >= 7)
            {
                prioridad = "Prioridad alta";
                accion = "Radiografia y atencion urgente!!";
            }
            else
            {
                prioridad = "Prioridad media";
                accion = "Evaluación  traumatologica!!";
            }

            break;


        default:
            Console.WriteLine("Opción ingresada incorrecta");
            break;
    }

    Console.WriteLine("RESULTADOS!!!");
    Console.WriteLine("Prioridad: " + prioridad);
    Console.WriteLine("Accion: " + accion);

}


