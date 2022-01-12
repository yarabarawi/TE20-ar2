using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hej Raylib");

            // starta ett fönster
            Raylib.InitWindow(800,600, "Ett Raylib förnster");

          // ställ in fps
          Raylib.SetTargetFPS(60);

          Color TransparantGreen = new Color(0,255,0,170);

          //animationslopen
          while (!Raylib.WindowShouldClose())
          {
               // börja rita
               Raylib.BeginDrawing();

               // tomma rit ytan
               Raylib.ClearBackground(Color.BROWN);

               // rita kvadrat
               Raylib.DrawRectangle(150,150,600,400,Color.BLUE);

               // rita kvadrat gul y
               Raylib.DrawRectangle(150,310,600,70,Color.YELLOW);

                // rita kvadrat gul x
               Raylib.DrawRectangle(270,150,70,400,Color.YELLOW);

               // rita kvadrat japan 
               Raylib.DrawRectangle(10,20,250,200,Color.WHITE);

               // rita cirlke japan 
               Raylib.DrawCircle(120,110,70,Color.RED);

               // rita text
               Raylib.DrawText("Japan vs Svergie", 100,500,50,TransparantGreen);


              
               //sluta rita
               Raylib.EndDrawing();
          }
        }
    }
}
