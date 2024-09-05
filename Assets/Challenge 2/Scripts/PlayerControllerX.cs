using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnDelay = 1.0f;
    private bool isWaiting = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomDog();
        }
    }

    void SpawnRandomDog()
    {
        if (!isWaiting)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        //wait for some time
        isWaiting = true;
        yield return new WaitForSeconds(spawnDelay);
        isWaiting = false;
    }
}
