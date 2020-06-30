using UnityEngine;





namespace JEFF.Class9
{


    public class Dad : MonoBehaviour
    {

        private Boy boy;

        private void Start()
        {
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 10;
            print("給你十塊拉");
        }

        private void HitBoy()
        {
            print("死小孩，欠揍哦");
        }
    }


}