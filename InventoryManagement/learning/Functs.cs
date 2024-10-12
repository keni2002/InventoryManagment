namespace InventoryManagement.learning;

public class Functs
{
    //Void method (procedure)
    public void TurnOnTheLight()
    {
        bool lightOn = false;
        if (lightOn)
            return;
        //functSWitchOn
        lightOn = true;
        
    }
    //Overload 
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public float Sum(float a, float b)
    {
        return a + b;
    }
    //Local Function
    public void GenerateBill(string idBill)
    {
        string file = GetFileName(idBill);
        //here it'll implement the process to allow
        //to deal the bill data and insert it in a file
        string GetFileName(string idB)
        {
            return $"Bill-{idB}-{DateTime.Now:yyyyMMdd}.pdf";
        }
    }
    
    //TUPLES
    //useful for return two or more values in a function
    public void theTuples()
    {
            (int, int) myVar;
            (int,int,int,string) coordinate = (0, 0, 0, "origin");
            //if not specify the name then it is Item<index>
            coordinate.Item1 = 0;
            coordinate.Item2 = 0;
            coordinate.Item3 = 0;
            //but u can specify with name
            (int x, int y, int z, string Name) newCoordinate;
            newCoordinate.x = 0;
            newCoordinate.y = 0;
            newCoordinate.z = 0;
            newCoordinate.Name = "miau";
            
            //using funct below
            var result = SumDiff(5, 3);
            Console.WriteLine("Sum: "+result.sum);
            Console.WriteLine("REST: "+result.diff);
            
            //using below but now I use Distructuring 
            (var sum,var dif) = SumDiff(5, 3);
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Diff: "+dif);
            //its FUNNY this is possible as well
            var (more, less) = SumDiff(2, 3);
            //or
            int suma,difer;
            (suma,difer) = SumDiff(5, 3);
            

    }
    //BUT the truly and good usage is in functions
    public (int sum, int diff) SumDiff(int a, int b)
    {
        int sum = a + b;
        int diff = a-b;
        return (sum, diff);
    }
    
    

}