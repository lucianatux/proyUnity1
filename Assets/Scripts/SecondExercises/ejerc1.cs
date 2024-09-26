using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ejerc1 : MonoBehaviour
{
    public int energy;
    public int incrementalValue = 5;
    public int decrementalValue = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            IncrementEnergy();
        } else if (Input.GetKeyDown(KeyCode.S)) {
            DecrementEnergy();
        }
       
    }
    private void IncrementEnergy() {
        energy = energy + incrementalValue;
        if (energy > 100){
            energy = 100;
        }

        if (energy < 20)
        {
            Debug.LogWarning("Low energy");
        }
    }
    private void DecrementEnergy()
    {
        energy = energy - decrementalValue;
        if (energy < 0)
        {
            energy = 0;
        }

        if (energy < 20)
        {
            Debug.LogWarning("Low energy");
        }
    }
}