using System;
namespace cube_simulator
{
    public class EdgePiece : Piece
    {
        public EdgePiece(EdgePosition position, Color color1, Color color2)
        {
            switch (position)
            {
                case EdgePosition.UF:
                    this.u_color = color1;
                    this.f_color = color2;
                    break;
                case EdgePosition.UB:
                    this.u_color = color1;
                    this.b_color = color2;
                    break;
                case EdgePosition.UR:
                    this.u_color = color1;
                    this.r_color = color2;
                    break;
                case EdgePosition.UL:
                    this.u_color = color1;
                    this.l_color = color2;
                    break;
                case EdgePosition.DF:
                    this.d_color = color1;
                    this.f_color = color2;
                    break;
                case EdgePosition.DB:
                    this.d_color = color1;
                    this.b_color = color2;
                    break;
                case EdgePosition.DR:
                    this.d_color = color1;
                    this.r_color = color2;
                    break;
                case EdgePosition.DL:
                    this.d_color = color1;
                    this.l_color = color2;
                    break;
                case EdgePosition.FR:
                    this.f_color = color1;
                    this.r_color = color2;
                    break;
                case EdgePosition.FL:
                    this.f_color = color1;
                    this.l_color = color2;
                    break;
                case EdgePosition.BR:
                    this.b_color = color1;
                    this.r_color = color2;
                    break;
                case EdgePosition.BL:
                    this.b_color = color1;
                    this.l_color = color2;
                    break;
                default:
                    break;
            }
        }
    }
}
