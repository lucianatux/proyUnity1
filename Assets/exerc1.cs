using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc1 : MonoBehaviour
{
    // Public variables for user input
    public float num1;
    public float num2;
    public char operation;
    // Start is called before the first frame update
    void Start()
    {
        // Perform the calculation based on the operation
        float result = Calculate(num1, num2, operation);

        // Display the result
        Debug.Log("Result: " + result);
    }

float Calculate(float a, float b, char op)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                if (b != 0)
                    return a / b;   

                else
                    Debug.LogError("Cannot divide by zero!");
                break;
            default:
                Debug.LogError("Invalid operation");
                break;
        }
        Debug.Log("Caracter no reconocido!");
        return 0; // Default return value if no operation matches
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
