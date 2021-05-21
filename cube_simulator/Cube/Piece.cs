using System;
namespace cube_simulator
{
    public class Piece
    {
        public Color f_color;
        public Color b_color;
        public Color u_color;
        public Color d_color;
        public Color r_color;
        public Color l_color;

        private void clear_colors()
        {
            this.f_color = Color.BLANK;
            this.b_color = Color.BLANK;
            this.u_color = Color.BLANK;
            this.d_color = Color.BLANK;
            this.r_color = Color.BLANK;
            this.l_color = Color.BLANK;
        }

        public void move_r()
        {
            Color new_f = this.d_color;
            Color new_u = this.f_color;
            Color new_b = this.u_color;
            Color new_d = this.b_color;
            Color new_r = this.r_color;
            Color new_l = this.l_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }

        public void move_r_prime()
        {

            Color new_f = this.u_color;
            Color new_u = this.b_color;
            Color new_b = this.d_color;
            Color new_d = this.f_color;
            Color new_r = this.r_color;
            Color new_l = this.l_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }

        public void move_f()
        {
            Color new_r = this.u_color;
            Color new_d = this.r_color;
            Color new_l = this.d_color;
            Color new_u = this.l_color;
            Color new_f = this.f_color;
            Color new_b = this.b_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }

        public void move_f_prime()
        {
            Color new_r = this.d_color;
            Color new_d = this.l_color;
            Color new_l = this.u_color;
            Color new_u = this.r_color;
            Color new_f = this.f_color;
            Color new_b = this.b_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }

        public void move_u()
        {
            Color new_f = this.r_color;
            Color new_l = this.f_color;
            Color new_b = this.l_color;
            Color new_r = this.b_color;
            Color new_u = this.u_color;
            Color new_d = this.d_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }

        public void move_u_prime()
        {
            Color new_f = this.l_color;
            Color new_l = this.b_color;
            Color new_b = this.r_color;
            Color new_r = this.f_color;
            Color new_u = this.u_color;
            Color new_d = this.d_color;

            this.clear_colors();

            this.f_color = new_f;
            this.u_color = new_u;
            this.b_color = new_b;
            this.d_color = new_d;
            this.r_color = new_r;
            this.l_color = new_l;
        }
    }

}
