using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerc2 : MonoBehaviour
{
    private int lifePoints = 100;
    public int damagePoints = 10;
    public int healPoints = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            HealAction();
        } else if (Input.GetKeyDown(KeyCode.D)) {
            DamageAction();
        }else if (Input.GetKeyDown(KeyCode.A) && lifePoints == 0) {
            ReviveAction();
        }else if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log("lifePoints" + lifePoints);
        }
        
    }
    void HealAction(){
        lifePoints = lifePoints + healPoints;
        if(lifePoints > 100){
            lifePoints = 100;
        }
    }
    void DamageAction(){
        lifePoints = lifePoints - damagePoints;
        if(lifePoints <= 0){
            lifePoints = 0;
            Debug.Log("State: Dead");
        }else if(lifePoints < 20){
            Debug.LogWarning("State: In agony");
        }
    }
    void ReviveAction(){
        lifePoints = 100;
    }
}
