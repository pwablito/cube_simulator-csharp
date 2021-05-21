using System;
namespace cube_simulator
{
    public class CLICubeDisplay : CubeDisplay
    {
        public CLICubeDisplay()
        {
        }

        public void update(Cube cube)
        {
            CLICubeDisplay.print_cube(cube);
        }

        public static void print_cube(Cube cube)
        {
            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.d_b_l_corner.b_color));
            Console.Write(color_to_char(cube.d_b_edge.b_color));
            Console.Write(color_to_char(cube.d_b_r_corner.b_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.b_l_edge.b_color));
            Console.Write(color_to_char(cube.b_center.b_color));
            Console.Write(color_to_char(cube.b_r_edge.b_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.u_b_l_corner.b_color));
            Console.Write(color_to_char(cube.u_b_edge.b_color));
            Console.Write(color_to_char(cube.u_b_r_corner.b_color));

            Console.Write('\n');

            Console.Write(color_to_char(cube.d_b_l_corner.l_color));
            Console.Write(color_to_char(cube.b_l_edge.l_color));
            Console.Write(color_to_char(cube.u_b_l_corner.l_color));

            Console.Write(color_to_char(cube.u_b_l_corner.u_color));
            Console.Write(color_to_char(cube.u_b_edge.u_color));
            Console.Write(color_to_char(cube.u_b_r_corner.u_color));

            Console.Write(color_to_char(cube.u_b_r_corner.r_color));
            Console.Write(color_to_char(cube.b_r_edge.r_color));
            Console.Write(color_to_char(cube.d_b_r_corner.r_color));

            Console.Write('\n');

            Console.Write(color_to_char(cube.d_l_edge.l_color));
            Console.Write(color_to_char(cube.l_center.l_color));
            Console.Write(color_to_char(cube.u_l_edge.l_color));

            Console.Write(color_to_char(cube.u_l_edge.u_color));
            Console.Write(color_to_char(cube.u_center.u_color));
            Console.Write(color_to_char(cube.u_r_edge.u_color));

            Console.Write(color_to_char(cube.u_r_edge.r_color));
            Console.Write(color_to_char(cube.r_center.r_color));
            Console.Write(color_to_char(cube.d_r_edge.r_color));

            Console.Write('\n');

            Console.Write(color_to_char(cube.d_f_l_corner.l_color));
            Console.Write(color_to_char(cube.f_l_edge.l_color));
            Console.Write(color_to_char(cube.u_f_l_corner.l_color));

            Console.Write(color_to_char(cube.u_f_l_corner.u_color));
            Console.Write(color_to_char(cube.u_f_edge.u_color));
            Console.Write(color_to_char(cube.u_f_r_corner.u_color));

            Console.Write(color_to_char(cube.u_f_r_corner.r_color));
            Console.Write(color_to_char(cube.f_r_edge.r_color));
            Console.Write(color_to_char(cube.d_f_r_corner.r_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.u_f_l_corner.f_color));
            Console.Write(color_to_char(cube.u_f_edge.f_color));
            Console.Write(color_to_char(cube.u_f_r_corner.f_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.f_l_edge.f_color));
            Console.Write(color_to_char(cube.f_center.f_color));
            Console.Write(color_to_char(cube.f_r_edge.f_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.d_f_l_corner.f_color));
            Console.Write(color_to_char(cube.d_f_edge.f_color));
            Console.Write(color_to_char(cube.d_f_r_corner.f_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.d_f_l_corner.d_color));
            Console.Write(color_to_char(cube.d_f_edge.d_color));
            Console.Write(color_to_char(cube.d_f_r_corner.d_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.d_l_edge.d_color));
            Console.Write(color_to_char(cube.d_center.d_color));
            Console.Write(color_to_char(cube.d_r_edge.d_color));

            Console.Write('\n');

            Console.Write(' ');
            Console.Write(' ');
            Console.Write(' ');

            Console.Write(color_to_char(cube.d_b_l_corner.d_color));
            Console.Write(color_to_char(cube.d_b_edge.d_color));
            Console.Write(color_to_char(cube.d_b_r_corner.d_color));

            Console.Write('\n');
        }

        private static char color_to_char(Color color)
        {
            switch (color)
            {
                case Color.GREEN:
                    return 'g';
                case Color.BLUE:
                    return 'b';
                case Color.WHITE:
                    return 'w';
                case Color.YELLOW:
                    return 'y';
                case Color.ORANGE:
                    return 'o';
                case Color.RED:
                    return 'r';
                default:
                    throw new InvalidColorException();
            }
        }

        public System.Collections.Generic.List<Move> get_moves()
        {
            System.Collections.Generic.List<Move> moves = new System.Collections.Generic.List<Move>();
            Console.Write("Input a string of moves: ");
            String move_string = Console.ReadLine();
            for (int i = 0; i < move_string.Length; i++)
            {
                switch (move_string[i])
                {
                    case 'r':
                        moves.Add(Move.RIGHT);
                        break;
                    case 'l':
                        moves.Add(Move.LEFT);
                        break;
                    case 'u':
                        moves.Add(Move.UP);
                        break;
                    case 'd':
                        moves.Add(Move.DOWN);
                        break;
                    case 'f':
                        moves.Add(Move.FRONT);
                        break;
                    case 'b':
                        moves.Add(Move.BACK);
                        break;
                    case 'R':
                        moves.Add(Move.RIGHT_PRIME);
                        break;
                    case 'L':
                        moves.Add(Move.LEFT_PRIME);
                        break;
                    case 'U':
                        moves.Add(Move.UP_PRIME);
                        break;
                    case 'D':
                        moves.Add(Move.DOWN_PRIME);
                        break;
                    case 'F':
                        moves.Add(Move.FRONT_PRIME);
                        break;
                    case 'B':
                        moves.Add(Move.BACK_PRIME);
                        break;
                    case '\n':
                        break;
                    case 'h':
                        print_help();
                        break;
                    case 'H':
                        print_help();
                        break;
                    default:
                        throw new InvalidMoveException();
                }
            }
            return moves;
        }

        private static void print_help()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("\tAvailable moves (capitalize for prime)");
            Console.WriteLine("\t\tr: right");
            Console.WriteLine("\t\tl: left");
            Console.WriteLine("\t\tu: up");
            Console.WriteLine("\t\td: down");
            Console.WriteLine("\t\tf: front");
            Console.WriteLine("\t\tb: back");
            Console.WriteLine("\tOther:");
            Console.WriteLine("\t\tH | h: help");
        }
    }
}
