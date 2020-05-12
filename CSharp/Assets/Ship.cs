using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位：給任何人存取
    //從其他類別取得或存放資料
    public float speed = 20;


    //私人欄位：僅限於此類別存取
    //從其他類別無法取得或存放資料
    private float weight = 20;



    //問題：
    //假設需要取得但是不能修改－屬性（權限）
    //屬性語法
    //修飾詞 類型 名稱 { 存取權限 }
    //get可以取得
    //set可以存放
    //讀寫權限屬性
    //屬性不會顯示在面板上，
    public float length { get; set; }


    //舉例 - 企劃：寬度固定 30 不變
    //使用封裝欄位 - 須具備條件:
    //1.私人欄位
    //2.唯獨屬性(return私人欄位)
    private float _width = 30;
    //唯讀屬性:不能設定值
    public float width { get { return _width; } }

    //企劃：寬度固定　10.5 不變
    private float _height=10.5f;

    // =>(黏巴達 Lambda)
    // C#6 版以上| Unity 2017 C#7 版
    // C# 改版 8 版
    // get => _height; 等同於 get { return _height; }
    public float height { get => _height; }
    

    public float lv = 3;
    //企劃：攻擊力等於　攻擊力＊等級
    //封裝欄位：
    //１.私人欄位
    //2.透過屬性存取(return私人欄位){私人欄位 = value}
    //value 設定屬性時給予值
    private float _atk;
    public float atk { get { return _atk; } set { _atk = value * lv; } }

    private float _def;
    public float def { get => _def; set => _def = value * lv; }
    
}
