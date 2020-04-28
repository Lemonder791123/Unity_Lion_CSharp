using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;


    // 定義方法語法：
    // 修飾詞 傳回類型 方法名稱(參數){陳述式}
    // void 無傳回：當使用此方法時不會得到任何傳回資料
    public void Talk()
    {
        print("hi，我在說話~我是 " + gameObject.name);
    }

    //傳回方法：傳回類型不是void
    //使用此方法會得到傳回資料，必須使用關鍵字return
    /// <summary>
    /// 計算人的BMI
    /// </summary>
    /// <returns></returns>
    public float BMI()
    {
        //BMI公式
        float result = weight / ((height / 100) * (height / 100));
        //回傳return
        return result;
    }


    //參數類型：類型 名稱
    //有預設值的參數稱為【選填式參數】－可以不填，值為預設值
    //選填式參數必須定義在最右邊

    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed">需要以多少速度走路</param>
    public void Walk(int speed,string direction = "前方", string sound = "bang!")
    {
        print("用時速" + speed + "公里走路");
        print("走路音效"+ sound);
        print("走路方向" + direction);
    
    }

    //攻擊方式：徒手
    public void AttackWithHand()
    {

    }
    //攻擊方式：使用武器，音效
    public void AttackWithWeapon()
    {

    }

    //多載 Overload
    //1.想同名稱的方法
    //2. 參數數量不同 或者 參數類型不同
    /// <summary>
    /// 使用徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!");        
    }
    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    /// <param name="weapon"></param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器" + weapon + "攻擊!");
        print("攻擊音效");
    }

    //讓Unity按鈕Button使用方法條件：
    //１.修飾詞為公開puclic
    // 2.參數數量小於等於1
    ///<summary>
    ///技能
    ///</summary>
    public void Skill()
    {
        print(gameObject + "施放技能!!!");
    }

}
