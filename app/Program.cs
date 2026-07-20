using System;

public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public float Velocidad { get; set; }
}

public class Auto : Vehiculo
{
    public int NumeroPuertas { get; set; }
    public string TipoTransmision { get; set; }

    public void ActivarLuces()
    {
        Console.WriteLine($"{Marca} {Modelo}: las luces se han encendido.");
    }
}

public class Camion : Vehiculo
{
    public float CapacidadCarga { get; set; }
    public int NumeroEjes { get; set; }
}

public class Moto : Vehiculo
{
    public string TipoManillar { get; set; }
    public int Cilindraje { get; set; }

    public void HacerCaballito()
    {
        Console.WriteLine($"{Marca} {Modelo}: ¡haciendo caballito!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Auto miAuto = new Auto
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Anio = 2023,
            Velocidad = 180.5f,
            NumeroPuertas = 4,
            TipoTransmision = "Automática"
        };

        Camion miCamion = new Camion
        {
            Marca = "Volvo",
            Modelo = "FH16",
            Anio = 2021,
            Velocidad = 120f,
            CapacidadCarga = 15000f,
            NumeroEjes = 3
        };

        Moto miMoto = new Moto
        {
            Marca = "Yamaha",
            Modelo = "MT-07",
            Anio = 2024,
            Velocidad = 200f,
            TipoManillar = "Deportivo",
            Cilindraje = 700
        };

        Console.WriteLine($"{miAuto.Marca} {miAuto.Modelo} - {miAuto.NumeroPuertas} puertas, {miAuto.TipoTransmision}");
        miAuto.ActivarLuces();

        Console.WriteLine($"{miCamion.Marca} {miCamion.Modelo} - Carga máxima: {miCamion.CapacidadCarga} kg, {miCamion.NumeroEjes} ejes");

        Console.WriteLine($"{miMoto.Marca} {miMoto.Modelo} - Manillar: {miMoto.TipoManillar}, {miMoto.Cilindraje}cc");
        miMoto.HacerCaballito();
    }
}