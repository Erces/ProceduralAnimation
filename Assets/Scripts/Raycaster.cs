using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private Transform tracker;
    void Start()
    {
        tracker = transform.GetChild(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,-transform.up ,out hit,Mathf.Infinity)){
            Debug.DrawRay(transform.position,-transform.up * hit.distance,Color.green);
            tracker.position = hit.point;
            Debug.Log("Hit");
        }
    }
}