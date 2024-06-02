using System;

class GradeCalculator
{
 static void Main()
 {
  // Prompt the user to enter a numerical grade this is from 0 to 100
  Console.Write("Please input a numeric grade ranging from 0 to 100: ");
  string input = Console.ReadLine();


  if (double.TryParse(input, out double grade))
  {
   // check if the grade is within the correct range
   if (grade >= 0 && grade <= 100)
   {
    string gradeClassification;

    if (grade >= 90)
    {
     gradeClassification = "A";
    }
    else if (grade >= 80)
    {
     gradeClassification = "B";
    }
    else if (grade >= 70)
    {
     gradeClassification = "C";
    }
    else if (grade >= 60)
    {
     gradeClassification = "D";
    }
    else
    {
     gradeClassification = "F";
    }

    // Display the grade
    Console.WriteLine("Your current grade is: " + gradeClassification);
   }
   else
   {
    // Grad is not within the range
    Console.WriteLine("Your grade must be between 0 and 100.");
   }
  }
  else
  {
   // Invalid input
   Console.WriteLine("Invalid input. Please enter a numerical grade.");
  }
 }
}