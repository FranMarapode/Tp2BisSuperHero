const int FIN_PROGRAMA = 4;
int opcion = 4;
Superheroe superheroe1 = new Superheroe();
Superheroe superheroe2 = new Superheroe();
do
{
    mostrarMenu();
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            cargarSuperheroe(superheroe1, "1");
        break;
        case 2:
            cargarSuperheroe(superheroe2, "2");
        break;
        case 3:
            competir(superheroe1, superheroe2);
        break;
        case 4:
            Console.WriteLine("Saliste");
        break;
        default:
        break;
    }
} while (opcion != FIN_PROGRAMA);

static void mostrarMenu()
{
    Console.WriteLine("1. Cargar Datos Superhéroe N° 1");
    Console.WriteLine("2. Cargar Datos Superhéroe N° 2");
    Console.WriteLine("3. Competir!");
    Console.WriteLine("4. Salir");
}

static void cargarSuperheroe(Superheroe superheroe, string numero)
{
    Console.WriteLine("CARGAR DATOS SUPERHEROE N° " + numero);
    superheroe.Nombre = obtenerDato("nombre");
    superheroe.Ciudad = obtenerDato("ciudad");
    superheroe.Peso = validarNumero(1, 100, "peso");
    superheroe.Fuerza = validarNumero(1, 100, "fuerza");
    superheroe.Velocidad = validarNumero(1, 100, "velocidad");
    Console.WriteLine("Se ha creado el Superhéroe " + superheroe.Nombre);
}

static string obtenerDato(string tipo)
{
    string dato;
    do
    {
        Console.Write("- Ingrese el " + tipo + ": ");
        dato = Console.ReadLine();
    } while (dato.Equals(""));
    return dato;
}

static double validarNumero(double min, double max, string tipo)
{
    double numero;
    do
    {
        Console.Write("- Ingrese su " + tipo + " entre " + min + " y " + max + ": ");
    } while (!double.TryParse(Console.ReadLine(), out numero) || numero < min || numero > max);
    return numero;
}

static void competir(Superheroe superheroe1, Superheroe superheroe2)
{
    const int TREINTA = 30, DIEZ = 10, CERO = 0;
     if (superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill() >= TREINTA)
        {
            Console.WriteLine("Ganó " + superheroe1.Nombre + " por amplia diferencia");
        }
        else if (superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill() >= DIEZ)
        {
            Console.WriteLine("Ganó " + superheroe1.Nombre + ". Fue muy parejo!");
        }
        else if (superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill() <= DIEZ && superheroe1.ObtenerSkill() - superheroe2.ObtenerSkill() >= CERO)
        {
            Console.WriteLine("Ganó " + superheroe1.Nombre + ". ¡No le sobro nada!");
        }
        else if (superheroe2.ObtenerSkill() - superheroe1.ObtenerSkill() >= TREINTA)
        {
            Console.WriteLine("Ganó " + superheroe2.Nombre + " por amplia diferencia");
        }
        else if (superheroe2.ObtenerSkill() - superheroe1.ObtenerSkill() >= DIEZ)
        {
            Console.WriteLine("Ganó " + superheroe2.Nombre + ". Fue muy parejo!");
        }
        else if (superheroe2.ObtenerSkill() - superheroe1.ObtenerSkill() <= DIEZ && superheroe2.ObtenerSkill() - superheroe1.ObtenerSkill() >= CERO)
        {
            Console.WriteLine("Ganó " + superheroe2.Nombre + ". ¡No le sobro nada!");
        }
}
