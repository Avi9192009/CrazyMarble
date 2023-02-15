using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCameraController : MonoBehaviour
{
    [SerializeField] 
    private Transform _target;
    [SerializeField]
    private int _zDistance;
    [SerializeField]
    private int _yDistance;
    // Update is called once per frame
    void Update()
    {
        Vector3 p = _target.position;
        p.z = p.z - 10;
        p.y += 5;
        transform.position = p;
    }
}
