using System.Collections;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
float coffeeTemperature = 85.0f;
float hotLimitTemperature = 70.0f;
float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

        void TemperatureTest ()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            //...do this.
            print("coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("coffee is too cold.");
        }
        //if neither
        else
        {
            print("coffee is just right.");
        }
    }
}
