using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCoin : MonoBehaviour
{
    private int count = 0;
    public float floatingHeight = 0.5f;
    private const int STEPS = 25;
    private bool up = true;

    public void FixedUpdate()
    {
        Vector3 move = (up) ? new Vector3(0f, floatingHeight / STEPS, 0f) : new Vector3(0f, -floatingHeight / STEPS, 0f);
        transform.position += move;
        count++;

        if (count == STEPS)
        {
            count = 0;
            up = !up;
        }
    }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
