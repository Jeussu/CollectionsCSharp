# CollectionsCSharp
93. Arrays Intro

Trong C#, mảng là tập hợp các phần tử có cùng kiểu dữ liệu, được sắp xếp theo thứ tự. Mảng cung cấp một cách thuận tiện để lưu trữ và quản lý nhiều giá trị cùng loại dưới một tên biến duy nhất. Mỗi phần tử trong một mảng được xác định bởi một chỉ số, bắt đầu từ 0 cho phần tử đầu tiên và tăng thêm 1 cho mỗi phần tử tiếp theo.

Dưới đây là tổng quan về cách làm việc với mảng trong C#:

1. **Khai báo mảng:**
    Bạn khai báo một mảng bằng cách chỉ định kiểu dữ liệu của các phần tử của nó, theo sau là tên biến và kích thước của mảng trong ngoặc vuông.

int[] numbers = new int[5]; // Declares an integer array with 5 elements

2. **Khởi tạo mảng:**
    Bạn có thể khởi tạo một mảng trong khi khai báo hoặc sau này bằng cách sử dụng các câu lệnh gán.

int[] numbers = { 1, 2, 3, 4, 5 }; // Initializing array during declaration

3. **Truy cập các phần tử mảng:**
    Bạn có thể truy cập các phần tử mảng bằng cách sử dụng chỉ mục của chúng. Lập chỉ mục bắt đầu từ 0.

int secondNumber = numbers[1]; // Accesses the second element (index 1)

4. **Độ dài mảng:**
    Bạn có thể lấy độ dài của một mảng bằng cách sử dụng thuộc tính `Length`.

int length = numbers.Length; // Gets the length of the array

5. **Lặp qua mảng:**
    Bạn có thể sử dụng các vòng lặp để duyệt qua các phần tử của mảng.

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

6. **Mảng đa chiều:**
    C# cũng hỗ trợ mảng nhiều chiều, cho phép bạn tạo mảng có nhiều hơn một chiều.

int[,] matrix = new int[3, 3]; // 2D array with 3 rows and 3 columns

7. **Mảng lởm chởm:**
    Mảng lởm chởm là một mảng của các mảng, trong đó mỗi phần tử là một mảng.

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

8. **Phương thức mảng:**
    Mảng trong C# cung cấp các phương thức khác nhau như `Sort`, `Reverse`, `IndexOf`, v.v., để thực hiện các thao tác chung trên mảng.

Array.Sort(numbers); // Sorts the array in ascending order

Mảng là một cấu trúc dữ liệu cơ bản trong C# và được sử dụng rộng rãi để lưu trữ và thao tác dữ liệu trong các tình huống khác nhau.

95. Declaring and Initializing Arrays and the Length Property

95. Khai báo và khởi tạo mảng và thuộc tính độ dài

Khai báo và khởi tạo mảng, cũng như sử dụng thuộc tính `Length`, là một khái niệm thiết yếu trong lập trình C#. Hãy đi sâu vào từng khía cạnh này một cách chi tiết hơn.

1. **Khai báo và khởi tạo mảng:**
    Mảng được khai báo bằng cách chỉ định kiểu dữ liệu của các phần tử theo sau là tên mảng và kích thước của mảng trong ngoặc vuông. Bạn cũng có thể khởi tạo mảng trong khi khai báo bằng cách cung cấp các giá trị được đặt trong dấu ngoặc nhọn.

// Declaring and initializing an integer array with values
int[] numbers = { 10, 20, 30, 40, 50 };

    Nếu bạn muốn khai báo một mảng mà không khởi tạo nó ngay lập tức, bạn có thể sử dụng từ khóa `new`:

// Declaring an integer array without initializing
int[] scores;

2. **Truy cập các phần tử mảng:**
    Các phần tử mảng được truy cập bằng cách sử dụng chỉ mục của chúng, bắt đầu từ 0 cho phần tử đầu tiên.

int firstNumber = numbers[0]; // Accesses the first element (index 0)
int thirdNumber = numbers[2]; // Accesses the third element (index 2)

3. **Thuộc tính Độ dài:**
    Thuộc tính `Length` cung cấp số phần tử trong mảng. Nó hữu ích để xác định kích thước của mảng khi lặp qua nó.

int arrayLength = numbers.Length; // Returns the length of the array (5 in this case)

    Bạn có thể sử dụng thuộc tính `Length` trong các vòng lặp để lặp qua toàn bộ mảng:

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Những khái niệm này là cơ bản khi làm việc với mảng trong C#. Chúng cho phép bạn tạo, khởi tạo, truy cập và thao tác các bộ sưu tập dữ liệu một cách hiệu quả.
96. Foreach Loops

Vòng lặp `foreach` trong C# được sử dụng để lặp qua các tập hợp các mục, chẳng hạn như mảng, danh sách và các đối tượng có thể đếm được khác. Nó đơn giản hóa quá trình lặp qua các phần tử bằng cách tự động quản lý biến lặp và cung cấp một cú pháp rõ ràng. Đây là cách bạn sử dụng vòng lặp `foreach`:

foreach (dataType element in collection)
{
    // Code to execute for each element
}

- `dataType`: Kiểu dữ liệu của các phần tử trong tập hợp.
- `element`: Một biến đại diện cho phần tử hiện tại được lặp lại.
- `collection`: Tập hợp các mục để lặp lại.

Đây là một ví dụ về việc sử dụng vòng lặp `foreach` để lặp qua một mảng:

int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int num in numbers)
{
    Console.WriteLine(num);
}

Trong ví dụ này, biến `num` nhận giá trị của từng phần tử trong mảng `numbers` khi vòng lặp lặp lại.

Bạn cũng có thể sử dụng `foreach` với các loại bộ sưu tập khác, như danh sách:

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine("Hello, " + name);
}

Vòng lặp `foreach` tự động quản lý biến lặp và đảm bảo rằng vòng lặp thực thi cho từng phần tử trong tập hợp. Đó là một cách thuận tiện và dễ đọc để làm việc với các bộ sưu tập trong C#.

My Code:

using System.ComponentModel.DataAnnotations;

namespace ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }

            /* Create an array with 5 of your best friends and create a foreach 
             * loop which greets all of them in c#
            */

            string[] bestFriends = { "Vinh", "Nga", "Thang", "Lan", "Hien" };
            Console.WriteLine("Greetings to my best friends:");
            foreach (string friends in bestFriends)
            {
                Console.WriteLine("Hello, " + friends + "!");
            }

            Console.ReadKey();
        }
    }
}

98. Multi Dimensional Arrays

98. Mảng đa chiều

Mảng nhiều chiều trong C# là mảng có nhiều hơn một chiều. Loại mảng nhiều chiều phổ biến nhất là mảng hai chiều, thường được gọi là ma trận. Tuy nhiên, bạn cũng có thể có các mảng có ba chiều trở lên. Mảng nhiều chiều rất hữu ích để biểu diễn dữ liệu trong cấu trúc dạng lưới, chẳng hạn như bảng giá trị.

Đây là cách bạn có thể khai báo và làm việc với mảng nhiều chiều trong C#:

1. **Mảng hai chiều (Ma trận):**

int[,] matrix = new int[3, 3]; // Declares a 3x3 matrix

// Initializing values
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

// Accessing values
int value = matrix[1, 1]; // Gets the value 5

2. **Mảng ba chiều:**

int[,,] threeDArray = new int[2, 3, 4]; // Declares a 2x3x4 3D array

// Initializing values
threeDArray[0, 0, 0] = 1;
threeDArray[0, 0, 1] = 2;
// ...

// Accessing values
int value = threeDArray[1, 2, 3]; // Gets the value at index [1, 2, 3]

3. **Mảng răng cưa (Mảng của các mảng):**

int[][] jaggedArray = new int[3][]; // Declares a jagged array with 3 rows

// Initializing sub-arrays
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

// Accessing values
int value = jaggedArray[1][0]; // Gets the value 4

Trong một mảng nhiều chiều, mỗi chiều được phân tách bằng dấu phẩy trong dấu ngoặc vuông. Bạn có thể truy cập các phần tử bằng cách sử dụng các chỉ số và mỗi chỉ số tương ứng với vị trí dọc theo mỗi thứ nguyên.

Hãy nhớ rằng các mảng nhiều chiều có thể trở nên phức tạp hơn để quản lý khi số lượng kích thước tăng lên. Tùy thuộc vào trường hợp sử dụng của bạn, bạn cũng có thể cân nhắc sử dụng các cấu trúc dữ liệu khác như danh sách hoặc bộ sưu tập để linh hoạt hơn.
https://learn.microsoft.com/vi-vn/dotnet/csharp/programming-guide/arrays/multidimensional-arrays


My Code: 
namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3,}, // row 0
                {4, 5, 6,}, // row 1
                {7, 8, 9} // row 2
            };

            Console.WriteLine("Cental value is {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" }, // 0-0
                    {"012","011" }, // 0-1
                    {"Hi there","What's up" } // 0-2
                },
                {
                    {"100","101" }, // 1-0
                    {"110","113" }, // 1-1
                    {"Another one","Last entry" } // 1-2
                }
            };

            Console.WriteLine("The value is {0}", array3D[1, 2, 1]);

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };

            array2DString[1, 1] = "chicken";

            // Rank return the amount of dimensions
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", dimensions);

            Console.ReadKey();
        }
    }
}


