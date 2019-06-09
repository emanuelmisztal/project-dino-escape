/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public GameObject plugPrefab;
    public GameObject MainSocket;

    public int linksCount = 20;

    public LineRenderer line;

    private List<GameObject> links = new List<GameObject>();

    void Start()
    {
        GenerateRope();
        line.positionCount = links.Count;
    }

    private void Update()
    {
        for (int i = 0; i < links.Count; i++)
        {
            line.SetPosition(i, links[i].transform.position);
        }
    }

    void GenerateRope()
    {
        links.Add(gameObject);
        Rigidbody2D previousRB = hook;
        for (int i = 0; i < linksCount; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);
            links.Add(link);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;

            previousRB = link.GetComponent<Rigidbody2D>();
        }

        GameObject plug = Instantiate(plugPrefab, transform);
        links.Add(plug);

        plug.GetComponent<MoveObject>().MainSocket = MainSocket;

        HingeJoint2D joint2 = plug.GetComponent<HingeJoint2D>();
        joint2.connectedBody = previousRB;
    }
}
