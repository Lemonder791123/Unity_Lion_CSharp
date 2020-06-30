using System.Collections;
using UnityEngine;

namespace JEFF.Class8
{
    public class Prop : MonoBehaviour ,ICanUse
    {
        public Data data;
        public void Use()
        {
            print("使用道具：" + data.name);

            //啟動協同程序(協程方法)
            StartCoroutine(Big());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;

            while (player.lossyScale.x<3)

            {
                player.localScale += Vector3.one * 0.5f;
                yield return new WaitForSeconds(0.05f);
            }

            Destroy(gameObject);
        }
    }
}
