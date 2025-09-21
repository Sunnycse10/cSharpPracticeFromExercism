public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] textArray = text.ToCharArray();
        for (int i = 0; i < textArray.Length; i++)
        {
            int ascii = textArray[i];
            if (ascii is >= 65 and <= 95)
            {
                textArray[i] = (char)((ascii + shiftKey - 65) % 26 + 65);
            }
            else if (ascii is >= 97 and <= 122)
            {
                textArray[i] = (char)((ascii + shiftKey - 97) % 26 + 97);
            }
            else continue;
        }
        return new string(textArray);
    }
}