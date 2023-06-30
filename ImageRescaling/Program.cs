using ImageRescaling.Common.Exceptions;
using ImageRescaling.Extensions;

string GetConsoleLine()
{
    return Console.ReadLine() ?? throw new ConsoleException();
}

void Main()
{
    try
    {
        Console.WriteLine("Ingresar ruta de la imagen");
        string imagePath = GetConsoleLine();
        
        Console.WriteLine("Ingresar ancho");
        int newWidth = GetConsoleLine().ToInt32();
        
        Console.WriteLine("Ingresar largo");
        int newHeight = GetConsoleLine().ToInt32();

        ImageRescaling.Controller.ImageRescaling.ResizeImageGPU(imagePath, newWidth, newHeight);
    }
    catch(Exception ex)
    {
        Console.Clear();
        if(ex is ConsoleException)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

Main();
//string imagePath = @"C:/Users/SoldierStark/Documents/GitHub/ImageRescaling/ImageRescaling/Images/zyro-image.png";