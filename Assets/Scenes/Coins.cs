using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioClip clip;
    public float rotationspeed;

    private void Update()
    {
        //Quaternion
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationspeed * Time.deltaTime, 0f));
    }
    private void OnTriggerEnter(Collider other)
    {

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.AddCoin();
        Destroy(this.gameObject);
        //Debug.Log("Moneda : " + this.gameObject.name);
    }
}
