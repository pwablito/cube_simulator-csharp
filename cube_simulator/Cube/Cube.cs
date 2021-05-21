using System;
namespace cube_simulator
{
    public class Cube
    {
        public CornerPiece u_f_r_corner;
        public CornerPiece u_f_l_corner;
        public CornerPiece d_f_r_corner;
        public CornerPiece d_f_l_corner;
        public CornerPiece u_b_r_corner;
        public CornerPiece u_b_l_corner;
        public CornerPiece d_b_r_corner;
        public CornerPiece d_b_l_corner;

        public EdgePiece u_f_edge;
        public EdgePiece u_b_edge;
        public EdgePiece d_f_edge;
        public EdgePiece d_b_edge;
        public EdgePiece u_r_edge;
        public EdgePiece u_l_edge;
        public EdgePiece d_r_edge;
        public EdgePiece d_l_edge;
        public EdgePiece f_r_edge;
        public EdgePiece f_l_edge;
        public EdgePiece b_r_edge;
        public EdgePiece b_l_edge;

        public CenterPiece u_center;
        public CenterPiece d_center;
        public CenterPiece f_center;
        public CenterPiece b_center;
        public CenterPiece r_center;
        public CenterPiece l_center;

        public Cube(StartState state)
        {
            this.set_solved();
            if (state == StartState.SOLVED)
            {
                Console.WriteLine("Solved cube state generated");
            }
            if (state == StartState.SCRAMBLED)
            {
                // Scramble
            }
        }
        private void set_solved()
        {
            // Center pieces
            this.u_center = new CenterPiece(CenterPosition.U, Color.WHITE);
            this.d_center = new CenterPiece(CenterPosition.D, Color.YELLOW);
            this.f_center = new CenterPiece(CenterPosition.F, Color.BLUE);
            this.b_center = new CenterPiece(CenterPosition.B, Color.GREEN);
            this.r_center = new CenterPiece(CenterPosition.R, Color.ORANGE);
            this.l_center = new CenterPiece(CenterPosition.L, Color.RED);

            // Edge pieces
            this.u_f_edge = new EdgePiece(EdgePosition.UF, Color.WHITE, Color.BLUE);
            this.u_b_edge = new EdgePiece(EdgePosition.UB, Color.WHITE, Color.GREEN);
            this.u_r_edge = new EdgePiece(EdgePosition.UR, Color.WHITE, Color.ORANGE);
            this.u_l_edge = new EdgePiece(EdgePosition.UL, Color.WHITE, Color.RED);
            this.d_f_edge = new EdgePiece(EdgePosition.DF, Color.YELLOW, Color.BLUE);
            this.d_b_edge = new EdgePiece(EdgePosition.DB, Color.YELLOW, Color.GREEN);
            this.d_r_edge = new EdgePiece(EdgePosition.DR, Color.YELLOW, Color.ORANGE);
            this.d_l_edge = new EdgePiece(EdgePosition.DL, Color.YELLOW, Color.RED);
            this.f_r_edge = new EdgePiece(EdgePosition.FR, Color.BLUE, Color.ORANGE);
            this.f_l_edge = new EdgePiece(EdgePosition.FL, Color.BLUE, Color.RED);
            this.b_r_edge = new EdgePiece(EdgePosition.BR, Color.GREEN, Color.ORANGE);
            this.b_l_edge = new EdgePiece(EdgePosition.BL, Color.GREEN, Color.RED);

            // Corner pieces
            this.u_f_r_corner = new CornerPiece(CornerPosition.UFR, Color.WHITE, Color.BLUE, Color.ORANGE);
            this.u_f_l_corner = new CornerPiece(CornerPosition.UFL, Color.WHITE, Color.BLUE, Color.RED);
            this.u_b_r_corner = new CornerPiece(CornerPosition.UBR, Color.WHITE, Color.GREEN, Color.ORANGE);
            this.u_b_l_corner = new CornerPiece(CornerPosition.UBL, Color.WHITE, Color.GREEN, Color.RED);
            this.d_f_r_corner = new CornerPiece(CornerPosition.DFR, Color.YELLOW, Color.BLUE, Color.ORANGE);
            this.d_f_l_corner = new CornerPiece(CornerPosition.DFL, Color.YELLOW, Color.BLUE, Color.RED);
            this.d_b_r_corner = new CornerPiece(CornerPosition.DBR, Color.YELLOW, Color.GREEN, Color.ORANGE);
            this.d_b_l_corner = new CornerPiece(CornerPosition.DBL, Color.YELLOW, Color.GREEN, Color.RED);
        }

