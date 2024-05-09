using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float shotDelay = 0.5f;
    private float timeUntilNextShot;


    // Update is called once per frame
    void Update()
    {
        timeUntilNextShot -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeUntilNextShot <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeUntilNextShot = shotDelay;
        }
    }
}
