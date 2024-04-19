using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public GameObject donorWall;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(donorWall, new Vector3(0, 19.98f, -22.593f), Quaternion.identity);
    }

    // Update is called once per frame

}
