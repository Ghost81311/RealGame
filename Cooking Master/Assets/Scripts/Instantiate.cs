using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] GameObject Conveyer;
    [SerializeField] int totalFruits;
    [SerializeField] GameObject startObject;
    GameObject x;
    private void Start()
    {
       x=Instantiate(startObject, Conveyer.transform.position, Quaternion.identity);
        x.AddComponent<movement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        int rando = Random.Range(0,totalFruits);
        x=Instantiate(fruits[rando],Conveyer.transform.position,Quaternion.identity);
        x.AddComponent<movement>();
        Debug.Log(fruits[rando].name);
    }
}