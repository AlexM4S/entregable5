using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset = new Vector3(25, 3, 8);
    



    void LateUpdate()
    {
        // C�mara sigue al jugador
        transform.position = player.transform.position + offset;
    }
}
