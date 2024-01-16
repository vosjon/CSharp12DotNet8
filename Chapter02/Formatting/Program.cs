﻿int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // Writes the string into a file.

// Three parameter values can use named arguments.
WriteLine("{0} {1} lived in {2}.",
  arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
// Four or more parameter values cannot use named arguments.
WriteLine(
  "{0} {1} lived in {2} and worked in the {3} team at {4}.",
  "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// The following statement must be all on one line when using C# 10
// or earlier. If using C# 11 or later, we can include a line break
// in the middle of an expression but not in the string text.
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine();
WriteLine(format: "{0,-10} {1,6}",
  arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-10} {1,6:N0}",
  arg0: applesText, arg1: applesCount);
WriteLine(format: "{0,-10} {1,6:N0}",
  arg0: bananasText, arg1: bananasCount);

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}.");
