using System;
namespace cube_simulator
{
    public class CubeSimulator
    {
        private Cube cube;

        private CubeDisplay cube_display;

        public CubeSimulator(SimulatorOptions options)
        {
            this.cube = new Cube(options.start_state);
            this.cube_display = options.cube_display;
        }

        public void display()
        {
            cube_display.update(this.cube);
        }

        public void run()
        {
            while(true)
            {
                this.display();
                foreach (Move move in this.cube_display.get_moves())
                {
                    this.cube.move(move);
                }
            }
        }
    }
}
