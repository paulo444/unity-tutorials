using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    const int RESPAWN_ITEMS = 3;
    const float DEFAULT_Y = .5f;
    const int MIN_POS = -5;
    const int MAX_POS = 5;

    public GameObject handPrefab;
    public GameObject handParent;

    void Start()
    {
        instantiateRandomObjects();
    }

    void instantiateRandomObjects()
    {
        for(int i=0; i<RESPAWN_ITEMS; i++)
        {
            int randomX = Random.Range(MIN_POS, MAX_POS);
            int randomZ = Random.Range(MIN_POS, MAX_POS);

            Vector3 randomPos = new Vector3(randomX, DEFAULT_Y, randomZ);

            Instantiate(handPrefab, randomPos, Quaternion.identity, handParent.transform);
        }
    }
}