99. Nested For Loops And 2D Arrays

99. Vòng lặp lồng nhau và mảng 2D

Chắc chắn rồi, chúng ta hãy khám phá các vòng lặp lồng nhau và mảng 2D trong C#.

**Vòng lặp lồng nhau:**
Một vòng lặp lồng nhau là một vòng lặp bên trong một vòng lặp khác. Chúng rất hữu ích để lặp qua các cấu trúc đa chiều như mảng 2D.

Đây là một ví dụ về việc sử dụng các vòng lặp for lồng nhau để lặp qua một mảng 2D:

            int[,] matrix = new int[3, 3] 
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int row = 0; row < 3; row++) // conditions is less than 3 row not less than 3
            {
                for (int col = 0; col < 3; col++) // conditions is less than 3 column not less than 3
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }							
**Mảng 2D:**
Mảng 2D là một mảng của các mảng, trong đó mỗi phần tử cũng là một mảng. Nó giống như một bảng có hàng và cột.

Trong ví dụ trên, `ma trận` là một mảng 2D trong đó `ma trận[hàng, cột]` cung cấp cho bạn giá trị tại một hàng và cột cụ thể.

Khi bạn chạy mã, nó sẽ xuất ra:

1 2 3
4 5 6
7 8 9

Các vòng lặp for lồng nhau lặp qua từng hàng và cột của mảng 2D, in ra các giá trị.

Trong ngữ cảnh của mảng 2D, các vòng lặp lồng nhau thường được sử dụng để lặp qua từng phần tử của mảng và thực hiện một số thao tác trên chúng.

Vui lòng sửa đổi kích thước mảng và nội dung để thử nghiệm với các tình huống khác nhau!

101. Challenge - Tic Tac Toe

namespace TicTacToe_Project
{
    internal class Program
    {
        // the PlayField
        static char[,] playField =
        {
            {'1', '2', '3' }, // row 0
            {'4', '5', '6' }, // row 1
            {'7', '8', '9' }  // row 2
        };



        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            // Run code as long as the program runs
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();
                #region
                // check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                         || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                         || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                         || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))


                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }

                        // TODO reset field
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDRAW!");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }


                #endregion


                #region
                // Test if field is already taken
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion
            } while (true);
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
        {
            {'1', '2', '3' }, // row 0
            {'4', '5', '6' }, // row 1
            {'7', '8', '9' }  // row 2
        };
            playField = playFieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("      |      |     ");
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("      |      |      ");
            turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign; break;
                case 2:
                    playField[0, 1] = playerSign; break;
                case 3:
                    playField[0, 2] = playerSign; break;
                case 4:
                    playField[1, 0] = playerSign; break;
                case 5:
                    playField[1, 1] = playerSign; break;
                case 6:
                    playField[1, 2] = playerSign; break;
                case 7:
                    playField[2, 0] = playerSign; break;
                case 8:
                    playField[2, 1] = playerSign; break;
                case 9:
                    playField[2, 2] = playerSign; break;

            }

        }
    }
}


Eplaint code:
Chắc chắn! Chúng ta hãy xem từng bước mã và giải thích từng dòng:

namespace TicTacToe_Project
{
    internal class Program
    {
        // the PlayField
        static char[,] playField =
        {
            {'1', '2', '3' }, // row 0
            {'4', '5', '6' }, // row 1
            {'7', '8', '9' }  // row 2
        };
- Mã này khởi tạo `playField` dưới dạng mảng ký tự (char) 2D đại diện cho lưới Tic Tac Toe. Cấu hình ban đầu của lưới được đặt bằng các số từ 1 đến 9.

static int turns = 0;

static void Main(string[] args)
{
    int player = 2; // Player 1 starts
    int input = 0;
    bool inputCorrect = true;

    // Run code as long as the program runs
    do
    {
- Biến `turns` được khởi tạo để theo dõi số lượt chơi. Phương thức `Main` bắt đầu tại đây, thiết lập các biến để quản lý lượt chơi, đầu vào và xác thực đầu vào.

if (player == 2)
{
    player = 1;
    EnterXorO('O', input);
}
else if (player == 1)
{
    player = 2;
    EnterXorO('X', input);
}

- Mã luân phiên giữa người chơi 1 và 2 (X và O) với mỗi lần lặp của vòng lặp. Phương thức `EnterXorO` được gọi để xử lý việc nhập X hoặc O dựa trên lựa chọn của người chơi.

SetField();
- Sau khi người chơi di chuyển, phương thức `SetField` được gọi để hiển thị trạng thái hiện tại của bảng trò chơi.

// Winning condition and draw checks
char[] playerChars = { 'X', 'O' };
foreach (char playerChar in playerChars)
{
    // ...
}
- Phần này kiểm tra điều kiện thắng và hòa. Nó lặp lại thông qua các kết hợp chiến thắng có thể có của hàng, cột và đường chéo. Nếu phát hiện thấy thắng hoặc hòa, thông báo thích hợp sẽ được hiển thị và bảng trò chơi được đặt lại.

// Input handling
do
{
    // ...
} while (!inputCorrect);

- Phần mã này xử lý đầu vào của người chơi. Nó liên tục nhắc người chơi hiện tại nhập số trường đã chọn cho đến khi họ nhập một lựa chọn hợp lệ.

            } while (true) ;
- Vòng lặp `do-while` này đảm bảo trò chơi sẽ tiếp tục vô thời hạn cho đến khi dừng thủ công.

public static void ResetField()
{
    char[,] playFieldInitial =
    {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };
    playField = playFieldInitial;
    SetField();
    turns = 0;
}
- Phương thức `ResetField` khôi phục bảng trò chơi về trạng thái ban đầu và phương thức `SetField` được gọi để hiển thị nó. Số lượt `lượt` được đặt lại về 0.

public static void SetField()
{
    Console.Clear();
    // ...
    turns++;
}

- Phương thức `SetField` xóa bảng điều khiển và hiển thị trạng thái hiện tại của bảng trò chơi. Nó tăng số lượt chơi để theo dõi số lượt chơi.

public static void EnterXorO(char playerSign, int input)
{
    switch (input)
    {
        case 1:
            playField[0, 0] = playerSign; break;
        // ...
        case 9:
            playField[2, 2] = playerSign; break;
    }
}
    }
}
- Phương thức `EnterXorO` lấy `đầu vào` đã chọn và cập nhật vị trí tương ứng trên `playField` bằng ký hiệu của người chơi (X hoặc O).

Mã này thiết lập trò chơi Tic Tac Toe dựa trên bảng điều khiển, xử lý lượt chơi, đầu vào, điều kiện chiến thắng và hiển thị bảng trò chơi. Nó cung cấp giao diện cơ bản để hai người chơi thay phiên nhau chơi trò chơi.

102. Jagged Arrays

102. Mảng lởm chởm

Mảng lởm chởm là mảng nhiều chiều trong đó mỗi "hàng" có thể có độ dài khác nhau. Điều này trái ngược với mảng đa chiều hình chữ nhật trong đó tất cả các hàng có cùng độ dài. Mảng lởm chởm về cơ bản là mảng của mảng.

Dưới đây là ví dụ về cách khai báo và sử dụng mảng lởm chởm trong C#:

using System;

namespace JaggedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array of integers
            int[][] jaggedArray = new int[3][];

            // Initialize the jagged array with arrays of different lengths
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Accessing elements in the jagged array
            Console.WriteLine(jaggedArray[0][1]); // Output: 2
            Console.WriteLine(jaggedArray[1][0]); // Output: 4
            Console.WriteLine(jaggedArray[2][3]); // Output: 9

            // Iterating through the jagged array
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
Trong ví dụ này, `jaggedArray` là một mảng số nguyên có hình răng cưa. Độ dài của các mảng bên trong có thể khác nhau, mang lại sự linh hoạt. Bạn có thể truy cập và thao tác các phần tử trong mảng lởm chởm bằng cách sử dụng chỉ mục của cả mảng bên ngoài và bên trong. Việc lặp qua một mảng lởm chởm yêu cầu các vòng lặp lồng nhau, như trong ví dụ.

My Code: 
namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     index                   0    1    2    3  
            // normal array of type int : [15],[21],[23],[13]
            //     index                       0                        1                    2
            // jagged array of type int : [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]



            // declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][0]);
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);

                for (int j = 0; j < jaggedArray2[i].Length; j++)
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
            }

            Console.ReadKey();

        }
    }
}


103. Jagged Arrays or Multidimensional Arrays?
Mảng lởm chởm hay mảng đa chiều?

Việc sử dụng mảng lởm chởm hay mảng nhiều chiều trong C# tùy thuộc vào yêu cầu cụ thể của chương trình và cấu trúc dữ liệu bạn đang xử lý. Hãy cùng khám phá các đặc điểm của từng loại và khi nào bạn có thể chọn loại này hơn loại kia:

**Mảng đa chiều:**

