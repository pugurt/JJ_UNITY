using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRUN : PlayerFSMState
{
    public Transform marker;
    public float movespeed = 3.0f;

	void Start ()
    {
        marker = GameObject.FindGameObjectWithTag("Marker").transform;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.position = marker.position;
        transform.position = Vector3.MoveTowards(
            transform.position,
            marker.position,
            movespeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, marker.position) < 0.01f)
        {
            GetComponent<FSMManager>().SetState(PlayerState.IDLE);
        }
    }
}
