using System;

class TicketPriceCalculator
{
 static void Main()
 {
  // Prompt the user to enter their age
  Console.Write("Enter your age: ");
  string input = Console.ReadLine();

  if (int.TryParse(input, out int age))
  {
   // Determine the ticket price based on the age
   int ticketPrice;

   if (age <= 12 || age >= 65)
   {
    ticketPrice = 7;
   }
   else
   {
    ticketPrice = 10;
   }

   // Display the ticket price
   Console.WriteLine("Ticket price is: GHC " + ticketPrice);
  }
  else
  {
   // Invalid input
   Console.WriteLine("Invalid input. Please enter a valid age.");
  }
 }
}