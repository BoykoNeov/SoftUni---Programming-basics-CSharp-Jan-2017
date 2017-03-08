using System;


namespace point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int switcher = -1; // -1 outside , 0 border, 1 inside

            int fig1_x1 = 0 ;
            int fig1_y1 = 0 ;
            int fig1_x2 = 3 * h;
            int fig1_y2 = h;

            int fig2_x1 = h;
            int fig2_y1 = h;
            int fig2_x2 = 2 * h;
            int fig2_y2 = 4 * h;

            if ( ((x > fig1_x1 )&&(x < fig1_x2 ))
                &&
                (( y > fig1_y1 )&&(y < fig1_y2)) )              
                {
                switcher = 1;            //leji vyv figura 1
                }

            if (((x > fig2_x1) && (x < fig2_x2))
    &&
    ((y > fig2_y1) && (y < fig2_y2)))
            {
                switcher = 1;            //leji vyv figura 2
            }

            if (((x == fig2_x1) || (x == fig2_x2)) &&
                    ((y >= fig2_y1) && (y <= fig2_y2)) ||

               ((y == fig2_y1) || (y == fig2_y2)) &&
                    ((x >= fig2_x1) && (x <= fig2_x2)))
                    {
                switcher = 0; //leji na granicata na figura 2
                    }


            if (((x == fig1_x1) || (x == fig1_x2)) &&
        ((y >= fig1_y1) && (y <= fig1_y2)) ||

   ((y == fig1_y1) || (y == fig1_y2)) &&
        ((x >= fig1_x1) && (x <= fig1_x2)))
            {
                switcher = 0; //leji na granicata na figura 1
            }

            if ((y == h) && ((x > h) && (x < (2 * h)))  )
            {
                switcher = 1; //leji na granicata mejdu dvete figuri, toest e vytre
            }

            switch (switcher)
            {
                case -1:
                    Console.WriteLine("outside");
                    break;
                case 0:
                    Console.WriteLine("border");
                    break;
                case 1:
                    Console.WriteLine("inside");
                    break;
            }
        }
    }
}