Mảng nhiều chiều trong C# là mảng hình chữ nhật có số chiều cố định. Ví dụ, mảng 2D là một loại mảng đa chiều phổ biến.

**Ưu điểm của mảng đa chiều:**

1. **Đơn giản**: Mảng đa chiều cung cấp một cách đơn giản hơn để biểu diễn và làm việc với dữ liệu có cấu trúc hình chữ nhật, đều đặn.

2. **Hiệu suất**: Việc truy cập các phần tử trong mảng đa chiều có thể nhanh hơn một chút do vị trí bộ nhớ và khả năng lưu trữ hiệu quả.

**Nhược điểm của mảng đa chiều:**

1. **Kích thước cố định**: Mảng đa chiều có kích thước cố định ở mỗi chiều. Nếu bạn cần sự linh hoạt về số lượng phần tử trong mỗi chiều, mảng lởm chởm có thể phù hợp hơn.

2. **Khởi tạo phức tạp**: Việc khởi tạo mảng đa chiều với dữ liệu có thể phức tạp, đặc biệt đối với các mảng lớn hơn.

**Mảng lởm chởm:**

Mảng lởm chởm trong C# là một mảng gồm nhiều mảng, trong đó mỗi "hàng" có thể có số phần tử khác nhau.

**Ưu điểm của mảng lởm chởm:**

1. **Kích thước thay đổi**: Mảng lởm chởm cho phép các "hàng" khác nhau có độ dài khác nhau. Điều này hữu ích khi cấu trúc dữ liệu không có hình dạng cố định, thông thường.

2. **Tính linh hoạt**: Mảng lởm chởm mang lại sự linh hoạt hơn trong việc quản lý các kích thước dữ liệu khác nhau.

3. **Khởi tạo dễ dàng hơn**: Việc khởi tạo các mảng lởm chởm thường đơn giản hơn vì bạn đang xử lý các mảng có kích thước khác nhau thay vì một lưới cố định.

**Nhược điểm của mảng lởm chởm:**

1. **Hiệu suất**: Việc truy cập các phần tử trong một mảng lởm chởm có thể chậm hơn một chút do có thêm lớp gián tiếp.

2. **Độ phức tạp**: Làm việc với các mảng lởm chởm có thể phức tạp hơn làm việc với các mảng nhiều chiều, đặc biệt là khi xử lý các vòng lặp lồng nhau và quản lý bộ nhớ.

**Khi nào nên sử dụng từng loại:**

- **Mảng đa chiều**: Sử dụng mảng đa chiều khi bạn có dữ liệu có cấu trúc thông thường, cố định và hiệu suất là vấn đề đáng lo ngại. Ví dụ: bàn cờ hoặc ma trận số.

- **Mảng lởm chởm**: Sử dụng mảng lởm chởm khi bạn cần sự linh hoạt về kích thước của các kích thước khác nhau hoặc khi dữ liệu không vừa với cấu trúc thông thường. Ví dụ: khi xử lý các mảng có độ dài khác nhau như danh sách điểm của sinh viên trong các khóa học khác nhau.

Tóm lại, hãy xem xét tính đều đặn của cấu trúc dữ liệu, yêu cầu về hiệu suất và nhu cầu linh hoạt khi lựa chọn giữa mảng lởm chởm và mảng đa chiều. Cả hai loại đều có điểm mạnh và điểm yếu, vì vậy hãy chọn loại phù hợp nhất với nhu cầu cụ thể của chương trình của bạn.



104. Challenge - Jagged Arrays

MyCode:
namespace ChallengeJaggedArrays
{
    internal class Program
    {
        // Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
        // // introduce family member from different families to each other via console
        static void Main(string[] args)
        {
            // Define an array of family members
            string[] vinhFamily = new string[] { "Thanh", "Man", "Vinh", "Trung" };

            // Create a jagged array containing friends and family
            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Vinh", "Hau"},
                new string[]{"Hung", "Son"},
                new string[]{"Su", "Thuong"},
                vinhFamily
            };

            // Introduce family members from different families to each other
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);

            // Wait for user input before exiting
            Console.ReadKey();
        }
    }
}
Giải thích về mã:

1. `namespace ChallengeJaggedArrays`: Xác định namespace cho chương trình.
2. `Chương trình lớp nội bộ`: Xác định lớp chính của chương trình.
3. `static void Main(string[] args)`: Điểm vào của chương trình. Việc thực thi bắt đầu từ đây.
4. `string[] vinhFamily`: Khai báo một mảng có tên `vinhFamily` chứa tên các thành viên trong gia đình.
5. `string[][]friendAndFamily`: Khai báo một mảng lởm chởm có tên `friendsAndFamily`, mảng này sẽ lưu trữ cả bạn bè và thành viên gia đình. Mỗi mảng con chứa hai thành viên.
6. Mảng lởm chởm `friendsAndFamily` được khởi tạo với các mảng con chứa bạn bè và thành viên gia đình.
7. Chương trình giới thiệu các thành viên trong gia đình từ các gia đình khác nhau với nhau bằng câu lệnh `Console.WriteLine`.
8. `Console.ReadKey()`: Đợi người dùng nhập dữ liệu trước khi thoát chương trình.

Mã được cung cấp minh họa cách tạo một mảng lởm chởm, điền vào đó với bạn bè và thành viên gia đình cũng như mô phỏng phần giới thiệu giữa họ bằng cách sử dụng `Console.WriteLine`.

105. Using Arrays As Parameters

Sử dụng mảng làm tham số trong C# là một cách phổ biến và cho phép bạn chuyển mảng sang các phương thức xử lý. Đây là cách bạn có thể sử dụng mảng làm tham số trong C#:

using System;

namespace ArraysAsParameters
{
    class Program
    {
        // Method that takes an array as a parameter
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            // Modify the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }

            Console.WriteLine("Modified array:");
            PrintArray(numbers);
        }
    }
}

Giải thích về mã:

1. `using System;`: Nhập vùng tên `System` để truy cập các tính năng đầu vào/đầu ra tiêu chuẩn.
2. `namespace ArraysAsParameters`: Xác định namespace cho chương trình.
3. `class Program`: Xác định lớp chính của chương trình.
4. `static void PrintArray(int[] arr)`: Khai báo một phương thức có tên `PrintArray` lấy một mảng số nguyên (`int[]`) làm tham số. Phương thức này in ra các phần tử của mảng.
5. Bên trong phương thức `Main`:
    - Một mảng số nguyên có tên `numbers` được khai báo và khởi tạo bằng các giá trị.
    - Mảng ban đầu được in bằng phương thức `PrintArray`.
    - Vòng lặp lặp qua mảng và sửa đổi từng phần tử bằng cách nhân đôi giá trị của nó.
    - Mảng đã sửa đổi được in lại bằng phương thức `PrintArray`.

Khi sử dụng mảng làm tham số, hãy nhớ rằng mảng là kiểu tham chiếu. Bất kỳ thay đổi nào được thực hiện đối với mảng bên trong phương thức sẽ ảnh hưởng đến mảng ban đầu bên ngoài phương thức.

MyCode:
namespace UsingArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of students' grades
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };

            // Call the GetAverage method to calculate the average of grades
            double averageResult = GetAverage(studentsGrades);

            // Declare and initialize an array of happiness values
            int[] happiness = { 2, 3, 4, 5, 6 };

            // Call the SunIsShining method to increase each value in the happiness array by 2
            SunIsShining(happiness);

            // Print the modified happiness array using a foreach loop
            foreach (int y in happiness)
            {
                Console.WriteLine(y);
            }

            // Print the original students' grades using a foreach loop
            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            // Print the calculated average result
            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }

        // Method to calculate the average of an integer array
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            // Calculate the sum of all grades
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            // Calculate the average and return it
            average = (double)sum / size;
            return average;
        }

        // Method to modify each element in an integer array
        static void SunIsShining(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] += 2;
        }
    }
}
Giải thích về mã:

1. `namespace UsageArraysAsParameters`: Khai báo vùng tên cho chương trình.
2. `Chương trình lớp nội bộ`: Lớp chính của chương trình.
3. Bên trong phương thức `Main`:
    - Mảng `studentsGrades` được khai báo và khởi tạo với các giá trị nguyên đại diện cho điểm của học sinh.
    - Phương thức `GetAverage` được gọi với đối số là `studentsGrades` để tính điểm trung bình.
    - Mảng `hạnh phúc` được khai báo và khởi tạo với các giá trị nguyên.
    - Phương thức `SunIsShining` được gọi với đối số là `hạnh phúc` để sửa đổi từng giá trị trong mảng.
    - Mảng `hạnh phúc` đã sửa đổi được in bằng vòng lặp foreach.
    - Mảng `studentsGrades` ban đầu được in bằng vòng lặp foreach.
    - Kết quả trung bình tính toán được in ra.
4. Phương thức `GetAverage`: Phương thức này tính giá trị trung bình của một mảng số nguyên và trả về kết quả.
5. Phương thức `SunIsShining`: Phương thức này sửa đổi từng phần tử trong một mảng số nguyên bằng cách thêm 2 vào nó.

Chương trình trình bày cách sử dụng mảng làm tham số, tính giá trị trung bình và sửa đổi các phần tử mảng thông qua các phương thức.


