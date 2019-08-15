using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    SpriteRenderer flipperLeft;
    SpriteRenderer flipperRight;
    Color c1;
    Color c2;
    float count;

    private void Awake()
    {
        flipperLeft = GameObject.Find("LeftFlipper/flipper")?.GetComponent<SpriteRenderer>();
        flipperRight = GameObject.Find("RightFlipper/flipper")?.GetComponent<SpriteRenderer>();
        c1 = new Color(Random.value, Random.value, Random.value);
        c2 = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime * 1;
        flipperLeft.color = Color.Lerp(c1, c2, count);
        flipperRight.color = Color.Lerp(c1, c2, count);

        if (count >= 1)
        {
            count = 0;
            c1 = flipperLeft.color;
            c2 = new Color(Random.value, Random.value, Random.value);
        }

    }

}
