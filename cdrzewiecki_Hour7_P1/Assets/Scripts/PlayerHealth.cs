using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float Health = 1004f;
        float poisonDamage = 125.5f;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Health -= poisonDamage;

        Debug.Log(Health);

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
