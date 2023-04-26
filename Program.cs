class Quiz
{
   static void Main(string[]args)
   {
    int square = int.Parse(Console.ReadLine());
    int[] Squareblock = new int[square+1];
    bool loop = true;
    
while(loop)
{
    int sell1 = int.Parse(Console.ReadLine());
    int sell2 = int.Parse(Console.ReadLine());
    
    if(sell1 == 0 && sell2 != 0|| sell2 == 0 &&sell1 != 0)
    {
        if(sell1 > 0 )
        {
            Squareblock[sell1] = 1;

        }
        if(sell2 > 0)
        {
            Squareblock[sell2] = 1;
        }
        if(sell1 > 0 || sell1 == sell2)
        {
            
             for(int under = 1;under <= square;under++)
             {
                if(Squareblock[under] == 1)
                {
                    Console.Write("X");
                    
                }
                if(Squareblock[under] == 0)
                {
                    Console.Write("_");
                    
                }
                
             }
        }
        if(sell2 > 0 || sell1 == sell2)
        {
            
             for(int under = 1;under <= square;under++)
             {
                if(Squareblock[under] == 1)
                {
                    Console.Write("X");
                    
                }
                if(Squareblock[under] == 0)
                {
                    Console.Write("_");
                    
                    
                }
                
             }
        }  
       
                    
    }
    if(sell1 > 0 && sell2  > 0)
    {
        loop = false;

    }
    if(sell1 == sell2 )
    {
       if(sell1 > 0 )
        {
            Squareblock[sell1] = 1;

        }
        if(sell2 > 0)
        {
            Squareblock[sell2] = 1;
        }
        if(sell1 == sell2)
        {
            
             for(int under = 1;under <= square;under++)
             {
                if(Squareblock[under] == 1)
                {
                    Console.Write("X");
                    
                }
                if(Squareblock[under] == 0)
                {
                    Console.Write("_");
                    
                }
                
             }
        }
        

    }
    if(sell1 != sell2 && sell1 > 0 || sell2 > 0 && sell1 != sell2)
    {
if(sell1 > 0 )
        {
            Squareblock[sell1] = 1;

        }
        if(sell2 > 0)
        {
            Squareblock[sell2] = 1;
        }
        if(sell1 > 0 || sell1 == sell2)
        {
            
             for(int under = 1;under <= square;under++)
             {
                if(Squareblock[under] == 1)
                {
                    Console.Write("X");
                    
                }
                if(Squareblock[under] == 0)
                {
                    Console.Write("_");
                    
                }
                
             }
        }
        if(sell2 > 0 || sell1 == sell2)
        {
            
             for(int under = 1;under <= square;under++)
             {
                if(Squareblock[under] == 1)
                {
                    Console.Write("X");
                    
                }
                if(Squareblock[under] == 0)
                {
                    Console.Write("_");
                    
                    
                }
                
             }
        }  
    }
    Console.WriteLine("");
}
   }
   
   
}
   