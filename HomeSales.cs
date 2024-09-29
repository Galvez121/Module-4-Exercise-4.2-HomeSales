using System;

class HomeSales{
    static void Main(){


        double totalSalesD =0, totalSalesE =0 , totalSalesF = 0;
        char salespersonInitial;
        double salesAmount;
        string letter;

        while(true){
            Console.Write("salesperson: ");
            // Convert the first character of the input to lowercase
            letter = Console.ReadLine().ToLower(); 



            if(letter == "z"){
                break;
            }

            if(letter.Length == 1){
                salespersonInitial = letter[0];
            }
            else{
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
                continue;
            }


            // Chech for the salesperson's initial
            if (salespersonInitial == 'd' || salespersonInitial == 'e' || salespersonInitial == 'f'){
                // Enter sales amount
                Console.Write("sales: ");


                if(double.TryParse(Console.ReadLine(), out salesAmount)){
                    if(salespersonInitial == 'd'){
                        totalSalesD += salesAmount;
                    }
                    else if(salespersonInitial == 'e'){
                        totalSalesE += salesAmount;
                    }
                    else if(salespersonInitial == 'f') {
                        totalSalesF += salesAmount;
                    }
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
        double grandTotalSales = totalSalesD + totalSalesE + totalSalesF;

        // Find the highest sales person
        string highestSalesPerson;
        // Compare and assign the highest sales person
        double highestSales = Math.Max(totalSalesD, Math.Max(totalSalesE, totalSalesF));

        if(highestSales == totalSalesD){
            highestSalesPerson = "D";
        }
        else if(highestSales == totalSalesE){
            highestSalesPerson = "E";
        }
        else{
            highestSalesPerson = "F";
        }

        Console.WriteLine($"Grand Total Sales: ${grandTotalSales}");
        Console.WriteLine("Highest Sale: " + highestSalesPerson);
    }
}