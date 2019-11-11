using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class WalkingRobotSimulation
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            var robot = new Robot();
            var maxEuclideanDistant = 0;

            foreach (var ob in obstacles)
            {
                robot.Obstacles.Add((ob[0] + "," + ob[1]));
            }

            foreach (var command in commands)
            {
                if (command > 0)
                {
                    var counter = 0;
                    while (counter < command)
                    {
                        if (!robot.Move()) break;
                        var currentDistant = robot.Coordinate.x * robot.Coordinate.x + robot.Coordinate.y * robot.Coordinate.y;
                        maxEuclideanDistant = maxEuclideanDistant > currentDistant ? maxEuclideanDistant : currentDistant;
                        ++counter;
                    }
                }
                else
                {
                    robot.ChangeDirection(command);
                }
            }
            return maxEuclideanDistant;
        }
    }

    class Robot
    {
        public string CurrentDirection { get; set; } = "N";
        public (int x, int y) Coordinate { get; set; } = (0, 0);
        public HashSet<string> Obstacles { get; set; } = new HashSet<string>();

        public void ChangeDirection(int command)
        {
            if ("N".Equals(CurrentDirection))
            {
                switch (command)
                {
                    case -2:
                        CurrentDirection = "W";
                        break;
                    case -1:
                        CurrentDirection = "E";
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            else if ("W".Equals(CurrentDirection))
            {
                switch (command)
                {
                    case -2:
                        CurrentDirection = "S";
                        break;
                    case -1:
                        CurrentDirection = "N";
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            else if ("S".Equals(CurrentDirection))
            {
                switch (command)
                {
                    case -2:
                        CurrentDirection = "E";
                        break;
                    case -1:
                        CurrentDirection = "W";
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            else if ("E".Equals(CurrentDirection))
            {
                switch (command)
                {
                    case -2:
                        CurrentDirection = "N";
                        break;
                    case -1:
                        CurrentDirection = "S";
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public bool Move()
        {
            switch (CurrentDirection)
            {
                case "N":
                    if (Obstacles.Contains(Coordinate.x + "," + (Coordinate.y + 1))) return false;
                    Coordinate = (Coordinate.x, Coordinate.y + 1);
                    break;
                case "E":
                    if (Obstacles.Contains((Coordinate.x + 1) + "," + Coordinate.y)) return false;
                    Coordinate = (Coordinate.x + 1, Coordinate.y);
                    break;
                case "W":
                    if (Obstacles.Contains((Coordinate.x - 1) + "," + Coordinate.y)) return false;
                    Coordinate = (Coordinate.x - 1, Coordinate.y);
                    break;
                case "S":
                    if (Obstacles.Contains(Coordinate.x + "," + (Coordinate.y - 1))) return false;
                    Coordinate = (Coordinate.x, Coordinate.y - 1);
                    break;
                default:
                    throw new ArgumentException();
            }
            return true;
        }
    }
}
