﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float SensitivityHor = 9.0f;
    public float SensitivityVer = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(axes == RotationAxes.MouseX)
        {
            //horizontal
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            //vertical
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            //combo-wombo-spin
            _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * SensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}
