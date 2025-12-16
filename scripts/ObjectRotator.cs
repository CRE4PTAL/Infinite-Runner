using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(0.5f * rotationSpeed, 1.5f * rotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // je¿eli aktualnie nie trwa gra nie wykonuj reszty metody
        if (!GameManager.instance.inGame) return;
        transform.Rotate(new Vector3(0f, 0f, rotationSpeed));
    }
}

