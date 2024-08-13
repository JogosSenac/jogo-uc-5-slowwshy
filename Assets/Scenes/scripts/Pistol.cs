using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    private Transform AimTransform;

    private void Awake()
    {
        AimTransform = transform.Find("pistol");
    }
}
