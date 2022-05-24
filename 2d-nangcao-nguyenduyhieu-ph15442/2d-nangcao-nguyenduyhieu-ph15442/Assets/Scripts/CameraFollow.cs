using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float Offset = 1f;
    public float Follow = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(player.position.x, player.position.y+Offset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, Follow * Time.deltaTime);

    }
}
