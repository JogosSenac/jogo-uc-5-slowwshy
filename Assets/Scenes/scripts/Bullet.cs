using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float TempodeVida;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, TempodeVida); 
    }
    private void FixedUpdate()
    
    {
        transform.Translate(transform.up * speed * Time.fixedDeltaTime, Space.World);
    }
}

