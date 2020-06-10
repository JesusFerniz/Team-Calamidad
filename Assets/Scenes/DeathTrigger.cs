using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.GameOver();

        Debug.Log("Muerto " + this.gameObject.name);
    }
}
