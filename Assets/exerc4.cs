using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc4 : MonoBehaviour
{
    public int number;
    public int quantity;
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        if(quantity > 0){
while (counter < quantity){
            Debug.Log(number);
            counter++;
        }
        }else{
            Debug.Log("Error. No quantity");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
