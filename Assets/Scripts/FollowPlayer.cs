using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset=new Vector3(0,7,-7);
    // Start is called before the first frame update
    

    // Update is called once per frame
    void LateUpdate()
    {
        //offsett the camera to player by adding its position
        transform.position=player.transform.position + offset;
    }
}
