using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerc4 : MonoBehaviour
{
    private int _velocity = 0;
    private int _velocityMin = 0;
    private int _velocityMax = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.I))
        {
            IncrementVelocity();
        } else if (Input.GetKeyDown(KeyCode.O)) {
            DecrementVelocity();
        }else if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log(_velocity);
        }
        
    }
    void IncrementVelocity(){
        _velocity += 1;
        if(_velocity > _velocityMax){
            _velocity = _velocityMax;
        }
    }
    void DecrementVelocity(){
        _velocity -= 1;
        if(_velocity <= _velocityMin){
            _velocity = _velocityMin;
            Debug.Log("The character has stopped");
        }
    }
}
