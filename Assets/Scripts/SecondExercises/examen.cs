using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examen : MonoBehaviour
{
    private List<int> ResourcesList= new List<int>();
    private List<string> AllRegistersList= new List<string>();
    private int costOfWood= 10;
    private int costOfStone=15;
    private int WoodQuantityToBuildAWoodHouse = 5;
    private int StoneQuantityToBuildAStoneHouse = 5;
    private int maxQuantityResources=20;
    private int earnMoneyQuantity=20;
    // Start is called before the first frame update
    void Start()
    {
        ResourcesList.Add(100);//counter of money index 0
        ResourcesList.Add(0);//counter of wood index 1
        ResourcesList.Add(0);//counter of stone index 2
        ResourcesList.Add(0);//counter of woodHouses index 3
        ResourcesList.Add(0);//counter of stoneHouses index 4
        ResourcesList.Add(0);//counter of woodAndStoneHouses index 5
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W)){
            BuyWood();
        } else if (Input.GetKeyDown(KeyCode.S)) {
            BuyStone();
        }else if (Input.GetKeyDown(KeyCode.R)) {
            ShowResources();
        }else if (Input.GetKeyDown(KeyCode.E)){
            EarnMoney();
        }else if(Input.GetKeyDown(KeyCode.H)){
            BuildWoodHouse();
        }else if(Input.GetKeyDown(KeyCode.P)){
            BuildStoneHouse();
        }else if(Input.GetKeyDown(KeyCode.M)){
            BuildWoodAndStoneHouse();
        }else if(Input.GetKeyDown(KeyCode.K)){
            ShowAllRegisters();
        }
    }
    
    void BuyWood(){
        if (ResourcesList[0] >= costOfWood){
            if (ResourcesList[1]< maxQuantityResources){
                ResourcesList[0] -= costOfWood;
                ResourcesList[1] += 1;
            }else{
                Debug.LogError("You have reached the resource limit of wood");
            }    
        }else{
            Debug.LogError("You don't have enough money to buy wood");
        }
    }
    void BuyStone(){
        if (ResourcesList[0] >= costOfStone){
            if (ResourcesList[2]< maxQuantityResources){
                ResourcesList[0] -= costOfStone;
                ResourcesList[2] += 1;
            }else{
                Debug.LogError("You have reached the resource limit of stone");
            }    
        }else{
            Debug.LogError("You don't have enough money to buy stone");
        }
    }
    void EarnMoney(){
        ResourcesList[0] += earnMoneyQuantity;
        Debug.Log("You have " + ResourcesList[0] + " silver coins");
    }
    void BuildWoodHouse(){
        if (ResourcesList[1] >= WoodQuantityToBuildAWoodHouse){
            ResourcesList[1] = ResourcesList[1] - WoodQuantityToBuildAWoodHouse;
            ResourcesList[3] += 1;
        }else{
            Debug.LogError("You don't have enough resources to build a wood house");
        }
    }
    void BuildStoneHouse(){
        if (ResourcesList[2] >= StoneQuantityToBuildAStoneHouse){
            ResourcesList[2] = ResourcesList[2] - StoneQuantityToBuildAStoneHouse;
            ResourcesList[4] += 1;
        }else{
            Debug.LogError("You don't have enough resources to build a stone house");
        }
    }
    void BuildWoodAndStoneHouse(){
         if ((ResourcesList[1] >= WoodQuantityToBuildAWoodHouse) && ( ResourcesList[2] >= StoneQuantityToBuildAStoneHouse)){
            ResourcesList[1] = ResourcesList[1] - WoodQuantityToBuildAWoodHouse;
            ResourcesList[2] = ResourcesList[2] - StoneQuantityToBuildAStoneHouse;
            ResourcesList[5] += 1;
        }else{
            Debug.LogError("You don't have enough resources to build a wood and stone house");
        }
    }
    void ShowResources(){
        Debug.Log("Money: " + ResourcesList[0] + " silver coins. Wood units: " + ResourcesList[1] + ". Stone units: " + ResourcesList[2] + ". Wood Houses: " + ResourcesList[3] + ". Stone Houses: " + ResourcesList[4] + ". Wood and Stone Houses: " + ResourcesList[5] );
    }
    void ShowAllRegisters(){
        foreach (string register in AllRegistersList)
{
Debug.Log("Register: " + register );
}

    }
}
//no llegué a tiempo a cambiar por el switch, a poner _ en private y a completar la ShowAllRegisters