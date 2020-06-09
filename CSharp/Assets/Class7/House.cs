using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    [Header("血量"), Range(100, 10000)]
    public float hp;

    [Header("血條")]
    public Image hpBar;



    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }


    /// <summary>
    /// 接收傷害值
    /// </summary>
    /// <param name="damage"></param>
    public void Damge(float damage)
    {
        hp -= damage;                   //血量 遞減
        hpBar.fillAmount = hp / hpMax;  //更新血條
    }


}