        public void move(Move move)
        {
            switch (move)
            {
                case Move.RIGHT:
                    this.move_r();
                    break;
                case Move.RIGHT_PRIME:
                    this.move_r();
                    this.move_r();
                    this.move_r();
                    break;
                case Move.LEFT:
                    this.move_l_prime();
                    this.move_l_prime();
                    this.move_l_prime();
                    break;
                case Move.LEFT_PRIME:
                    this.move_l_prime();
                    break;
                case Move.FRONT:
                    this.move_f();
                    break;
                case Move.FRONT_PRIME:
                    this.move_f();
                    this.move_f();
                    this.move_f();
                    break;
                case Move.BACK:
                    this.move_b_prime();
                    this.move_b_prime();
                    this.move_b_prime();
                    break;
                case Move.BACK_PRIME:
                    this.move_b_prime();
                    break;
                case Move.UP:
                    this.move_u();
                    break;
                case Move.UP_PRIME:
                    this.move_u();
                    this.move_u();
                    this.move_u();
                    break;
                case Move.DOWN:
                    this.move_d_prime();
                    this.move_d_prime();
                    this.move_d_prime();
                    break;
                case Move.DOWN_PRIME:
                    this.move_d_prime();
                    break;
                default:
                    Console.WriteLine("Invalid move");
                    break;
            }
        }
        private void move_r()
        {

            // Move corners

            this.u_f_r_corner.move_r();
            this.u_b_r_corner.move_r();
            this.d_f_r_corner.move_r();
            this.d_b_r_corner.move_r();

            CornerPiece new_ufr = this.d_f_r_corner;
            CornerPiece new_dfr = this.d_b_r_corner;
            CornerPiece new_dbr = this.u_b_r_corner;
            CornerPiece new_ubr = this.u_f_r_corner;

            this.u_f_r_corner = new_ufr;
            this.u_b_r_corner = new_ubr;
            this.d_f_r_corner = new_dfr;
            this.d_b_r_corner = new_dbr;

            // Move edges

            this.u_r_edge.move_r();
            this.d_r_edge.move_r();
            this.f_r_edge.move_r();
            this.b_r_edge.move_r();

            EdgePiece new_ur = this.f_r_edge;
            EdgePiece new_fr = this.d_r_edge;
            EdgePiece new_dr = this.b_r_edge;
            EdgePiece new_br = this.u_r_edge;

            this.u_r_edge = new_ur;
            this.f_r_edge = new_fr;
            this.d_r_edge = new_dr;
            this.b_r_edge = new_br;
        }

        private void move_l_prime()
        {

            // Move corners

            this.u_f_l_corner.move_r();
            this.u_b_l_corner.move_r();
            this.d_f_l_corner.move_r();
            this.d_b_l_corner.move_r();

            CornerPiece new_ufl = this.d_f_l_corner;
            CornerPiece new_dfl = this.d_b_l_corner;
            CornerPiece new_dbl = this.u_b_l_corner;
            CornerPiece new_ubl = this.u_f_l_corner;

            this.u_f_l_corner = new_ufl;
            this.u_b_l_corner = new_ubl;
            this.d_f_l_corner = new_dfl;
            this.d_b_l_corner = new_dbl;

            // Move edges

            this.u_l_edge.move_r();
            this.d_l_edge.move_r();
            this.f_l_edge.move_r();
            this.b_l_edge.move_r();

            EdgePiece new_ul = this.f_l_edge;
            EdgePiece new_fl = this.d_l_edge;
            EdgePiece new_dl = this.b_l_edge;
            EdgePiece new_bl = this.u_l_edge;

            this.u_l_edge = new_ul;
            this.f_l_edge = new_fl;
            this.d_l_edge = new_dl;
            this.b_l_edge = new_bl;
        }

