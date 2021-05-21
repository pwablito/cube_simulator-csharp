using System;
namespace cube_simulator
{
    public class CornerPiece : Piece
    {
        public CornerPiece(CornerPosition position, Color color1, Color color2, Color color3)
        {
            switch (position)
            {
                case CornerPosition.UFR:
                    this.u_color = color1;
                    this.f_color = color2;
                    this.r_color = color3;
                    break;
                case CornerPosition.UFL:
                    this.u_color = color1;
                    this.f_color = color2;
                    this.l_color = color3;
                    break;
                case CornerPosition.UBR:
                    this.u_color = color1;
                    this.b_color = color2;
                    this.r_color = color3;
                    break;
                case CornerPosition.UBL:
                    this.u_color = color1;
                    this.b_color = color2;
                    this.l_color = color3;
                    break;
                case CornerPosition.DFR:
                    this.d_color = color1;
                    this.f_color = color2;
                    this.r_color = color3;
                    break;
                case CornerPosition.DFL:
                    this.d_color = color1;
                    this.f_color = color2;
                    this.l_color = color3;
                    break;
                case CornerPosition.DBR:
                    this.d_color = color1;
                    this.b_color = color2;
                    this.r_color = color3;
                    break;
                case CornerPosition.DBL:
                    this.d_color = color1;
                    this.b_color = color2;
                    this.l_color = color3;
                    break;
                default:
                    break;
            }
        }
    }
}