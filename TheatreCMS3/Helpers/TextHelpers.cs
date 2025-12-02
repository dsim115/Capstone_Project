using System;

namespace TheatreCMS3.Helpers
{
    public static class TextHelpers
    {
        public static string CharacterLimit(string content, int numbOfCharacters)
        {
            // Null check
            if (string.IsNullOrEmpty(content))
                return content;

            // If the content is already shorter than the limit, return as-is
            if (content.Length <= numbOfCharacters)
                return content;

            // Make sure we don't try to substring too short
            if (numbOfCharacters <= 3)
                return "...";

            // Truncate and add ellipses
            return content.Substring(0, numbOfCharacters - 3) + "...";
        }
    }
}
