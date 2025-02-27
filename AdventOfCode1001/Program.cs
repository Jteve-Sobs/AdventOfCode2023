﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1001
{
    internal class Program
    {
        private static int m_CycleCounter;
        public static int CycleCounter
        {
            get
            {
                return m_CycleCounter;
            }
            set
            {
                m_CycleCounter = value;

                if (m_CycleCounter == 20
                    || m_CycleCounter == 60
                    || m_CycleCounter == 100
                    || m_CycleCounter == 140
                    || m_CycleCounter == 180
                    || m_CycleCounter == 220
                )
                {
                    SignalStrength += m_CycleCounter * Register;
                }
            }
        }
        public static int SignalStrength = 0;
        public static int Register = 1;

        static void Main(string[] args)
        {
            //var input = File.ReadAllLines("..\\..\\input1.txt").ToList();
            var input = File.ReadAllLines("..\\..\\input2.txt").ToList();

            CycleCounter = 0;

            foreach (var command in input)
            {
                if (command == "noop")
                {
                    CycleCounter++;
                }
                else if (command.StartsWith("addx "))
                {
                    var value = Convert.ToInt32(command.Split(' ').Last());

                    CycleCounter++;
                    CycleCounter++;

                    Register += value;
                }
            }

            // Assert for input1
            //Assert.AreEqual(13140, SignalStrength, "Result is not correct");

            Console.WriteLine("Result: " + SignalStrength);
        }
    }
}
