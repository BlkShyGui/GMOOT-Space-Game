using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGCMissileCard : MonoBehaviour
{
    public GameObject MGCMissileProj;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    public void Use()
    {
        Instantiate(MGCMissileProj, player.position, Quaternion.identity);
    }
}
