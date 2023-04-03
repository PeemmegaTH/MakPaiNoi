class ArrayMoment {


    // static int check(int a,int b){
    //     return;
    // }

    static void Swap(ref int a , ref int b){
        int tmp = b;
        b = a;
        a = tmp;
    }
    static void Main(string[] args){
        
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

        //Console.Write(" is ever number.");

    }
}