using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float velocidade = 10;
    void Start()
    
    {

       
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        /* if (x == 0)
        {
            x = -1;
            
        }
        else
        {
            x = 1;
        }

    }
       */
        float y = Random.Range(0, 2) > 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x, velocidade*y);



        // Update is called once per frame
        void Update()
        {

        }
    }
}

