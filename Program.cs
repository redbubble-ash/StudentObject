using System;

namespace StudentObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student adam = new Student("Adam", 5);
            adam.ReportNewAssignScores(89.50);
            //adam.ReviewAssignmentSocres();
            adam.updateAssignScores(1, 90);
            adam.ReportNewAssignScores(95);
            adam.ReviewAssignmentSocres();



            Student shawn = new Student(null, 10);
            //shawn.ReviewAssignmentSocres();
            shawn.ReportNewAssignScores(-100);
            //shawn.updateAssignScores(2, 100);




        }
    }
}
