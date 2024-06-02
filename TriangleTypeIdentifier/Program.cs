using System;

class TriangleTypeIdentifier
{
 static void Main()
 {
  // Prompt the user to enter the sides of the triangle
  Console.Write("Enter the length of side 1: ");
  string input1 = Console.ReadLine();
  Console.Write("Enter the length of side 2: ");
  string input2 = Console.ReadLine();
  Console.Write("Enter the length of side 3: ");
  string input3 = Console.ReadLine();

  if (double.TryParse(input1, out double side1) &&
      double.TryParse(input2, out double side2) &&
      double.TryParse(input3, out double side3))
  {
   // Determine the type of the triangle
   string triangleType;

   if (side1 == side2 && side2 == side3)
   {
    triangleType = "Equilateral";
   }
   else if (side1 == side2 || side1 == side3 || side2 == side3)
   {
    triangleType = "Isosceles";
   }
   else
   {
    triangleType = "Scalene";
   }

   // Display the type of the triangle
   Console.WriteLine("The triangle type is: " + triangleType);
  }
  else
  {
   // Invalid input
   Console.WriteLine("Invalid input. Please enter valid numerical values for the sides.");
  }
 }
}

// djdjdd