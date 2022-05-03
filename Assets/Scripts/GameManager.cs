using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] public static int intPinsKnocked = 0;
    bool blnHasWon = false;
    void Update() 
    {
        if(intPinsKnocked == 10 & blnHasWon == false)
        {
            blnHasWon = true;
            Debug.Log("You Won!");
            SceneManager.LoadScene("Winner");
        }
    }
}
