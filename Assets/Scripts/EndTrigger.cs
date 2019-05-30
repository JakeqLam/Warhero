using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager manager;

    public void OnTriggerEnter()
    {
        manager.LoadNextLevel();
    }
}
