using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float    a = 10;
    public float    b = 3;


    public string   c = "7";
    public int      d = 3;

    public int g = 99;
    public int h = 9;

    public bool i = true;
    public bool j = false;

    public int key;
    public int result;

    public int hp=100;

    // 事件：開始事件 - 播放遊戲時執行一次
    private void Start()
    {

        #region 數學運算子
        // 數學運算子：加減乘除 + - * / %
        print(a + b);       //13
        print(a - b);       //7
        print(a * b);       //30
        print(a / b);       //3.33333
        print(a % b);       //兩個數值相除剩下的值 -1
        
        // 加法：串接字串與其他資料　－　其結果為字串
        print("分數：" + 99.9f);
        
        // 將字串與數值類型串接在一起不會運算 - 其結果為字串
        print(c + d);
        #endregion

        #region 比較運算子
        // 比較運算子：
        // 大於、小於、大於等於、小於等於、等於、不等於
        // > < >= <= == !=
        print(g > h);       // true
        print(g < h);       // fales
        print(g >= h);      // true
        print(g <= h);      // fales
        print(g == h);      // fales
        print(g != h);      // true
        #endregion

        #region 邏輯運算子 
        //邏輯運算子：結果為布林值 - 比較兩個布林值
        //並且 && 只要有一個 false 結果為 false - shift + 7
        print("並且：" + (i && j));
        //或者 || 只要有一個 ture 結果為 ture - shift + 鎮
        print("或者" + (i || j));

        print(true && true);        //true
        print(true && false);       //false    
        print(false && true);       //false
        print(true && false);       //false    

        print(true && true);        //ture
        print(true && false);       //ture
        print(false && true);       //ture
        print(true && false);       //false

        //顛倒運算子：加在布林值前 - 將布林值改為顛倒的結果
        print(!true);
        print(!false);
        #endregion

        //指定運算子 = 右邊先運算在指定給左邊
        result = 2 + 3;
        print(result);

        key = key + 1;
        print("鑰匙：" + key);

        //後置遞增 ++　：先輸出在遞增
        print("鑰匙數量：" + key++);
        //前置遞增 ++　：先遞增在輸出　－　結果　3
        print("鑰匙數量"+ ++key);

        //指派運算子: += -= *= /= %=

        //hp = hp + 20;
        hp += 20;
        print("血量：" + hp);      //120
        //hp = hp - 50;
        hp -= 50;
        print("血量：" + hp);      //70
        //hp = hp * 2;
        hp *= 2;
        print("血量：" + hp);      //140
        //hp = hp / 2;
        hp /= 2;
        print("血量：" + hp);      //70
        //hp = hp % 5;
        hp %= 5;
        print("血量：" + hp);      //0
    }

}
