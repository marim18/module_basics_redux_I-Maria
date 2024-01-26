namespace exam1
{
    class Car
    {
        public int YPos { get; set; }
        public int XPos { get; set; }
        public string Icon { get; set; }
        public int direction = 0;

    };
    class Map
    {
        public string MapLayout { get; set; }
        public int[,] Goal { get; set; }
        public int Lim1 { get; set; }
        public int Lim2 { get; set; }
    };

    #region Basic functions
class functions{
    void MoveChain(Map map, Car car)
    {
        while (!AtGoal())
        {
            if (Peek(car, map))
            {
                Move();
            }
            else
            {
                Turn();
            }
        }
        console.WriteLine("you made it");
    }

    void tilepicker(int direction, int tempx, int tempy)
    {
        if (direction == 0)
        {
            tempx++;
        }
        else if (direction == 1)
        {
            tempy++;
        }
        else if (direction == 2)
        {
            tempx--;
        }
        else if (direction == 3)
        {
            tempy--;
        }
        else
        {
            Console.WriteLine("Direction variable is weird");
        }
    }

    void Move(int direction, Car car)
    {
        tilepicker(car.direction, car.XPos, car.ypos);

        Console.WriteLine("current pos is" + car.YPos + car.xpos);
    }

    void Turn(int direction)
    {
        if (direction <= 3)
        {
            direction++;
        }
        else
        {
            direction = 0;
        }
    }

    bool Peek(Car car, Map map)
    {
        int tempy = car.ypos;
        int tempx = car.xpos;
        tilepicker(car.direction, tempx, tempy);
        if (map.maplayout[tempy, tempx] == "")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    bool AtGoal()
    {
        if (xpos == Map.goal[0] && ypos == Map.goal[1])
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
#endregion
}