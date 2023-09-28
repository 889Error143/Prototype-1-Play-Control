using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject ObjectToFollow;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ObjectToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ObjectToFollow.transform.position + offset;
    }
}
