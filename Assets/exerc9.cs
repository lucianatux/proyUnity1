using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc9 : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        int x = number;
        int digitCounter = 0;
        if(x<0){
            Debug.Log("El número ingresado es negativo. Se procederá con el número positivo equivalente");
            x = Math.Abs(x);
        }else{
            while(x>0){
                x= x/10;
                digitCounter++;
            }
        }
        Debug.Log("El número ingresado tiene " + digitCounter + " digitos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
