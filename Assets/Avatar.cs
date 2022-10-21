using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject playerAvatar;

    public GameObject normcorePrefabs;

    public GameObject XRRig;

    // Start is called before the first frame update
    void Start()
    {
        XRRig = GameObject.FindGameObjectWithTag("Player");

        playerAvatar.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        normcorePrefabs.transform.position = XRRig.transform.position;
    }
}
