﻿using static System.Console;
namespace CallStackExceptionHandlingLib;

public class Processor
{
    public static void Gamma()
    {
        WriteLine("In Gamma");
        Delta();
    }

    public static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}