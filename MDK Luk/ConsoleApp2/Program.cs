namespace ConsoleApp2;

public class Program
{
    public static void Main(string[] args) {
        
    }

    public static int chekaem_pass(string pass) {
        int balli = 0;

        if (pass.Any(char.IsDigit)) {
            balli++;
        }

        if (pass.Any(char.IsLower)) {
            balli++;
        }

        if (pass.Any(char.IsUpper)) {
            balli++;
        }

        if (pass.Any(cho => !char.IsLetterOrDigit(cho))) {
            balli++;
        } 

        if (pass.Length > 7) {
            balli++;
        }

        return balli;
    }
}