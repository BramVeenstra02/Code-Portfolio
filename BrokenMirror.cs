using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenMirror : MonoBehaviour
{

    public GameObject player;
    public GameObject mirror;
    public GameObject othermirror;
    public GameObject brokenmirror;
    public GameObject target;
    public GameObject shard1;
    public GameObject shard2;
    public GameObject shard3;
    public float distm;
    public float dists1;
    public float dists2;
    public float dists3;
    public float stage;
    public float shardsfound = 0;
    public bool s1found = false;
    public bool s2found = false;
    public bool s3found = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stage == 0)
        {
            mirror.SetActive(false);
            stage++;
        }

        if (stage == 1)
        {
            if (Input.GetKeyDown("f"))
            {
                var poss1 = shard1.transform.position;
                var poss2 = shard2.transform.position;
                var poss3 = shard3.transform.position;
                var posp = player.transform.position;
                dists1 = Vector3.Distance(poss1, posp);
                dists2 = Vector3.Distance(poss2, posp);
                dists3 = Vector3.Distance(poss3, posp);

                if (dists1 < 3 && s1found == false)
                {
                    shard1.SetActive(false);
                    s1found = true;
                    shardsfound++;
                }
                else if (dists2 < 3 && s2found == false)
                {
                    shard2.SetActive(false);
                    s2found = true;
                    shardsfound++;
                }
                else if (dists3 < 3 && s3found == false)
                {
                    shard3.SetActive(false);
                    s3found = true;
                    shardsfound++;
                }
            }

            if (shardsfound == 3)
            {
                stage++;
                brokenmirror.SetActive(false);
                mirror.SetActive(true);
            }
        }

        if (stage == 2)
        {
            if (Input.GetKeyDown("f"))
            {
                var posbm = mirror.transform.position;
                var posp = player.transform.position;
                distm = Vector3.Distance(posbm, posp);
                if (distm < 5)
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
}
