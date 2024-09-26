using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerc5 : MonoBehaviour
{
    private List<string> items= new List<string>();
    private int woodCount = 0;  
    private int stoneCount = 0; 
    public int maxResources = 20; 
    // Start is called before the first frame update
    void Start()
    {
        
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
        if(woodCount <20){
        items.Add("Wood");
        woodCount++;
        }else{
        Debug.LogWarning("You have enough wood resources");

        }
    }
    void PickUpStone(){
        if(stoneCount <20){
        items.Add("Stone");
        stoneCount++;
        }else{
            Debug.LogWarning("You have enough stone resources");
        }
    }
    void ShowResources(){
        Debug.Log("Resources. Wood:" + woodCount + "   Stone:" + stoneCount);
    }
}
