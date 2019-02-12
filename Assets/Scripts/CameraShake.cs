using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public float amount = 1;
    public float speed = 1;
    Vector3 current;
    float xOffSet;
    float yOffSet;
    float seed;

	// Use this for initialization
	void Start () {

        seed = Random.Range(0, 10000);
        current = transform.position;
    }

    void ShakeCamera()
    {
        xOffSet = Mathf.PerlinNoise(seed + Time.time * speed, 0) * 2 - 1;
        yOffSet = Mathf.PerlinNoise(0, seed + Time.time * speed) * 2 - 1;

        transform.position = transform.position + new Vector3(xOffSet * amount, yOffSet * amount, 0);
    }

	// Update is called once per frame
	void Update () {

        ShakeCamera();
	}
}
