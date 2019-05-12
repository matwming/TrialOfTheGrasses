namespace leetcodesln
{
    public class RobotBoundedInCircle
    {
        public bool IsRobotBounded(string instructions)
        {
            var r = new RobotForThis();

            for (int i = 0; i < 4; i++)
            {
                foreach (var chr in instructions)
                {
                    r.Move(chr);
                }
            }


            if (r.Initial[0] == 0 && r.Initial[1] == 0) return true;
            else return false;
        }


    }

    class RobotForThis
    {
        public int[] Initial { get; set; } = new int[] { 0, 0 };

        public string Dirction { get; set; } = "N";

        public void Move(char instruction)
        {
            switch (instruction)
            {
                case 'G':
                    Go(Dirction);
                    break;
                case 'L':
                    ChangeDirctionL();
                    break;
                case 'R':
                    ChangeDirctionR();
                    break;
            }
        }

        private void ChangeDirctionR()
        {
            switch (Dirction)
            {
                case "N":
                    Dirction = "E";
                    break;
                case "W":
                    Dirction = "N";
                    break;
                case "S":
                    Dirction = "W";
                    break;
                case "E":
                    Dirction = "S";
                    break;
            }
        }

        private void ChangeDirctionL()
        {
            switch (Dirction)
            {
                case "N":
                    Dirction = "W";
                    break;
                case "W":
                    Dirction = "S";
                    break;
                case "S":
                    Dirction = "E";
                    break;
                case "E":
                    Dirction = "N";
                    break;
            }
        }

        private void Go(string dirction)
        {
            switch (dirction)
            {
                case "N":
                    Initial[1]++;
                    break;
                case "W":
                    Initial[0]--;
                    break;
                case "S":
                    Initial[1]--;
                    break;
                case "E":
                    Initial[0]++;
                    break;
            }
        }
    }

}
