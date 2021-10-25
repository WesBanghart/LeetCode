using System;
using System.Collections.Generic;

namespace AsteroidCollision
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Implement with stacks
            //TODO: Improve Space complexity of current sln
            Solution sln = new Solution();

            var ast1 = new[] {5, 10, -5};
            var ast2 = new[] {8, -8};
            var ast3 = new[] {10, 2, -5};
            var ast4 = new[] {-2, -1, 1, 2};

            var result1 = sln.AsteroidCollision(ast1);
            var result2 = sln.AsteroidCollision(ast2);
            var result3 = sln.AsteroidCollision(ast3);
            var result4 = sln.AsteroidCollision(ast4);
        }
    }

    public class Solution {
        public int[] AsteroidCollision(int[] asteroids) 
        {
            /*
             * Try this:
             * Given the array, move left to right, calculate if index i encounters a collision
             * If we do, calculate the next state of the asteroids array
             * If no collisions occur, return asteroid array
             */
            bool collisionOccurred = false;
            for (int i = 0; i < asteroids.Length; i++)
            {
                //Check if asteroid is traveling left or right
                if (asteroids[i] > 0)
                {
                    //Two cases to check, if we are at the end of the array, we do nothing
                    //If we are not, check i+1 element
                    if (i + 1 != asteroids.Length)
                    {
                        if(asteroids[i + 1] < 0)
                        {
                            var collisionSum = asteroids[i + 1] + asteroids[i];
                            //Check for collision
                            if (collisionSum > 0)
                            {
                                //Pos asteroid wins
                                asteroids[i + 1] = 0;
                            }
                            else if (collisionSum < 0)
                            {
                                //Neg Asteroid wins
                                asteroids[i] = 0;
                            }
                            else
                            {
                                //Both lose
                                asteroids[i] = 0;
                                asteroids[i + 1] = 0;
                            }

                            collisionOccurred = true;
                            i++;
                        }
                    }
                }

                //Check if asteroid is traveling left or right
                else if (asteroids[i] < 0)
                {
                    //Two cases to check, if we are at the end of the array, we do nothing
                    //If we are not, check i+1 element
                    if (i != 0)
                    {
                        if(asteroids[i - 1] > 0)
                        {
                            var collisionSum = asteroids[i - 1] + asteroids[i];
                            //Check for collision
                            if (collisionSum > 0)
                            {
                                //Pos asteroid wins
                                asteroids[i + 1] = 0;
                            }
                            else if (collisionSum < 0)
                            {
                                //Neg Asteroid wins
                                asteroids[i] = 0;
                            }
                            else
                            {
                                //Both lose
                                asteroids[i] = 0;
                                asteroids[i + 1] = 0;
                            }
                            i++;
                            collisionOccurred = true;
                        }
                        
                    }
                }
            }
            if (!collisionOccurred)
            {
                return asteroids;
            }
            //If we had a collision, recalibrate our state: asteroids and return (we indicated destroyed asteroids with zero)
            var newAsteroidArray = new List<int>();
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (asteroids[i] != 0)
                {
                    newAsteroidArray.Add(asteroids[i]);
                }
            }

            return AsteroidCollision(newAsteroidArray.ToArray());
        }
    }
}
