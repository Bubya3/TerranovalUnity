using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScale : MonoBehaviour {

    public float CameraSize;
    public Camera MiniMap;

    // Use this for initialization
    void Start()
    {
        CameraSize = 50.0f;
        MiniMap.orthographicSize = CameraSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SizeUp();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SizeDown();
        }
    }

    public void SizeUp()
    {
        if (CameraSize < 500.0f)
        {
            CameraSize = CameraSize + 25.0f;
            MiniMap.orthographicSize = CameraSize;
        }
    }

    public void SizeDown()
    {
        if (CameraSize >= 25.0f)
        {
            CameraSize = CameraSize - 25.0f;
            MiniMap.orthographicSize = CameraSize;
        }
    }
}