using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc2 : MonoBehaviour
{
   
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        int mayor = EncontrarMayorNumero(num1, num2, num3);

        Debug.Log("El número mayor es: " + mayor);
        
    }

 int EncontrarMayorNumero(int num1, int num2, int num3)
    {
        if(num1 >= num2 && num1 >= num3){
            return num1;
        }else if(num2 >= num3 && num2 >= num1){
            return num2;
        }else {
            return num3;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
