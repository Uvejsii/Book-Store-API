using System.Text;

internal static class Settings 
{
    internal static string SecretKey = "6ceccd7405ef4b00b2630009be568cfa";
    internal static byte[] GenereateSecretByte() =>
        Encoding.ASCII.GetBytes(SecretKey);
}