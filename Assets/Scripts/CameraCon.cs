using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public Transform camTarget;
    public float posLerp = 0.02f;
    public float rotLerp = 0.01f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, posLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rotLerp);

    }
}
