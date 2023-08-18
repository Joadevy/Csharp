namespace HelloWorld;

class Program
{
    static void Main(string[] args) // Main es el entry point. Al ejecutar el programa, se ejecuta Main.
    {
        Console.WriteLine("Hello, World!");
        Usuario user = new Usuario("Juan", "Perez", 30);

        user.Saludar();
        Console.WriteLine(user.EsMayorDeEdad() ? $"{user.nombre} mayor de edad" : "Soy menor de edad");
    }
}
