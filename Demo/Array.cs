class Store
{

    public void JaggedArray()
    {
        try
        {
            int[][] rubix = new int[3][]
            {
                new int[2]{10,20},
                new int[5]{30,40,50,60,70},
                new int[1]{80}
            };
        // Console.WriteLine(rubix[1][0]); // 30
        // Console.WriteLine(rubix[0][1]);  // 20
        // Console.WriteLine(rubix[2][3]);  // ex
        // Console.WriteLine(rubix[3][0]);  // ex

        for(int i=0;i<rubix.Length;i++)  //iterate over rows
        {
            for(int j=0;j<rubix[i].Length;j++)  //iterate over column
            {
                Console.WriteLine(rubix[i][j]);
            }
        }
        }
            catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
     }
        }
    }

    // public void MultiDisplay()
    // {
    //     try
    //     {
    //     int[,] matrix=new int[3,4]
    //     {
    //         {10,20,30,40},
    //         {50,60,70,80},
    //         {90,100,110,120}
    //     };

    //     Console.WriteLine(matrix[1,0]); // 50
    //     Console.WriteLine(matrix[0,1]);  // 20
    //     Console.WriteLine(matrix[2,3]);  // 120
    //     Console.WriteLine(matrix[3,0]);  // out of index
    //     }
    //     catch(IndexOutOfRangeException ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
        
        
    
  
//   public void displayItem()
//   {
//     string[] items = new string[5]
//     {
//       "Bread","Butter","Jam","Milk","Eggs"
//     };
//     // items[0] = "Bread";
//     // items[1]="Butter";

//     foreach(var i in items)
//     {
//         Console.WriteLine(i );
//     }

//   }
