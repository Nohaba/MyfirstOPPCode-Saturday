﻿using System;

namespace MyFirstOPPCode_Saturday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObject = new Date(2025, 2, 29);
                Console.WriteLine(dateObject.ToString());

                Console.WriteLine("");

                
                Console.WriteLine()
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
