using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this is there to tell me the x position of my Kurapika
        /* wowzers
         * */
        Debug.Log(transform.position.x);
            if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}