        private void move_f()
        {

            // Move corners

            this.u_f_r_corner.move_f();
            this.u_f_l_corner.move_f();
            this.d_f_r_corner.move_f();
            this.d_f_l_corner.move_f();

            CornerPiece new_ufr = this.u_f_l_corner;
            CornerPiece new_ufl = this.d_f_l_corner;
            CornerPiece new_dfl = this.d_f_r_corner;
            CornerPiece new_dfr = this.u_f_r_corner;

            this.u_f_r_corner = new_ufr;
            this.u_f_l_corner = new_ufl;
            this.d_f_l_corner = new_dfl;
            this.d_f_r_corner = new_dfr;

            // Move edges

            this.u_f_edge.move_f();
            this.d_f_edge.move_f();
            this.f_r_edge.move_f();
            this.f_l_edge.move_f();

            EdgePiece new_uf = this.f_l_edge;
            EdgePiece new_fl = this.d_f_edge;
            EdgePiece new_df = this.f_r_edge;
            EdgePiece new_fr = this.u_f_edge;

            this.u_f_edge = new_uf;
            this.f_l_edge = new_fl;
            this.d_f_edge = new_df;
            this.f_r_edge = new_fr;
        }

        private void move_b_prime()
        {

            // Move corners

            this.u_b_r_corner.move_f();
            this.u_b_l_corner.move_f();
            this.d_b_r_corner.move_f();
            this.d_b_l_corner.move_f();

            CornerPiece new_ubr = this.u_b_l_corner;
            CornerPiece new_ubl = this.d_b_l_corner;
            CornerPiece new_dbl = this.d_b_r_corner;
            CornerPiece new_dbr = this.u_b_r_corner;

            this.u_b_r_corner = new_ubr;
            this.u_b_l_corner = new_ubl;
            this.d_b_l_corner = new_dbl;
            this.d_b_r_corner = new_dbr;

            // Move edges

            this.u_b_edge.move_f();
            this.d_b_edge.move_f();
            this.b_r_edge.move_f();
            this.b_l_edge.move_f();

            EdgePiece new_ub = this.f_l_edge;
            EdgePiece new_bl = this.d_f_edge;
            EdgePiece new_db = this.b_r_edge;
            EdgePiece new_br = this.u_b_edge;

            this.u_b_edge = new_ub;
            this.b_l_edge = new_bl;
            this.d_b_edge = new_db;
            this.b_r_edge = new_br;
        }

        private void move_u()
        {
            // Move corners

            this.u_f_r_corner.move_u();
            this.u_f_l_corner.move_u();
            this.u_b_r_corner.move_u();
            this.u_b_l_corner.move_u();

            CornerPiece new_ufr = this.u_b_r_corner;
            CornerPiece new_ubr = this.u_b_l_corner;
            CornerPiece new_ubl = this.u_f_l_corner;
            CornerPiece new_ufl = this.u_f_r_corner;

            this.u_f_r_corner = new_ufr;
            this.u_f_l_corner = new_ufl;
            this.u_b_l_corner = new_ubl;
            this.u_b_r_corner = new_ubr;

            // Move edges

            this.u_f_edge.move_u();
            this.u_b_edge.move_u();
            this.u_r_edge.move_u();
            this.u_l_edge.move_u();

            EdgePiece new_uf = this.u_r_edge;
            EdgePiece new_ur = this.u_b_edge;
            EdgePiece new_ub = this.u_l_edge;
            EdgePiece new_ul = this.u_f_edge;

            this.u_f_edge = new_uf;
            this.u_r_edge = new_ur;
            this.u_b_edge = new_ub;
            this.u_l_edge = new_ul;
        }

        private void move_d_prime()
        {
            // Move corners

            this.d_f_r_corner.move_u();
            this.d_f_l_corner.move_u();
            this.d_b_r_corner.move_u();
            this.d_b_l_corner.move_u();

            CornerPiece new_dfr = this.d_b_r_corner;
            CornerPiece new_dbr = this.d_b_l_corner;
            CornerPiece new_dbl = this.d_f_l_corner;
            CornerPiece new_dfl = this.d_f_r_corner;

            this.d_f_r_corner = new_dfr;
            this.d_f_l_corner = new_dfl;
            this.d_b_l_corner = new_dbl;
            this.d_b_r_corner = new_dbr;

            // Move edges

            this.d_f_edge.move_u();
            this.d_b_edge.move_u();
            this.d_r_edge.move_u();
            this.d_l_edge.move_u();

            EdgePiece new_df = this.d_r_edge;
            EdgePiece new_dr = this.d_b_edge;
            EdgePiece new_db = this.d_l_edge;
            EdgePiece new_dl = this.d_f_edge;

            this.d_f_edge = new_df;
            this.d_r_edge = new_dr;
            this.d_b_edge = new_db;
            this.d_l_edge = new_dl;

        }
    }
}
