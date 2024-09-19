using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class exerc7 : MonoBehaviour
{
    public int grade;
    // Start is called before the first frame update
    void Start()
    {
        
         switch (grade)
        {
            case 10:
                Debug.Log("Matrícula de honor");
                break;
            case 9:
                Debug.Log("Sobresaliente");
                break;
            case 8:
            case 7:
                Debug.Log("Notable");
                break;
            case 6:
                Debug.Log("Bien");
                break;
            case 5:
                Debug.Log("Aprobado");
                break;
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                Debug.Log("Suspenso");
                break;
            default:
                // Si el número no está entre 0 y 10
                Debug.Log("Nota no válida. Debe estar entre 0 y 10.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
