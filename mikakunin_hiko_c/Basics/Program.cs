// See https://aka.ms/new-console-template for more information

// 文字列の結合・フォーマット
Console.WriteLine("Hello, " + "World!");
// {} の中の 0, 1 は必ず必要
Console.WriteLine(string.Format("({0}, {1})", 10, 20));
Console.WriteLine();

// 配列と foreach
int[] x = new[] { 1, 2, 3, 4, 5 }; // または [1, 2, 3, 4, 5] (コレクションの簡素な初期化)
foreach (var item in x)
{
    Console.WriteLine(item);
}

// リファクター -> ローカル関数の抽出
NewMethod(x);

static void NewMethod(int[] x)
{
    foreach (var item in x)
    {
        Console.WriteLine(item);
    }
}

// 構造体とその初期化
// 構造体宣言はファイルの一番最後に書く必要がある？（CS8803）
var p = new Point { X = 10 };
struct Point { public int X; public int Y; }
