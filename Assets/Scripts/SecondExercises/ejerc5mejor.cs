using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerc5mejor : MonoBehaviour
{
    private List<int> items= new List<int>();
    public int maxQuantity=5;
    

    // Start is called before the first frame update
    void Start()
    {
        items.Add(0);
        items.Add(0);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W))
        {
            PickUpWood();
        } else if (Input.GetKeyDown(KeyCode.P)) {
            PickUpStone();
        }else if (Input.GetKeyDown(KeyCode.T)) 
        {
            ShowResources();
        }
    }
    void PickUpWood(){
        if(items[0] < maxQuantity){
            items[0]= items[0] + 1;
        }else{
        Debug.LogWarning("You have enough wood resources");

        }
    }
    void PickUpStone(){
        if(items[1] < maxQuantity){
            items[1]= items[1] + 1;
        }else{
        Debug.LogWarning("You have enough stone resources");

        }
    }
    void ShowResources(){
        Debug.Log("Resources. Wood:" + items[0] + "   Stone:" + items[1]);

    }
}
