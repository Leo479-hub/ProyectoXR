using UnityEngine;

public class RotacionLenta : MonoBehaviour
{
    public float velocidad = 12f;

    void Update()
    {
        transform.Rotate(0, 0, velocidad * Time.deltaTime);
    }
}