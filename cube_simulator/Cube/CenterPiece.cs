using System;
namespace cube_simulator
{
    public class CenterPiece : Piece
    {
        public CenterPiece(CenterPosition position, Color color)
        {
            switch (position)
            {
                case CenterPosition.U:
                    this.u_color = color;
                    break;
                case CenterPosition.D:
                    this.d_color = color;
                    break;
                case CenterPosition.F:
                    this.f_color = color;
                    break;
                case CenterPosition.B:
                    this.b_color = color;
                    break;
                case CenterPosition.R:
                    this.r_color = color;
                    break;
                case CenterPosition.L:
                    this.l_color = color;
                    break;
                default:
                    break;
            }
        }
    }
}