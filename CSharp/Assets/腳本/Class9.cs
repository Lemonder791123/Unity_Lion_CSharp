﻿using UnityEngine;

public class Class9 : MonoBehaviour
{
    public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加 10：" + n);
    }

    public int number1 = 1;

    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA() 
    {
        print("方法A");
    }

    public void MethodB()
    {
        print("方法B");
    }


    //無傳回、一個字串參數
    public void MethodC(string msg)
    {
        print("方法C - " + msg);
    }


    //定義委派
    //可以儲存 無傳回、無參數 的任何方法
    public delegate void DelegateTest();


    //可以儲存 無傳回、一個字串參數 的任何方法
    public delegate void DelegateTest2(string s);

    public delegate void DelegateTest3(int number);


    //定義委派欄位
    public DelegateTest dA,dB;
    public DelegateTest dC;

    public DelegateTest d;

    public DelegateTest2 d2C;

    public DelegateTest3 d3;

    private void Start()
    {
        dA = MethodA;               //dA 欄位儲存 方法A
        dA();                       //呼叫 dA

        dB = MethodB;               
        dB();

        // dC = MethodC;            //不同簽名無法儲存
        // dC();

        d2C = MethodC;              //儲存 方法C
        d2C ("我是委派");

        d = MethodA;
        d += MethodB;
        d += MethodB;

        //Lamda 匿名函式
        //() => { 陳述式 }
        d += () => 
        {

            print("我是匿名函式");
            
        };


        d();

        d3 = (n) => { n *= 10; print("十倍後的數值" + n); };
        d3(7);
    }
}
