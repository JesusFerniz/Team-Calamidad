using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");


        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.GameWin();
    }
}