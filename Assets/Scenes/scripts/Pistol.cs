using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public static Vector3 mousePosition;
    private Transform AimTransform;

    private void Awake()
    {
        AimTransform = transform.Find("pistol");
    }
    public void pistolP()
    {
        transform.position = mousePosition;
    }
    
}
