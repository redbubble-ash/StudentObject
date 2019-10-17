using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentObject
{
    class Student
    {
        private string name;
        private double[] scores;
        private int maxNumberAssigment;
        //public string Name { get; private set; }

        public Student(string name, int maxNumAssign)
        {
            scores = new double[maxNumAssign];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = -1;
            }
            this.name = name;
            this.maxNumberAssigment = maxNumAssign;


        }

        public void ReviewAssignmentSocres()
        {

            if (scores[0] == -1)
            {
                throw new Exception("No score has been reported");
            }
            else
            {
                foreach (int i in scores)
                {
                    Console.Write(i.ToString() + ", ");
                }
                Console.WriteLine();

            }
        }

        public void ReportNewAssignScores(double newScore)
        {
            if (newScore >= 0 && newScore <= 100)
            {
                if (scores[maxNumberAssigment - 1] != -1) throw new Exception("Assignment slots are full, cannot report a new score.");
                else
                {
                    for (int i = 0; i < maxNumberAssigment; i++)
                    {
                        if (scores[i] == -1)
                        {
                            scores[i] = newScore;
                            break;
                        }
                    }


                }

            }
            else throw new Exception("Please report a new score between 0 to 100.");

        }

        public void updateAssignScores(int assigmentNumber, int newScore)
        {
            //if(!scores.Contains(-1)) throw new Exception("")
            if (assigmentNumber - 1 < 0 || assigmentNumber > maxNumberAssigment)
            {
                throw new Exception("Please assign your updated score to a corret assignment.");
            }
            else
            {
                if (scores[assigmentNumber - 1] == -1)
                {
                    throw new Exception("Please report your score first.");
                }
                else
                {
                    scores[assigmentNumber - 1] = newScore;
                }
            }


        }


    }

}

