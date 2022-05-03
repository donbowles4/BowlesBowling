using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int intPinsKnocked = 0;
     
    public void PinCount()
    {
        intPinsKnocked += 1;
    }
}
