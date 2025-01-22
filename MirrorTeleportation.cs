using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTeleportation : MonoBehaviour
{

    public GameObject player;
    public GameObject mirror;
    public GameObject othermirror;
    public GameObject target;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            var posm = mirror.transform.position;
            var posp = player.transform.position;
            distance = Vector3.Distance(posm, posp);
            if (distance < 5)
            {
                var post = target.transform.position;
                player.GetComponent<CharacterController>().enabled = false;
                othermirror.SetActive(false);
                player.transform.position = post;
                player.GetComponent<CharacterController>().enabled = true;
                othermirror.SetActive(true);
            }
        }
    }
}
