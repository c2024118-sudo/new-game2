using System;

class Program
{
    static void Main(string[] args)
    {
        // ランダムな数を生成する準備
        Random random = new Random();
        // 1から100までのランダムな数を正解として設定
        int answer = random.Next(1, 101);
        
        int playerGuess = 0; // プレイヤーの予想をいれる変数
        int count = 0;       // 試行回数を数える変数

        Console.WriteLine("======================================");
        Console.WriteLine("数当てゲームへようこそ！");
        Console.WriteLine("1から100までの数字を当ててみてね。");
        Console.WriteLine("======================================");

        // 正解するまでループを繰り返す
        while (playerGuess != answer)
        {
            Console.Write("数を入力してください: ");
            string input = Console.ReadLine();

            // 入力された文字列が正しい数字かどうかをチェック
            if (!int.TryParse(input, out playerGuess))
            {
                Console.WriteLine("エラー: 有効な数字を入力してください。");
                continue; // ループの先頭に戻る
            }

            count++; // 入力回数を1増やす

            // 大きさの判定
            if (playerGuess < answer)
            {
                Console.WriteLine("もっと【大きい】ですよ！");
            }
            else if (playerGuess > answer)
            {
                Console.WriteLine("もっと【小さい】ですよ！");
            }
            else
            {
                Console.WriteLine($"おめでとうございます！正解です！");
                Console.WriteLine($"かかった回数: {count}回");
            }
            
            Console.WriteLine("--------------------------------------");
        }

        Console.WriteLine("ゲームを終了します。お疲れ様でした！");
    }
}
