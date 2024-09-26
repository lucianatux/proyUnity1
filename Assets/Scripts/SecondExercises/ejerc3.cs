using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    private int _currentExperience;
    private int _currentLevel;
    
    public int enemyTokill;
    public int expToLevelUp;
    public int expEnemy;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            killEnemies();
        }
    }
    private void killEnemies()
    {

        if (enemyTokill < 0)
        {
            Debug.Log("Enemy to kill need to be greater than 0");
        }

        if (enemyTokill > 5)
        {
            enemyTokill = 5;
        }
        for (int i = 0; i < enemyTokill; i++)
        {
            _currentExperience += expEnemy;

            if (_currentExperience >= expToLevelUp)
            {
                levelUp();
            }
        }
    }
           
        
    private void levelUp()
    {
        _currentLevel++;
        _currentExperience -= expToLevelUp;
        Debug.Log("Level Up!!");
        Debug.Log($"Current Level: {_currentLevel}.Current Experience: {_currentExperience}");
    }
}
