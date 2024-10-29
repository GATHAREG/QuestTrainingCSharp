using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinsSweeper
{
    internal class MineSweeper
    {
        Random random = new Random();
        private CellState[,] grid = new  CellState[5, 5];
        bool[,] viewed = new bool[5, 5];


        public MineSweeper()
        {
            
            InitGrid();
            Display();
           // RenderGrid();
            Start();

        }
        private void Display()
        {
            Console.Clear();
            for(int i = 0; i < 5; i++)
            {
                for(int  j = 0; j < 5; j++)
                {
                    var WhatToDisplay = viewed[i, j] ? (int)grid[i, j] + " " : "# ";
                    Console.Write($"{WhatToDisplay}  ");
                }
                Console.WriteLine();
            }
        }

        private void RenderGrid()
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"({grid[i,j]}) ");

                }
                Console.WriteLine();
            }
        }
        
        private void InitGrid()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    var state = (CellState)random.Next(0,3);
                    grid[i,j] = state;
                }
            }
        }
        public void Start()
        {
            while (true)
            {


                Console.Write("Enter the row(0-4):");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter the column(0-4):");
                int column = int.Parse(Console.ReadLine());
                if(viewed[row, column])
                {
                    Console.WriteLine("Already Selected");

                }

                if (grid[row, column] == CellState.Mines)
                {
                    Console.WriteLine("Boom.You are Out!");
                    break;
                }
                else
                {
                    viewed[row, column] = true;
                    Display();
                    Console.WriteLine("continue the game you are on the track.");

                    if (Win())
                    {
                        Console.WriteLine("CONGRATULATIONS...You cleared the grid");
                        break;
                    }
                }
                
            }
        }

        private bool Win()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i,j] != CellState.Mines && !viewed[i,j])
                    {
                        return false;
                    }
                }
               
            }
            return true;

        }
    }
}
