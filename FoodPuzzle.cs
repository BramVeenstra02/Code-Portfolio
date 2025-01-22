using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPuzzle : MonoBehaviour
{

    public GameObject player;
    public GameObject spawn;
    public GameObject witch;
    public GameObject crystal;
    public GameObject strawberry;
    public GameObject pineapple;
    public GameObject mushroom;
    public GameObject carrot;
    public GameObject pear;
    public float distw;
    public float distc;
    public float distsb;
    public float distpa;
    public float distmu;
    public float distca;
    public float distpe;
    public float stage;
    public float sbamount;
    public float paamount;
    public float muamount;
    public float caamount;
    public float peamount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (stage == 0)
        {
            crystal.SetActive(false);
            stage++;
        }
        
        if (stage == 1)
        {
            if (Input.GetKeyDown("f"))
            {
                var possb = strawberry.transform.position;
                var pospa = pineapple.transform.position;
                var posmu = mushroom.transform.position;
                var posca = carrot.transform.position;
                var pospe = pear.transform.position;
                var posw = witch.transform.position;
                var posp = player.transform.position;
                distsb = Vector3.Distance(possb, posp);
                distpa = Vector3.Distance(pospa, posp);
                distmu = Vector3.Distance(posmu, posp);
                distca = Vector3.Distance(posca, posp);
                distpe = Vector3.Distance(pospe, posp);
                distw = Vector3.Distance(posw, posp);

                if (distsb < 3)
                {
                    sbamount++;
                }

                if (distpa < 3)
                {
                    paamount++;
                }

                if (distmu < 3)
                {
                    muamount++;
                }

                if (distca < 3)
                {
                    caamount++;
                }

                if (distpe < 3)
                {
                    peamount++;
                }

                if (distw < 3)
                {
                    if (sbamount == 2 && paamount == 1 && muamount == 1 && caamount == 0 && peamount == 0)
                    {
                        witch.SetActive(false);
                        crystal.SetActive(true);
                        stage++;
                    }
                    else
                    {
                        var spawnpoint = spawn.transform.position;
                        player.GetComponent<CharacterController>().enabled = false;
                        player.transform.position = spawnpoint;
                        player.GetComponent<CharacterController>().enabled = true;
                        sbamount = 0;
                        paamount = 0;
                        muamount = 0;
                        caamount = 0;
                        peamount = 0;
                    }
                }
            }

        }

        if (stage == 2)
        {
            if (Input.GetKeyDown("f"))
            {
                var posc = crystal.transform.position;
                var posp = player.transform.position;
                distc = Vector3.Distance(posc, posp);

                if (distc < 3)
                {
                    stage++;
                    crystal.SetActive(false);
                }
            }
        }
    }
}
