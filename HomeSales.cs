using System;

class HomeSales
{
    static void Main()
    {

        double[] totalSales = {0,0,0};
        char[] salespersonInitials = {'d','e','f'};

        double salesAmount;
        string letter;

        while(true)
        {
            Console.Write("salesperson: ");
            // Convert the first character of the input to lowercase
            letter = Console.ReadLine().ToLower(); 



            if(letter == "z"){
                break;
            }

            if(letter.Length == 1 && char.IsLetter(letter[0])){
                // Enter salesperson initial
                char salespersonInitial = letter[0];

                 // Check for the salesperson's initial is in the array salespersonInitials 
                int index = Array.IndexOf(salespersonInitials, salespersonInitial);

                // If the input does not match with d e or f 
                if(index == -1){
                    Console.WriteLine("Error, invalid sales amount, please try again.");
                    continue;
                }
                
                // Enter sales amount
                Console.Write("sales: ");
                if(double.TryParse(Console.ReadLine(), out salesAmount)){
                    // Add the sales amount to the total sales for the respective salesperson
                    totalSales[index] += salesAmount;
                }
                else{
                    Console.WriteLine("Error, invalid sales amount, please try again.");
                    continue;
                }
        
            }
            else{
                // Invalid salesperson initial
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
                continue;
     
            }
        }

        // Calculate the grand total sales
        double grandTotalSales = totalSales[0] + totalSales[1] + totalSales[2];

        // Find the highest sales person
        int highestSalesPerson = 0;
        if(totalSales[1] > totalSales[highestSalesPerson]){
            highestSalesPerson = 1;
        }
        if(totalSales[2] > totalSales[highestSalesPerson]){
            highestSalesPerson = 2;
        }


        Console.WriteLine($"Grand Total Sales: ${grandTotalSales}");
        Console.WriteLine("Highest Sale: " + salespersonInitials[highestSalesPerson].ToString());
     
    }
}