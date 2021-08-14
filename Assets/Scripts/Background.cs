using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform source;
    public GameObject target;
    Transform coordinate;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (source.position != target.transform.position)
        {
            source.position = target.transform.position;
        }
    }
}
