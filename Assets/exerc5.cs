using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class exerc5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <500; i++){
            if(i % 3 == 0 && i % 5 == 0){
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
