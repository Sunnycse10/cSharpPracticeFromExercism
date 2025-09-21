public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char Rotate(char c)
        {
            if (!char.IsLetter(c)) return c;
            int b = char.IsUpper(c) ? 'A' : 'a';
            return (char)(b + (c - b + shiftKey) % 26);
        }
        return new string(text.Select(Rotate).ToArray());
    }
}