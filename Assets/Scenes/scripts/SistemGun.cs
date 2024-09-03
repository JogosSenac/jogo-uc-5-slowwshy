using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SistemGun : MonoBehaviour
{
    Vector2 MousePosi;
    Vector2 dirArma;
    float Angle;
    [SerializeField]SpriteRenderer srGun;
    [SerializeField]float Tempotiro;
    bool podeAtirar = true;
    [SerializeField]Transform pontoDefogo;
    [SerializeField]GameObject tiro;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0)&& podeAtirar == true)
        {
            podeAtirar = false;
            Instantiate(tiro, pontoDefogo.position, pontoDefogo.rotation);
            Invoke("CDTiro",Tempotiro);
        }
    }

   private void FixedUpdate()
    {
        dirArma = MousePosi - new Vector2(transform.position.x, transform.position.y);
        Angle = Mathf.Atan2(dirArma.y, dirArma.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, Angle);
         if(Angle >-180 && Angle < 0)
         {
            srGun.flipY = false;
         }
         else
         {
            srGun.flipY = true;
         }
    }
    void CDTiro()
    {
        podeAtirar = true;
    }
}
