﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine($"MyCoolEnvironmentVariableKey={Environment.GetEnvironmentVariable("MyCoolEnvironmentVariableKey")}");
            Console.WriteLine($"ASPNETCORE_HOSTINGSTARTUPASSEMBLIES={Environment.GetEnvironmentVariable("ASPNETCORE_HOSTINGSTARTUPASSEMBLIES")}");
        }
    }
}
