using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDataItems
{
    public class Position
    {
        public int X;
        public int Y;
    }

    public class PlayerData
    {
        //For Gameplay
        public string playerID;
        public string GamerTag = string.Empty;
        public Position playerPosition;

        
        public string Password;
    }

    public class BallData
    {

    }



}
