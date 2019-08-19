using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(SpriteRenderer))]
public class Brick : MonoBehaviour
{
    [Tooltip("Should we cause a camera shake if the ball hits this brick?")]
    public bool causeCameraShake = false;
    public bool isBreakable = true;

    [Tooltip("Number of sprites equals the number of hits the brick can take.")]
    public List<Sprite> sprites = new List<Sprite>();

    private SpriteRenderer spriteRenderer;

    //private static Camera cam;
    //private bool isColliding = false;
    //private Vector3 centerPos;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Assert.IsNotNull(spriteRenderer, "Failed to find SpriteRenderer component!");

        //cam = Camera.main;
        //centerPos = cam.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (causeCameraShake == true)
        {
            //StartCoroutine(ShakeCamera(cam));
            GameCamera.instance.cameraShake.Shake();

        }

        if (isBreakable == false) { return; }

        if (sprites.Count > 0)
        {
            sprites.RemoveAt(0);
            if (sprites.Count > 0)
            {
                spriteRenderer.sprite = sprites[0];
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    //IEnumerator ShakeCamera(Camera camera)
    //{
    //    Vector3 curPos = centerPos;
    //    for (int i = 1; i <= 2f; i++)
    //    {
    //        camera.transform.position = new Vector3(curPos.x + (i * 0.05f), curPos.y + (i * 0.05f), curPos.z);
    //        yield return new WaitForEndOfFrame();
    //    }
    //    camera.transform.position = centerPos;
    //}
}
