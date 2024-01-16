﻿WriteLine($"There are {args.Length} arguments.");

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}
ForegroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[1], ignoreCase: true);
CursorSize = int.Parse(args[2]);
