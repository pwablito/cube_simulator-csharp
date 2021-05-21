using System;

namespace cube_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cube simulator");

            SimulatorOptions options = new SimulatorOptions();
            options.start_state = StartState.SOLVED;
            options.cube_display = new CLICubeDisplay();

            CubeSimulator simulator = new CubeSimulator(options);

            simulator.run();
        }
    }
}
