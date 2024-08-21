namespace Hello.World;

using Figgle;

public class Greeter
{
    public static string Greet() => "Hello, World!";

    private string FiggleMeThis(string message)
    {
        return FiggleFonts.Standard.Render(message);
    }
}
