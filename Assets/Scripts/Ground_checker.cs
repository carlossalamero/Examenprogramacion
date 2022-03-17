using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_checker : MonoBehaviour
{

   Mario player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Mario").GetComponent<Mario>();
    }

    void OnTriggerStay2D(Collider2D col)
    {

        player.tocaSuelo = true;
      

    }

    void OnTriggerExit2D(Collider2D col)
    {

        player.tocaSuelo = false;

    }

}