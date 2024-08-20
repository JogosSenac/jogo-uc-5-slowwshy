using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float speed;
    public int dano;
    public int direçaotiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Contador");
        transform.position += new Vector3(direçaotiro * Time.deltaTime,0,0);
    }

    private IEnumerator Contador()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }
}
