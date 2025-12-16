using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    public GameObject floorTile1, floorTile2;
    public GameObject[] tiles;

    void FixedUpdate()
    {
        // je¿eli aktualnie nie trwa gra nie wykonuj reszty metody
        if (!GameManager.instance.inGame) return;

        floorTile1.transform.position -= new Vector3(GameManager.instance.worldScrollingSpeed, 0f, 0f);
        floorTile2.transform.position -= new Vector3(GameManager.instance.worldScrollingSpeed, 0f, 0f);

        if (floorTile2.transform.position.x < 0f)
        {
            //floorTile1.transform.position += new Vector3(32f, 0f, 0f);
            var newTile = Instantiate(tiles[Random.Range(0, tiles.Length)],
                floorTile2.transform.position + new Vector3(16f, 0f, 0f), Quaternion.identity);

            Destroy(floorTile1);

            //var tmp = floorTile1;
            floorTile1 = floorTile2;
            floorTile2 = newTile;
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
