using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour {

    private int counter = 0;
    public Transform floorPrefab;
    public Transform pathmakerSpherePrefab;

	void Start () {
		
	}
	
	void Update () {
        if (counter < 50)
        {
            float rNum = Random.Range(0f,1.0f);
            if (rNum < .25f)
            {
                transform.Rotate(0, 0, 90);
            }
            else if (rNum >= .25f && rNum < .5f)
            {
                transform.Rotate(0, 0, -90);
            }
            else if (rNum >=.99f)
            {
                Instantiate(pathmakerSpherePrefab, this.transform.position, Quaternion.identity);
            }
            Instantiate(floorPrefab, this.transform.position, Quaternion.identity);
            transform.position += transform.forward * 5;
            counter++;
        }	
        else
        {
            Destroy(this.gameObject);
        }
	}
}
