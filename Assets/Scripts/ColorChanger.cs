using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Color color;
    public bool ChangeBG = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ChangeBG)
        {
            Camera.main.backgroundColor = randomColor((byte)Random.Range(1, 6));
        }
    }

    Color randomColor(byte rndColor)
    {
        switch (rndColor)
        {
            case 1:
                color = Color.green;
                break;
            case 2:
                color = Color.red;
                break;
            case 3:
                color = Color.blue;
                break;
            case 4:
                color = Color.cyan;
                break;
            case 5:
                color = Color.magenta;
                break;
            case 6:
                color = Color.yellow;
                break;
        }
        return color;
    }

}
