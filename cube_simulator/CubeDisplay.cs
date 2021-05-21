using System;
namespace cube_simulator
{
    public interface CubeDisplay
    {
        public void update(Cube cube);

        public System.Collections.Generic.List<Move> get_moves();
    }
}
