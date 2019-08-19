using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public static GameCamera instance;

    [System.NonSerialized] public CameraShake cameraShake;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            cameraShake = GetComponent<CameraShake>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
