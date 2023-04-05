class ArrayMoment {

    static void Swap(ref int a , ref int b){
        int tmp = b;
        b = a;
        a = tmp;
    }

    static void Main(string[] args){
        
        // string[,] sussy = new string[3,3];

        
        // for (int row = 0;row < 3; row++){
        //     for (int colume = 0;colume < 3; colume++){
        //         Console.WriteLine(row + " " + colume );
        //         sussy[row,colume] = "#";
        //     }
        //     Console.WriteLine();
        // }

        // for (int row = 0;row < 3; row++){
        //     for (int colume = 0;colume < 3; colume++){
        //         Console.Write(sussy[row,colume] + " ");
        //     }
        //     Console.WriteLine();
        // }

        Console.Write("Input Max Array: ");
        int Max = int.Parse(Console.ReadLine());
        int[] table = new int[Max];

        for (int i = 0;i < Max;i++){
            Console.Write("Input " + (i + 1) + " Number:");
            table[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0;i < Max; i++){
            for (int v = 0;v < Max - 1; v++){
                if (table[v] < table[v+1]){
                    Swap(ref table[v],ref table[v+1]);
                }
            }
        }

        for (int i = 0;i < Max;i++){
            Console.Write((table[i]) + " ");
        }

    }
}