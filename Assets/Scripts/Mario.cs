using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    //variable para a velocidad
    public float speed = 5f;

    //Variable para la fuerza de salto
    public float jumpforce = 10f;

    //variable para detectar suelo
    public bool tocaSuelo;

    public SpriteRenderer renderer;

    //variable movimiento input(del project settings)
    float dirx;

    Rigidbody2D rBody;

  void Awake()
    {
        // componentes a las variables
        rBody = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        
        Debug.Log(dirx);

      

         if(dirx == -1)
        {
            renderer.flipX = true;
        }
        else if(dirx == 1)
        {
            renderer.flipX = false;
           
        }
        else
        {
            renderer.flipX = false;
            
        }
      
        
        if(Input.GetButtonDown("Jump") && tocaSuelo) 
        {

            rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); 
            

        }
  }
    

    void FixedUpdate(){

        rBody.velocity = new Vector2(dirx * speed, rBody.velocity.y);

    }







   
}
