using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerc3 : MonoBehaviour
{
       public int weekDayNumber;
    // Start is called before the first frame update
    void Start()
    {
        string result= weekDayMethod(weekDayNumber);
        Debug.Log("El día de la semana es " + result);
    }

string weekDayMethod(int weekDayNumber){
    switch (weekDayNumber)
{
case 1:
return("Lunes");
case 2:
return("Martes");
case 3:
return("Miércoles");
case 4:
return("Jueves");
case 5:
return("Viernes");
case 6:
return("Sábado");
case 7:
return("Domingo");
default:
return("Error: the number must be from 1 to 7");
}

}


    // Update is called once per frame
    void Update()
    {
        
    }
}
