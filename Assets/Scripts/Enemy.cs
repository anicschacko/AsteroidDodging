using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private readonly float radius = 3f;
    private float angle;
    private bool isSkipped = false;

    public GameObject asteroidsPrefab, asteroidsHold;

    // Use this for initialization
    void Start()
    {
        angle = 0;
        InvokeRepeating("SpawnBorder", 0.01f, 2f);
    }

    // Update is called once per frame

    private void Update()
    {
        asteroidsHold.transform.Translate(Vector3.back * 20 * Time.deltaTime);
    }


    void SpawnBorder()
    {
        while(angle <= 360)
        {
            if (Random.Range(0, 5) != 0)
            {
                Vector3 pos = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * radius, Mathf.Sin(angle * Mathf.Deg2Rad) * radius, 120f);
                GameObject ep = Instantiate(asteroidsPrefab, pos, Quaternion.identity);
                ep.transform.SetParent(asteroidsHold.transform);
            }
            else
                angle += 19;
            angle += 19;
        }
        angle = 0; 
    }
}
