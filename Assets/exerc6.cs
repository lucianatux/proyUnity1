using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc6 : MonoBehaviour
{
    public int firstRangeParameter;
    public int secondRangeParameter;
    // Start is called before the first frame update
    void Start()
    {
        if (firstRangeParameter <= secondRangeParameter)
        {
            for (int i = firstRangeParameter; i <= secondRangeParameter; i++)
            {
                Debug.Log(firstRangeParameter * i);
            }
        }
        else
        {
            for (int i = secondRangeParameter; i <= firstRangeParameter; i++)
            {
                Debug.Log(secondRangeParameter * i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
