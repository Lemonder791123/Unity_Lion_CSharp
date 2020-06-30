using UnityEngine;

public class prt : MonoBehaviour
{
    public SpriteRenderer kid;
    public Rigidbody ball;
      

    private void Start()
    {
        //練習1
        Time.timeScale = 20;
        //print("時間" + Time.timeScale);


        //練習2
        kid.flipX = true;


        //練習3
        print(Mathf.Floor(1.123456f));


        //練習4
        ball.AddForce(0,800,1500);



        
        

        



    }



}