107. Params Keyword


Trong C#, từ khóa `params` cho phép bạn truyền một số lượng đối số thuộc loại được chỉ định cho một phương thức. Điều này có nghĩa là bạn có thể chuyển 0 hoặc nhiều đối số thuộc một loại cụ thể cho một phương thức mà không cần phải tạo một mảng hoặc danh sách một cách rõ ràng để chứa các đối số đó. Từ khóa `params` đặc biệt hữu ích khi bạn muốn làm cho một phương thức linh hoạt hơn và cho phép nó chấp nhận số lượng đối số thay đổi.

Đây là cú pháp cơ bản về cách sử dụng từ khóa `params`:

public void MyMethod(params DataType[] parameterName)
{
    // Method implementation
}

Dưới đây là ý nghĩa của từng phần cú pháp:

- `public void MyMethod`: Đây là phần khai báo phương thức. Thay thế `MyMethod` bằng tên phương thức của bạn.

- `params`: Đây là từ khóa `params` cho biết bạn sẽ chấp nhận số lượng đối số có thể thay đổi.

- `DataType`: Thay thế bằng kiểu dữ liệu của đối số bạn muốn chấp nhận. Ví dụ: nếu bạn muốn chấp nhận số nguyên, hãy sử dụng `int`.

- `parameterName`: Đây là tên của tham số sẽ chứa số lượng đối số thay đổi. Bạn có thể sử dụng bất kỳ tên biến hợp lệ nào.

Đây là một ví dụ về cách bạn có thể sử dụng từ khóa `params` trong một phương thức:

public int CalculateSum(params int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}

Trong ví dụ này, phương thức `CalculateSum` chấp nhận một số lượng đối số nguyên có thể thay đổi. Bạn có thể gọi phương thức này với số nguyên bằng 0 hoặc nhiều hơn và nó sẽ tính tổng của chúng.

int result1 = CalculateSum(1, 2, 3); // Passes 1, 2, and 3 as arguments
int result2 = CalculateSum(10, 20);   // Passes 10 and 20 as arguments
int result3 = CalculateSum();        // No arguments passed, result3 is 0

Từ khóa `params` đơn giản hóa quá trình truyền một số lượng đối số khác nhau và làm cho các phương thức của bạn sử dụng linh hoạt và thuận tiện hơn.

My code:
using System.ComponentModel.DataAnnotations;

namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');
            ParamsMethod("This", " is", " a", " long", "string ", "I ", "have", " no ", "idea ", "when ", "it's ", "going", " to", " end", " ....");// I can keep going ;)

        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // for each loop to go through the array of objects
            foreach (object obj in stuff)
            {
                // print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
Chắc chắn rồi, hãy chia nhỏ mã từng bước:

1. `using System.ComponentModel.DataAnnotations;`: Dòng này đang nhập không gian tên `System.ComponentModel.DataAnnotations`. Tuy nhiên, trong mã này, nó dường như không được sử dụng nên có thể bị xóa.

2. `int price = 50;`, `float pi = 3.14f;`, `char at = '@';`, `string book = "The Hobbit";`: Các dòng này khai báo và khởi tạo 4 biến có dữ liệu khác nhau các loại: `price` (int), `pi` (float), `at` (char) và `book` (chuỗi).

3. `ParamsMethod2(price, pi, at, book);`: Dòng này gọi phương thức `ParamsMethod2` và chuyển các biến `price`, `pi`, `at`, và `book` làm đối số.

4. `ParamsMethod2("Hello", 5.3, '$');`: Dòng này gọi phương thức `ParamsMethod2` và chuyển vào ba đối số: một chuỗi "Xin chào", một `5.3` kép và một char `'$ ''.

5. `ParamsMethod("This", " is", " a", " long", "string ", "I ", "have", " no ", "idea ", "when ", "it's ", " going", " to", " end", " ....");`: Dòng này gọi phương thức `ParamsMethod` và truyền vào một số lượng đối số chuỗi thay đổi, tạo thành một câu. Điều này thể hiện việc sử dụng từ khóa `params`.

6. `public static void ParamsMethod(params string[] question)`: Đây là phương thức `ParamsMethod`. Nó chấp nhận một số lượng đối số chuỗi khác nhau được biểu thị bằng từ khóa `params`. Bên trong phương thức này, nó lặp qua mảng `sentence` và in từng chuỗi theo sau là một khoảng trắng.

7. `public static void ParamsMethod2(params object[] Stuff)`: Đây là phương thức `ParamsMethod2`. Nó cũng chấp nhận một số lượng đối số có thể thay đổi kiểu `object`. Nó sử dụng vòng lặp `foreach` để lặp qua mảng `stuff` của các đối tượng và in từng đối tượng theo sau là một khoảng trắng.

Tóm lại, mã này thể hiện cách sử dụng từ khóa `params`, cho phép các phương thức chấp nhận số lượng đối số thay đổi. Nó in ra các giá trị của các loại dữ liệu khác nhau được truyền dưới dạng đối số bằng hai phương thức khác nhau, `ParamsMethod` và `ParamsMethod2`.


108. Why would we use Params?
Từ khóa `params` trong C# được sử dụng để tạo các phương thức có thể chấp nhận số lượng đối số thay đổi. Điều này có thể đặc biệt hữu ích trong một số trường hợp:

1. **Tính linh hoạt**: Params cho phép bạn gọi một phương thức với số lượng đối số khác nhau mỗi lần. Điều này có thể làm cho mã của bạn linh hoạt hơn và thích ứng với các tình huống khác nhau.

2. **Mã sạch hơn**: Nó có thể giúp đơn giản hóa mã khi bạn cần chuyển danh sách các mục làm đối số. Thay vì tạo một mảng hoặc một bộ sưu tập một cách rõ ràng, bạn có thể chỉ cần liệt kê các mục trong lệnh gọi phương thức.

3. **Khả năng đọc**: Nó có thể làm cho các lệnh gọi phương thức của bạn dễ đọc hơn, đặc biệt khi bạn truyền một danh sách các giá trị. Điều này có thể làm cho mã của bạn tự ghi lại nhiều tài liệu hơn.

4. **Tránh quá tải**: Nếu không có `params`, bạn có thể cần tạo nhiều phần nạp chồng của một phương thức để xử lý số lượng đối số khác nhau. Với `params`, bạn có thể xử lý tất cả các trường hợp bằng một phương thức duy nhất.

Đây là một ví dụ để minh họa:

// Without params
public int Sum(int a, int b)
{
    return a + b;
}

public int Sum(int a, int b, int c)
{
    return a + b + c;
}

// With params
public int Sum(params int[] numbers)
{
    int result = 0;
    foreach (int num in numbers)
    {
        result += num;
    }
    return result;
}
Trong ví dụ đầu tiên, nếu không có `params`, chúng ta phải tạo nhiều phần nạp chồng của phương thức `Sum` để xử lý số lượng đối số khác nhau. Trong ví dụ thứ hai, với `params`, chúng ta có thể xử lý số lượng đối số bất kỳ theo cách ngắn gọn hơn.

Điều quan trọng cần lưu ý là tham số `params` phải là tham số cuối cùng trong danh sách tham số của phương thức và một phương thức chỉ có thể có một tham số `params`.

109. Getting The Min Value Of Many Given Numbers Using Params

109. Lấy giá trị tối thiểu của nhiều số đã cho bằng cách sử dụng tham số
Bạn có thể sử dụng từ khóa `params` để tạo một phương thức tìm giá trị nhỏ nhất trong số các giá trị đầu vào có thể thay đổi. Đây là một ví dụ về cách thực hiện điều này trong C#:

using System;

namespace MinValueWithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = FindMinValue(5, 2, 9, 1, 7, 3);
            Console.WriteLine("The minimum value is: " + min);
        }

        static int FindMinValue(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("At least one number must be provided.");
            }

            int min = numbers[0]; // Initialize min with the first number

            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num; // Update min if a smaller number is found
                }
            }

            return min;
        }
    }
}
Trong ví dụ này:

1. Chúng tôi xác định một phương thức có tên `FindMinValue` nhận tham số `params` của các số nguyên.

2. Bên trong phương thức, chúng tôi kiểm tra xem mảng đầu vào là `null` hay trống và chúng tôi đưa ra một ngoại lệ nếu không có số nào được cung cấp.

3. Chúng ta khởi tạo biến `min` bằng số đầu tiên từ mảng đầu vào.

4. Chúng tôi lặp qua tất cả các số trong mảng đầu vào và nếu tìm thấy một số nhỏ hơn `min` hiện tại, chúng tôi sẽ cập nhật biến `min`.

5. Cuối cùng, chúng ta trả về giá trị nhỏ nhất tìm được.

Khi bạn gọi `FindMinValue(5, 2, 9, 1, 7, 3);`, nó sẽ trả về `1`, là giá trị nhỏ nhất trong số các số đã cho. Bạn có thể gọi phương thức này với số lượng đối số bất kỳ và nó sẽ tìm giá trị nhỏ nhất trong số đó.

110. Overview Generic and Non-Generic Collections



Trong C#, bộ sưu tập là cấu trúc dữ liệu được sử dụng để lưu trữ và thao tác với các nhóm dữ liệu liên quan. Các bộ sưu tập này có thể được phân loại thành hai loại chính: bộ sưu tập chung và bộ sưu tập không chung.

1. **Bộ sưu tập không chung chung:**
   
    Các bộ sưu tập không chung chung, còn được gọi là bộ sưu tập kế thừa, là một phần của .NET Framework trước khi giới thiệu các bộ sưu tập chung. Các bộ sưu tập này lưu trữ các đối tượng dưới dạng loại `System.Object` (hoặc `object` trong C#). Điều này có nghĩa là chúng có thể lưu trữ bất kỳ loại đối tượng nào, nhưng chúng yêu cầu các thao tác đóng hộp và mở hộp, điều này có thể ảnh hưởng đến hiệu suất và độ an toàn của loại.

    Một số bộ sưu tập không chung chung phổ biến bao gồm:

    - **ArrayList:** Một bộ sưu tập có thứ tự có thể tăng hoặc giảm kích thước một cách linh hoạt. Nó có thể lưu trữ các đối tượng thuộc bất kỳ loại nào.
   
    - **Hashtable:** Tập hợp các cặp khóa/giá trị mà bạn có thể sử dụng khóa để truy cập một giá trị. Nó tương tự như một từ điển nhưng lưu trữ các đối tượng thuộc bất kỳ loại nào.

    - **SortedList:** Tập hợp các cặp khóa/giá trị được sắp xếp. Giống như `Hashtable`, nó có thể lưu trữ các đối tượng thuộc bất kỳ loại nào.

    - **Queue:** Một bộ sưu tập đại diện cho cấu trúc dữ liệu vào trước, ra trước (FIFO).

    - **Stack:** Một bộ sưu tập đại diện cho cấu trúc dữ liệu vào sau, ra trước (LIFO).

2. **Bộ sưu tập chung:**

    Các bộ sưu tập chung đã được giới thiệu trong .NET để mang lại sự an toàn về kiểu và hiệu suất tốt hơn bằng cách loại bỏ nhu cầu mở hộp và mở hộp. Các bộ sưu tập này được định kiểu mạnh, có nghĩa là bạn chỉ định loại phần tử mà chúng có thể lưu trữ khi bạn khai báo chúng.

    Một số bộ sưu tập chung phổ biến bao gồm:

    - **List\<T\>:** Một mảng động có thể lưu trữ các phần tử thuộc loại `T`. Nó cho phép truy cập ngẫu nhiên nhanh chóng và rất hữu ích khi số lượng phần tử không được biết trước.

    - **Dictionary\<K, V\>:** Một tập hợp các cặp khóa/giá trị trong đó `K` là loại khóa và `V` là loại giá trị. Nó cung cấp khả năng tra cứu nhanh bằng phím.

    - **HashSet\<T\>:** Tập hợp các phần tử duy nhất thuộc loại `T`. Nó rất hữu ích khi bạn cần đảm bảo rằng các phần tử là khác biệt.

    - **Queue\<T\>:** Một hàng đợi chung lưu trữ các phần tử thuộc loại `T`. Nó tuân theo nguyên tắc FIFO.

    - **Stack\<T\>:** Một ngăn xếp chung lưu trữ các phần tử thuộc loại `T`. Nó tuân theo nguyên tắc LIFO.

    - **LinkedList\<T\>:** Một danh sách liên kết đôi lưu trữ các phần tử thuộc loại `T`. Nó cho phép chèn và xóa hiệu quả ở bất kỳ vị trí nào trong danh sách.

    - **Queue\<T\>:** Một hàng đợi chung lưu trữ các phần tử thuộc loại `T`.

    - **Stack\<T\>:** Một ngăn xếp chung lưu trữ các phần tử thuộc loại `T`.

    Các bộ sưu tập chung cung cấp sự an toàn về kiểu trong thời gian biên dịch, hiệu suất tốt hơn và mã sạch hơn.

Khi lựa chọn giữa các bộ sưu tập chung và không chung chung, thông thường nên sử dụng các bộ sưu tập chung bất cứ khi nào có thể do tính an toàn về loại và hiệu suất được cải thiện của chúng. Các bộ sưu tập không chung chung chủ yếu được sử dụng trong các tình huống mà bạn cần tương tác với mã kế thừa hoặc khi xử lý các đối tượng thuộc các loại khác nhau.

111. ArrayLists

111. Danh sách mảng

`ArrayList` trong C# là một cấu trúc dữ liệu giống như mảng động được cung cấp bởi .NET Framework, cho phép bạn lưu trữ và thao tác một tập hợp các đối tượng. Nó là một phần của không gian tên `System.Collections`. Không giống như mảng truyền thống, `ArrayList` có thể tự động thay đổi kích thước khi cần để chứa nhiều phần tử hơn. Dưới đây là một số đặc điểm và phương thức chính được liên kết với `ArrayList`:

1. **Định cỡ động:** Một `ArrayList` có thể tự động thay đổi kích thước để chứa nhiều phần tử hơn nếu cần. Bạn không cần phải chỉ định trước kích thước của nó.

2. **Các phần tử không đồng nhất:** Một `ArrayList` có thể lưu trữ các đối tượng thuộc các loại khác nhau vì nó xử lý tất cả các đối tượng như các thể hiện của lớp `System.Object`. Tuy nhiên, điều này có thể dẫn đến các vấn đề liên quan đến kiểu chữ nếu không được sử dụng cẩn thận.

3. **Phương thức và thuộc tính:**
    - `Add(object item)`: Thêm một phần tử vào cuối `ArrayList`.
    - `Insert(int index, object item)`: Chèn một phần tử vào chỉ mục đã chỉ định.
    - `Remove(object item)`: Loại bỏ lần xuất hiện đầu tiên của mục được chỉ định.
    - `RemoveAt(int index)`: Loại bỏ phần tử tại chỉ mục đã chỉ định.
    - `Count`: Lấy số phần tử trong `ArrayList`.
    - `Capacity`: Lấy hoặc đặt số phần tử mà `ArrayList` có thể lưu trữ ban đầu mà không cần thay đổi kích thước.
    - `ToArray()`: Chuyển đổi `ArrayList` thành một mảng đối tượng.

4. **Lặp qua các phần tử:** Bạn có thể lặp qua các phần tử trong `ArrayList` bằng cách sử dụng vòng lặp, chỉ mục `foreach` hoặc các phương thức liệt kê khác.

5. **Cân nhắc về hiệu suất:** Bởi vì `ArrayList` lưu trữ các phần tử dưới dạng tham chiếu `object`, nên nó có thể dẫn đến các thao tác đấm bốc (chuyển đổi loại giá trị thành loại tham chiếu) và bỏ hộp (chuyển đổi loại tham chiếu trở lại loại giá trị) khi làm việc với giá trị các loại. Điều này có thể có tác động hiệu suất.

Đây là một ví dụ cơ bản về việc sử dụng `ArrayList`:

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create an ArrayList
        ArrayList list = new ArrayList();

        // Add elements
        list.Add("Apple");
        list.Add(42);
        list.Add(DateTime.Now);

        // Access elements
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        list.Remove(42);

        Console.WriteLine("\nAfter removing an element:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

Mặc dù `ArrayList` cung cấp tính linh hoạt trong việc lưu trữ các phần tử không đồng nhất, nhưng nó thiếu độ an toàn về kiểu và bạn có thể gặp phải lỗi thời gian chạy nếu cố gắng truy cập các phần tử có kiểu dữ liệu không tương thích. Trong lập trình C# hiện đại, các bộ sưu tập chung như `List<T>` được ưa thích hơn vì chúng mang lại sự an toàn về kiểu và tránh được chi phí về hiệu suất của việc đóng hộp và mở hộp.

112. Lists

112. Danh sách

Trong C#, `Danh sách` là loại bộ sưu tập thường được sử dụng do .NET Framework cung cấp để lưu trữ và quản lý danh sách các mục động. Không giống như `ArrayList`, `List` là một bộ sưu tập chung, nghĩa là nó có thể lưu trữ các phần tử của một kiểu dữ liệu cụ thể, cung cấp sự an toàn cho kiểu và tránh nhu cầu thực hiện các thao tác truyền hoặc đóng hộp/mở hộp rõ ràng. Dưới đây là một số đặc điểm chính và chi tiết cách sử dụng của `List`:

1. **Loại chung:** `Danh sách<T>` là loại chung, trong đó `T` đại diện cho loại phần tử bạn muốn lưu trữ. Ví dụ: bạn có thể có `List<int>` để lưu trữ số nguyên hoặc `List<string>` để lưu trữ chuỗi.

2. **Định cỡ động:** Tương tự như `ArrayList`, `List` có thể tự động thay đổi kích thước để chứa nhiều phần tử hơn nếu cần.

3. **An toàn về loại:** Vì `Danh sách` được gõ mạnh nên nó thực thi an toàn về loại, đảm bảo rằng bạn chỉ có thể thêm các phần tử thuộc loại được chỉ định.

4. **Phương thức và thuộc tính:**
    - `Add(T item)`: Thêm một phần tử vào cuối danh sách.
    - `Insert(int index, T item)`: Chèn một phần tử vào chỉ mục đã chỉ định.
    - `Remove(T item)`: Loại bỏ lần xuất hiện đầu tiên của mục được chỉ định.
    - `RemoveAt(int index)`: Loại bỏ phần tử tại chỉ mục đã chỉ định.
    - `Count`: Lấy số phần tử trong danh sách.
    - `Capacity`: Lấy hoặc đặt số phần tử mà danh sách có thể lưu trữ ban đầu mà không cần thay đổi kích thước.
    - `ToArray()`: Chuyển đổi danh sách thành một mảng có kiểu được chỉ định.

5. **Lặp qua các phần tử:** Bạn có thể lặp qua các phần tử trong `Danh sách` bằng cách sử dụng vòng lặp `foreach`, chỉ mục, truy vấn LINQ hoặc các phương pháp liệt kê khác.

Đây là một ví dụ về việc sử dụng `List`:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>();

        // Add elements
        numbers.Add(42);
        numbers.Add(25);
        numbers.Add(10);

        // Access elements
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Remove an element
        numbers.Remove(25);

        Console.WriteLine("\nAfter removing an element:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
`List<T>` là một bộ sưu tập linh hoạt mang lại hiệu suất và độ an toàn về loại tốt hơn so với các bộ sưu tập không chung chung như `ArrayList`. Nó được sử dụng rộng rãi trong C# cho các tác vụ lưu trữ và thao tác dữ liệu khác nhau.

113. Hashtables

Trong C#, `Hashtable` là loại bộ sưu tập lưu trữ các cặp khóa-giá trị. Đó là một phần của không gian tên `System.Collections` và cung cấp cách liên kết khóa với một giá trị để truy xuất dữ liệu hiệu quả. Dưới đây là một số điểm chính về `Hashtable`:

1. **Bộ lưu trữ cặp khóa-giá trị**: `Hashtable` lưu trữ dữ liệu theo cặp khóa-giá trị. Mỗi khóa là duy nhất trong bộ sưu tập và nó được sử dụng để truy cập giá trị liên quan của nó.

2. **Định cỡ động**: `Hashtable` tự động tăng kích thước khi cần để chứa nhiều phần tử hơn, giúp nó phù hợp với các bộ sưu tập có kích thước thay đổi.

3. **Băm**: Khi bạn thêm một mục vào `Hashtable`, khóa sẽ được băm để tạo chỉ mục nơi lưu trữ giá trị liên quan. Quá trình băm này cung cấp khả năng truy xuất dữ liệu hiệu quả.

4. **Sắp xếp**: Thứ tự của các mục trong `Hashtable` không được đảm bảo. Nếu bạn cần duy trì thứ tự của các mục, bạn có thể muốn sử dụng các loại bộ sưu tập khác như `List` hoặc `Dictionary` (có sẵn trong C# 2.0 trở lên).

5. **Khóa và giá trị rỗng**: Cả khóa và giá trị trong `Hashtable` đều có thể là `null`.

6. **An toàn cho luồng**: `Hashtable` vốn không an toàn cho luồng. Nếu bạn cần sự an toàn của luồng, hãy cân nhắc sử dụng phương thức `Hashtable.Synchronized` để tạo một trình bao bọc được đồng bộ hóa xung quanh nó.

7. **Hiệu suất**: `Hashtable` cung cấp thời gian tra cứu khóa hiệu quả nhờ sử dụng hàm băm.

Đây là một ví dụ về cách sử dụng `Hashtable` trong C#:

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a new Hashtable.
        Hashtable hashtable = new Hashtable();

        // Add key-value pairs to the Hashtable.
        hashtable["one"] = 1;
        hashtable["two"] = 2;
        hashtable["three"] = 3;

        // Access values by key.
        Console.WriteLine("The value associated with 'one' is: " + hashtable["one"]);

        // Check if a key exists.
        if (hashtable.ContainsKey("four"))
        {
            Console.WriteLine("The value associated with 'four' is: " + hashtable["four"]);
        }
        else
        {
            Console.WriteLine("'four' does not exist in the Hashtable.");
        }

        // Iterate through key-value pairs.
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}
Trong ví dụ này, chúng tôi tạo một `Hashtable`, thêm các cặp khóa-giá trị vào đó, truy cập các giá trị theo khóa, kiểm tra sự tồn tại của khóa và lặp qua các cặp khóa-giá trị.

Hãy nhớ rằng bắt đầu từ C# 2.0, bạn nên sử dụng lớp `Dictionary<TKey, TValue>` từ không gian tên `System.Collections.Generic` để lưu trữ cặp khóa-giá trị vì nó mang lại sự an toàn về loại và hiệu suất tốt hơn cho hoạt động mạnh mẽ. - gõ các khóa và giá trị.

My code:

Dưới đây là giải thích về mã C# được cung cấp, mã này sử dụng `Hashtable` để lưu trữ thông tin sinh viên:
using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        // Key - Value
        // Auto - Car
        static void Main(string[] args)
        {
            // Create a Hashtable to store student information.
            Hashtable studentsTable = new Hashtable();

            // Create four Student objects.
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            // Add the student objects to the Hashtable, using the student's ID as the key.
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve an individual student object by knowing their ID.
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // Iterate through all the values (Student objects) in the Hashtable.
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA:{0}", value.GPA);
            }
        }

        // Define a Student class to represent student information.
        class Student
        {
            // Properties for student ID, name, and GPA.
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            // Constructor to initialize student properties.
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}

Đây là bảng phân tích mã:

- Mã bắt đầu bằng cách nhập các không gian tên cần thiết: `System` và `System.Collections`.

- Bên trong phương thức `Main`, một `Hashtable` có tên `studentsTable` được tạo. `Hashtable` này sẽ lưu trữ các đối tượng của sinh viên, sử dụng ID của họ làm khóa.

- Bốn đối tượng `Student` (`stud1`, `stud2`, `stud3`, và `stud4`) được tạo, mỗi đối tượng thể hiện thông tin của một học sinh, bao gồm ID, tên và GPA.

- Phương thức `Add` được sử dụng để thêm các đối tượng `Student` này vào `studentsTable` `Hashtable`. ID của sinh viên được sử dụng làm chìa khóa.

- Một đối tượng sinh viên riêng lẻ (`storedStudent1`) được lấy từ `studentsTable` bằng cách sử dụng ID của sinh viên làm khóa. Phần này trình bày cách truy cập các mục cụ thể trong `Hashtable` bằng khóa của chúng.

- Vòng lặp `foreach` được sử dụng để lặp qua tất cả các giá trị (đối tượng sinh viên) trong `Hashtable`. Đối với mỗi đối tượng sinh viên, ID, tên và GPA của họ được in ra bảng điều khiển.

- Cuối cùng, có một lớp `Student` lồng trong lớp `Program` để xác định các thuộc tính và hàm tạo cho một học sinh.

Về cơ bản, mã này trình bày cách sử dụng `Hashtable` để lưu trữ và truy xuất các cặp khóa-giá trị, trong đó khóa là ID sinh viên và giá trị là đối tượng `Student` chứa thông tin sinh viên.

115. Dictionaries

Trong C#, `Dictionary` là loại bộ sưu tập cho phép bạn lưu trữ tập hợp các cặp khóa-giá trị, trong đó mỗi khóa được liên kết với một giá trị. Từ điển được sử dụng khi bạn cần tra cứu các giá trị dựa trên một khóa cụ thể. Lớp `Dictionary<TKey, TValue>` là một phần của không gian tên `System.Collections.Generic` và thường được sử dụng cho các mục đích này.

Dưới đây là tổng quan về từ điển trong C#:

1. **Key-Value Pairs**: Từ điển lưu trữ dữ liệu dưới dạng cặp khóa-giá trị, trong đó mỗi khóa là duy nhất trong từ điển và nó ánh xạ tới một giá trị cụ thể. Các khóa và giá trị có thể có các kiểu dữ liệu khác nhau.

2. **Generic Type**: `Dictionary<TKey, TValue>` là loại chung, nghĩa là bạn cần chỉ định loại dữ liệu cho khóa (`TKey`) và giá trị (`TValue`) khi khai báo một phiên bản từ điển. Ví dụ: `Dictionary<int, string>` sẽ lưu trữ các khóa số nguyên và giá trị chuỗi.

3. **Fast Lookup**: Từ điển được tối ưu hóa để tra cứu nhanh. Bạn có thể nhanh chóng truy xuất giá trị được liên kết với một khóa cụ thể mà không cần lặp lại toàn bộ bộ sưu tập.

4. **Unordered**: Từ điển không đảm bảo bất kỳ thứ tự cụ thể nào cho các cặp khóa-giá trị. Thứ tự lưu trữ các mục có thể không khớp với thứ tự chúng được thêm vào.

5. **Add, Remove, Update**: Bạn có thể thêm các cặp khóa-giá trị mới, xóa các cặp hiện có và cập nhật các giá trị được liên kết với khóa.

6. **Exception Handling**: Khi cố gắng truy xuất một giá trị bằng khóa, bạn nên xử lý các ngoại lệ nếu không tìm thấy khóa. Điều này thường được thực hiện bằng phương pháp `TryGetValue`.

Đây là một ví dụ về cách sử dụng `Dictionary` trong C#:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary with int keys and string values.
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        // Add key-value pairs to the dictionary.
        myDictionary.Add(1, "Alice");
        myDictionary.Add(2, "Bob");
        myDictionary.Add(3, "Charlie");

        // Access values by key.
        string name = myDictionary[2]; // Retrieves "Bob"

        // Check if a key exists in the dictionary and handle missing keys.
        if (myDictionary.ContainsKey(4))
        {
            Console.WriteLine("Key 4 exists: " + myDictionary[4]);
        }
        else
        {
            Console.WriteLine("Key 4 does not exist.");
        }

        // Safely retrieve a value by key using TryGetValue.
        string result;
        if (myDictionary.TryGetValue(2, out result))
        {
            Console.WriteLine("Key 2 exists: " + result);
        }
        else
        {
            Console.WriteLine("Key 2 does not exist.");
        }

        // Iterating through the dictionary.
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}
Trong ví dụ này, một từ điển được tạo, điền các cặp khóa-giá trị và các hoạt động khác nhau như truy xuất, kiểm tra sự tồn tại của khóa và lặp lại được thể hiện. Từ điển cực kỳ hữu ích cho các tình huống mà bạn cần liên kết dữ liệu với mã định danh hoặc khóa duy nhất.

My code:
Chắc chắn rồi, tôi sẽ giải thích từng dòng mã được cung cấp:

namespace DictionariesDemo
{
    internal class Program
    {
        // Key - value
        // Auto - car
        static void Main(string[] args)
        {
            // Array of Employee objects
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                // ...
            };

- Đây là phần bắt đầu của chương trình. Nó định nghĩa một không gian tên gọi là `DictionariesDemo`.
- Bên trong không gian tên, có một lớp tên là `Program`, chứa phương thức `Main` nơi bắt đầu thực thi chương trình.
- Một mảng các đối tượng `Nhân viên` được tạo và khởi tạo với dữ liệu nhân viên mẫu. Mỗi nhân viên có một vai trò (`string`), tên (`string`), tuổi (`int`) và rate (`float`).

// Create a dictionary to store employees by role.
Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

- Một `Từ điển<string, Nhân viên>` có tên `employeesDirectory` được khai báo. Từ điển này sẽ lưu trữ các nhân viên sử dụng vai trò của họ (`chuỗi`) làm khóa và đối tượng `Nhân viên` làm giá trị.

// Populate the dictionary with employees using their roles as keys.
foreach (Employee emp in employees)
{
    employeesDirectory.Add(emp.Role, emp);
}

- Đoạn mã sau đó đi vào vòng lặp `foreach` để điền vào từ điển `employeesDirectory`. Nó lặp qua mảng `nhân viên` và với mỗi đối tượng `Nhân viên` `emp`, nó thêm nhân viên đó vào từ điển bằng cách sử dụng vai trò làm khóa.

// Iterate through the dictionary to access key-value pairs.
for (int i = 0; i < employeesDirectory.Count; i++)
{
    KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
    Employee employeeValue = keyValuePair.Value;

- Tiếp theo, mã lặp qua từ điển `employeesDirectory` bằng vòng lặp `for`. Nó sử dụng `ElementAt(i)` để truy xuất cặp khóa-giá trị tại chỉ mục `i`.
- Nó trích xuất khóa (`string`) và giá trị (`Employee`) từ cặp khóa-giá trị.

// Print employee details.
Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
Console.WriteLine("Employee Name: {0}", employeeValue.Name);
Console.WriteLine("Employee Role: {0}", employeeValue.Role);
Console.WriteLine("Employee Age: {0}", employeeValue.Age);
Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

- Mã in key, chỉ số `i` và các thông tin chi tiết khác nhau của từng nhân viên. Nó sử dụng `Console.WriteLine` để hiển thị thông tin này.

// Example of accessing an employee by key.
string key = "CEO";
if (employeesDirectory.ContainsKey(key))
{
    Employee emp1 = employeesDirectory[key];
    Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
}
else
{
    Console.WriteLine("No employee found with this key {0}", key);
}

- Phần này trình bày việc truy cập một nhân viên bằng một khóa cụ thể ("CEO") bằng phương thức `ContainsKey`. Nếu khóa tồn tại trong từ điển, nó sẽ truy xuất nhân viên và in thông tin chi tiết của họ. Nếu không, nó chỉ ra rằng không tìm thấy nhân viên nào có khóa đã cho.

// Example of using TryGetValue to access an employee.
Employee result = null;
if (employeesDirectory.TryGetValue("Intern", out result))
{
    Console.WriteLine("Value Retrieved!.");
    Console.WriteLine("Employee Name: {0}", result.Name);
    Console.WriteLine("Employee Role: {0}", result.Role);
    Console.WriteLine("Employee Age: {0}", result.Age);
    Console.WriteLine("Employee Salary: {0}", result.Salary);
}
else
{
    Console.WriteLine("The key does not exist");
}
        }
    }
- Trong phần này, mã trình bày việc truy cập nhân viên bằng khóa ("Thực tập sinh") bằng phương thức `TryGetValue`. Nó kiểm tra xem khóa có tồn tại hay không và lấy thông tin chi tiết của nhân viên nếu tìm thấy. Nếu không, nó chỉ ra rằng khóa không tồn tại.

Mã này thể hiện một cách hiệu quả cách sử dụng từ điển trong C# để lưu trữ, truy xuất và thao tác với các tập hợp các cặp khóa-giá trị, trong trường hợp này là biểu thị các bản ghi nhân viên.

116. Editing And Removing Entries in a Dictionairy

116. Chỉnh sửa và xóa các mục trong từ điển

Trong C#, bạn có thể chỉnh sửa và xóa các mục trong từ điển bằng cách sử dụng các phương thức được cung cấp bởi lớp `Dictionary<TKey, TValue>`. Đây là cách bạn có thể làm điều đó:

1. **Chỉnh sửa mục**:

    Để chỉnh sửa một mục trong từ điển, trước tiên bạn cần kiểm tra xem khóa đó có tồn tại trong từ điển hay không. Nếu nó tồn tại, bạn có thể cập nhật giá trị tương ứng. Đây là một ví dụ:

    using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        // Adding entries
        scores["Alice"] = 95;
        scores["Bob"] = 87;

        // Check if a key exists
        if (scores.ContainsKey("Alice"))
        {
            // Update the value
            scores["Alice"] = 98;
        }

        // Print the updated value
        Console.WriteLine("Alice's score: " + scores["Alice"]);
    }
}
    Trong ví dụ này, trước tiên chúng tôi kiểm tra xem "Alice" có tồn tại dưới dạng khóa trong từ điển hay không. Nếu đúng như vậy, chúng tôi sẽ cập nhật điểm của cô ấy lên 98.

2. **Xóa mục nhập**:

    Để xóa một mục khỏi từ điển, bạn có thể sử dụng phương thức `Remove`. Đây là một ví dụ:

    using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();

        // Adding entries
        scores["Alice"] = 95;
        scores["Bob"] = 87;

        // Remove an entry by key
        if (scores.ContainsKey("Bob"))
        {
            scores.Remove("Bob");
        }

        // Check if the key "Bob" still exists
        if (!scores.ContainsKey("Bob"))
        {
            Console.WriteLine("Bob's score has been removed.");
        }
    }
}

    Trong ví dụ này, trước tiên chúng tôi kiểm tra xem "Bob" có tồn tại dưới dạng khóa trong từ điển hay không. Nếu đúng như vậy, chúng tôi sẽ xóa mục nhập được liên kết với "Bob" bằng phương pháp `Remove`.

Hãy nhớ luôn kiểm tra xem khóa có tồn tại trong từ điển hay không trước khi thử chỉnh sửa hoặc xóa khóa đó để tránh trường hợp ngoại lệ.

117. Queues and Stacks Overview

Trong C#, Hàng đợi và Ngăn xếp là các cấu trúc dữ liệu cho phép bạn lưu trữ và thao tác với các bộ sưu tập các mục theo một thứ tự cụ thể. Chúng là một phần của không gian tên System.Collections và có thể được sử dụng cho nhiều mục đích khác nhau trong lập trình. Dưới đây là tổng quan về Hàng đợi và Ngăn xếp:

### Hàng đợi:

Hàng đợi là một cấu trúc dữ liệu tuyến tính tuân theo nguyên tắc Nhập trước xuất trước (FIFO). Nói cách khác, vật phẩm nào được thêm vào trước sẽ là vật phẩm sẽ bị loại bỏ trước tiên. Hàng đợi rất hữu ích trong các tình huống mà bạn cần duy trì thứ tự các phần tử và xử lý chúng theo thứ tự chúng được thêm vào.

**Đặc điểm chính của hàng đợi**:

1. **Enqueue**: Việc thêm một mục vào cuối hàng đợi được gọi là "enqueue".
2. **Dequeue**: Việc xóa một mục khỏi đầu hàng đợi được gọi là "dequeue".
3. Các phần tử được xử lý theo thứ tự chúng được thêm vào.
4. Hàng đợi thường được sử dụng cho các tác vụ như quản lý tác vụ trong hàng đợi in, xử lý các yêu cầu trong máy chủ web hoặc triển khai thuật toán tìm kiếm theo chiều rộng.

**Triển khai C#**:

Trong C#, bạn có thể sử dụng lớp `Queue<T>` để làm việc với hàng đợi. Đây là một ví dụ đơn giản:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        // Enqueue items
        queue.Enqueue("Item 1");
        queue.Enqueue("Item 2");
        queue.Enqueue("Item 3");

        // Dequeue items
        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine("Dequeued: " + item);
        }
    }
}

### Ngăn xếp:

Ngăn xếp là một cấu trúc dữ liệu tuyến tính khác, nhưng nó tuân theo nguyên tắc Vào trước ra trước (LIFO). Điều này có nghĩa là mục được thêm gần đây nhất sẽ là mục bị xóa đầu tiên. Ngăn xếp rất hữu ích trong những trường hợp bạn cần theo dõi lệnh gọi hàm, hoàn tác chức năng hoặc phân tích cú pháp biểu thức.

**Đặc điểm chính của ngăn xếp**:

1. **Đẩy**: Việc thêm một mục vào đầu ngăn xếp được gọi là "đẩy".
2. **Pop**: Việc xóa một mục khỏi đầu ngăn xếp được gọi là "pop".
3. Các phần tử được xử lý theo thứ tự ngược lại của phép cộng.
4. Ngăn xếp thường được sử dụng cho các tác vụ như quản lý lệnh gọi hàm, đánh giá biểu thức và duy trì lịch sử hành động.

**Triển khai C#**:

Trong C#, bạn có thể sử dụng lớp `Stack<T>` để làm việc với ngăn xếp. Đây là một ví dụ đơn giản:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        // Push items
        stack.Push("Item 1");
        stack.Push("Item 2");
        stack.Push("Item 3");

        // Pop items
        while (stack.Count > 0)
        {
            string item = stack.Pop();
            Console.WriteLine("Popped: " + item);
        }
    }
}

Cả Hàng đợi và Ngăn xếp đều là những công cụ có giá trị trong hộp công cụ của lập trình viên và được sử dụng trong nhiều ứng dụng. Sự lựa chọn giữa chúng phụ thuộc vào yêu cầu cụ thể của chương trình của bạn và thứ tự bạn cần xử lý các phần tử.

My code about stacks:
namespace StacksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            // add elements to the stack and printing the value on top of the stack using peek
            //Peek() will return the element at the top of the stack without removing it
            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
- Mã này bắt đầu bằng cách bao gồm các vùng tên cần thiết và khai báo vùng tên `StackDemo`.
- Bên trong phương thức `Main`, một chồng số nguyên mới (`Stack<int>`) được xác định bằng cách sử dụng lớp `Stack<T>` từ không gian tên `System.Collections.Generic`.
- Phương thức `Push` được sử dụng để thêm phần tử vào ngăn xếp. Trong trường hợp này, số nguyên `1` được thêm vào ngăn xếp.
- `stack.Peek()` được sử dụng để xem giá trị trên cùng của ngăn xếp mà không xóa nó và giá trị này được in ra bảng điều khiển.

Tiếp tục từ nơi chúng tôi đã dừng lại:
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            ////remove items from a stack
            //int myStackItem = stack.Pop();
            //Console.WriteLine("Popped item : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
- Nhiều số nguyên hơn (2 và 3) được đẩy lên ngăn xếp và sau mỗi lần đẩy, giá trị trên cùng sẽ được xem qua và in ra bảng điều khiển.
            while (stack.Count > 0)
            {
                //Pop() will return the elements that was remove from the stack
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                //print the stack count
                Console.WriteLine("Current stack count is: {0}", stack.Count);
            }
- Mã này đi vào một vòng lặp `while` tiếp tục miễn là có các phần tử trong ngăn xếp (`stack.Count > 0`).
- Bên trong vòng lặp, `stack.Pop()` được sử dụng để xóa và trả về giá trị trên cùng của ngăn xếp, sau đó được in ra bàn điều khiển.
- Sau mỗi thao tác pop, số đếm hiện tại của ngăn xếp cũng được in ra.

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            // defining a new stack of int
            Stack<int> myStack = new Stack<int>();
- Một mảng số nguyên có tên `numbers` được xác định, chứa một tập hợp các số nguyên.
- Một chồng số nguyên mới có tên `myStack` được khai báo.

            Console.WriteLine("the numbers in the array are :");
- Dòng này in ra thông báo cho biết sẽ hiển thị các số trong mảng.
            //foreach number in our array
            foreach (int number in numbers)
            {
                // print it
                Console.Write(number + " ");
                //push it into our stack(add)
                myStack.Push(number);
            }
- Vòng lặp `foreach` được sử dụng để lặp qua từng số nguyên trong mảng `numbers`.
- Bên trong vòng lặp, mỗi số được in ra bảng điều khiển, theo sau là một khoảng trắng, sau đó được đẩy lên ngăn xếp `myStack`.

            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse :");
- Những dòng này in một thông báo cho biết các số bây giờ sẽ được hiển thị theo thứ tự ngược lại.
            //as long as our stack is not empty
            while (myStack.Count > 0)
            {
                // pop it and store it in a variable
                int number = myStack.Pop();
                // print the value we popped
                Console.Write(number + " ");
            }

        }
    }
}
- Một vòng lặp `while` khác được sử dụng để lặp qua ngăn xếp `myStack`, tương tự như những gì đã được thực hiện với ngăn xếp đầu tiên.
- Bên trong vòng lặp, mỗi số được lấy ra từ ngăn xếp và in ra bảng điều khiển.

Chương trình này trình bày các thao tác cơ bản về đẩy, nhìn trộm và lấy các phần tử từ một ngăn xếp trong C#. Nó cũng chỉ ra cách đảo ngược thứ tự các phần tử bằng cách sử dụng ngăn xếp.

My code about Queues

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////defining a queue of intergers
            //Queue<int> queue = new Queue<int>();
            ////printing the element at the fron of the queue
            //queue.Enqueue(1);
            //Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            //queue.Enqueue(2);
            //Console.WriteLine("Top value in the queue is : {0}", queue.Peek());
            //queue.Enqueue(3);
            //Console.WriteLine("Top value in the queue is : {0}", queue.Peek());

            //while (queue.Count > 0)
            //{
            //    //Dequeue() will return the element that was removed from the queue
            //    Console.WriteLine("The fron value {0} was removed from the queue", queue.Dequeue());
            //    //print the queue count 
            //    Console.WriteLine("Current queue count is : {0}", queue.Count);
            //}
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in reciveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in reciveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            //as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                //remove the order At the front of the queue
                // and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }; 
        }

        //this method will create an array of orders an return it
        static Order[] reciveOrdersFromBranch1()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] reciveOrdersFromBranch2()
        {
            //creating new orders array and initializing it with some object of type Order
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            //return the array of orders that we created
            return orders;
        }

    }

    // a class named order we will use it to store instances of it inside a queue because

    class Order
    {
        // order ID
        public int OrderId { get; set; }
        // quantity of the order
        public int OrderQuantity { get; set; }

        // simple constructor

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //print message on the screen that the order was process

        public void ProcessOrder()
        {
            // print the message
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }

}

Mã này thể hiện việc sử dụng hàng đợi trong C#:

1. **Khởi tạo hàng đợi**:
    - Nó bắt đầu bằng việc tạo một hàng đợi gọi là `ordersQueue`, hàng đợi này sẽ chứa các đối tượng của lớp `Order`.

2. **Thêm đơn hàng vào hàng đợi**:
    - Nó sử dụng hai vòng lặp `foreach` để thêm đơn hàng vào `ordersQueue` từ kết quả của các phương thức `reciveOrdersFromBranch1` và `reciveOrdersFromBranch2`.
    - Các phương thức này trả về mảng của đối tượng `Order` chứa thông tin chi tiết về đơn hàng.

3. **Xử lý đơn hàng từ hàng đợi**:
    - Nó đi vào một vòng lặp `while` tiếp tục miễn là có các đơn hàng trong `ordersQueue` (được xác định bởi `ordersQueue.Count > 0`).
    - Bên trong vòng lặp, nó loại bỏ (xóa và truy xuất) một đơn hàng từ phía trước hàng đợi và lưu trữ nó trong một biến gọi là `currentOrder`.
    - Sau đó, nó gọi phương thức `ProcessOrder` trên `currentOrder` để mô phỏng quá trình xử lý đơn hàng, dẫn đến một thông báo được in ra bảng điều khiển.

4. **Lớp đặt hàng**:
    - Có lớp `Order` được định nghĩa với các thuộc tính `OrderId` và `OrderQuantity`, đại diện cho ID và số lượng của đơn hàng.
    - Lớp có một hàm tạo để khởi tạo các thuộc tính này và một phương thức `ProcessOrder` để in thông báo xử lý.

Mã này thể hiện việc sử dụng hàng đợi để quản lý một chuỗi đơn hàng, xử lý chúng theo cách nhập trước xuất trước (FIFO), điển hình trong các hệ thống xử lý đơn hàng.
