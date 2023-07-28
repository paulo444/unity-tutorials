using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Transform objTransform;
    private int speed = 30;

    void Start()
    {
        objTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        objTransform.Rotate(speed * Time.deltaTime * PlayerValues.rotationDirection);
    }
}
