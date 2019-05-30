using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour {

    public GameManager manager;

    public void OnTriggerEnter()
    {
        Debug.Log("You won!!");
        manager.CompleteLevel();
    }
}
