using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    
    class Game
    {
        int size;
        int[,] map;
        int space_x, space_y;
        static Random rand = new Random();
        
        public bool check;

        public Game (int size)
        {
            if (size < 2) size = 2;
            if (size > 9) size = 9;
            this.size = size;
            map = new int[size, size];
            
        }

        public void start()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map[x, y] = coords_to_position(x, y);
            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y] = -1;

        }

        public void shift (int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
            { 
                check = false;return;
            }
            else
            {
                map[space_x, space_y] = map[x, y];
                map[x, y] = -1;
                space_x = x;
                space_y = y;
                
                check = true;
            }
            
        }
        

        public void shift_random()
        {
            //shift(rand.Next(0, size * size));
            int a = rand.Next(0, 4);
            int x = space_x;
            int y = space_y;
            switch(a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }
            shift(coords_to_position (x, y));
        }

        public bool check_numbers()
        {
            if (!(space_x == size - 1 && space_y == size - 1))
                return false;
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (map[x, y] != coords_to_position(x, y))
                            return false;

            return true;

        }

        public int get_number (int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return map[x, y];
        }

        private int coords_to_position (int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }

        private void position_to_coords(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }
    }
}
