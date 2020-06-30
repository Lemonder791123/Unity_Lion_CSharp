﻿using UnityEngine;


/// <summary>
/// 立方體 繼承 形狀類別
/// 繼承擁有父類別成員
/// 可存取公開成員
/// </summary>
public class Cube : Shape
{
    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    }


}
