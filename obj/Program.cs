/*
 * Event Demo
 * Uses example code from http://www.albahari.com/nutshell/E9-CH04.aspx
 * Monday section of PROG 201
 */

using System;

namespace EventDemo
{
    class Program
    {
        static void Main()
        {
            Console.Title = "PROG 201 Event Demo";
            Exchange exchange = new Exchange();
            exchange.Open();
        }
    }
}
