﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public void Open()
    {
        transform.localRotation = Quaternion.Euler(-90, 0, 180);
    }
}
