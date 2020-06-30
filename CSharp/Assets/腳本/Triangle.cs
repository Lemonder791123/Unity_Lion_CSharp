using UnityEngine;

public class Triangle : Shape
{
    public override float GetVolume()
    {
        volume = length * width * height / 2; //三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積" + GetVolume());
    }
}
