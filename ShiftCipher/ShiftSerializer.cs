using System;
using System.Runtime.CompilerServices;

namespace CorgiCoder.ShiftCipher;

public class ShiftSerializer
{
    public ShiftSerializerOptions Options { get; private init; }

    static ShiftSerializer()
    {
        // Print the logo!
        // This is the best way I, CorgiCoder, can think of to do this.
        string[] textElements1 = new string[]
        {
            """
              ██████
            ██      ██
            ██
            ██
            ██
            ██
            ██      ██
              ██████
            """,
            """
            


              ██████
            ██      ██
            ██      ██
            ██      ██
              ██████
            """,
            """



            ██  ████
            ████
            ██
            ██
            ██
            """,
            """

              ██████
            ██      ██
            ██      ██
              ██████
                    ██
            ██      ██
              ██████
            """,
            """



            ██

            ██
            ██
            ██
            """,
            """
              ██████
            ██      ██
            ██
            ██
            ██
            ██
            ██      ██
              ██████
            """,
            """
            


              ██████
            ██      ██
            ██      ██
            ██      ██
              ██████
            """,
            """
                    ██
                    ██
                    ██
              ████████
            ██      ██
            ██      ██
            ██      ██
              ████████
            """,
            """



              ██████
            ██      ██
            ████████
            ██
              ██████
            """,
            """



            ██  ████
            ████
            ██
            ██
            ██
            """,
            """
              ██
              ██
            ██





            """,
            """



              ██████
            ██
              ██████
                    ██
              ██████
            """
        };
        string[] textElements2 = new string[]
        {
            """
              ██████
            ██      ██
            ██
              ██████
                    ██
                    ██
            ██      ██
              ██████
            """,
            """

            ██
            ██
            ██
            ██████
            ██    ██
            ██    ██
            ██    ██
            """,
            """


            ██

            ██
            ██
            ██
            ██
            """,
            """

              ██████
            ██
            ██
            ██████
            ██
            ██
            ██
            """,
            """
            
              ██
              ██
              ██
            ██████
              ██
              ██
              ██
            """,
            """
                  
            """,
            """
              ██████
            ██      ██
            ██
            ██
            ██
            ██
            ██      ██
              ██████
            """,
            """


            ██

            ██
            ██
            ██
            ██
            """,
            """

            ████████
            ██      ██
            ██      ██
            ████████
            ██
            ██
            ██
            """,
            """

            ██
            ██
            ██
            ██████
            ██    ██
            ██    ██
            ██    ██
            """,
            """



              ██████
            ██      ██
            ████████
            ██
              ██████
            """,
            """



            ██  ████
            ████
            ██
            ██
            ██
            """
        };
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow,
                                  ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Cyan,
                                  ConsoleColor.DarkCyan, ConsoleColor.Blue, ConsoleColor.DarkBlue,
                                  ConsoleColor.Magenta, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed };

        // Stay tuned on CorgiCoder's Shift Cipher!
        int position = 0;
        for (int i = 0; i < textElements1.Length; i++)
        {
            int maxLength = 0;
            string[] lines = textElements1[i].Split('\n');
            Console.ForegroundColor = colors[i % colors.Length];
            for (int j = 0; j < lines.Length; j++)
            {
                Console.SetCursorPosition(position, j);
                Console.WriteLine(lines[j]);
                if (maxLength < lines[j].Length) maxLength = lines[j].Length;
            }
            if (i < textElements1.Length - 1) position += maxLength;
        }

        position = 0;
        for (int i = 0; i < textElements2.Length; i++)
        {
            int maxLength = 0;
            string[] lines = textElements2[i].Split('\n');

            Console.ForegroundColor = colors[colors.Length - (i % colors.Length) - 1];
            for (int j = 0; j < lines.Length; j++)
            {
                Console.SetCursorPosition(position, j + textElements2.Length + 1);
                Console.WriteLine(lines[j]);
                if (maxLength < lines[j].Length) maxLength = lines[j].Length;
            }
            if (i < textElements2.Length - 1) position += maxLength;
        }
        Console.ResetColor();
    }

    private ShiftSerializer(ShiftSerializerOptions options)
    {
        Options = options;
    }

    public static ShiftSerializer Create(ShiftSerializerOptions options) => new(options);
    public static ShiftSerializer CreateDefault() => new(new());
}
