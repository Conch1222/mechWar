using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFollow : MonoBehaviour
{
    public float distanceAway = 5;
    public float distanceUp = 2;
    public float smooth = 3;

    private GameObject hovercraft;
    private Vector3 targetPosition;

    Transform follow;

    void Start()
    {
        follow = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
        transform.LookAt(follow);
    }
}
