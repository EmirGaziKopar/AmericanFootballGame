using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public new Transform camera, man;

    Vector3 yon;

    public float hiz = 10f;

    float x;
    float y;
    float z;

    [SerializeField] Vector3 distance;

    private void FixedUpdate()
    {
        camera.position = Vector3.Lerp(camera.position, man.position - distance, .05f);
        camera.LookAt(man);
    }
}
