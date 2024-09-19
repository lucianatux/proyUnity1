using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc8 : MonoBehaviour
{
    public int number1;
    public int number2;
    // Start is called before the first frame update
    void Start()
    {
        if (number1 <= number2){
            for (int i = number1; i <= number2; i++){
                Debug.Log("usando for" + i);
                }
            int x = number1;
            while(x <= number2){
                Debug.Log("usando while" + x); 
                x++;
            }
            int y = number1;
            do{
                Debug.Log("usando do while" + y);
                y++;
            }while(y <= number2);
        }else{
            for (int j = number2; j <= number1; j++){
                Debug.Log("usando for" + j);
                }
            int k = number2;
            while(k <= number1){
                Debug.Log("usando while" + k); 
                k++;
            }
            int l = number2;
            do{
                Debug.Log("usando do while" + l);
                l++;
            }while(l <= number1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
