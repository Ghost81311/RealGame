using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] GameObject Conveyer;
    [SerializeField] int totalFruits;
    private void OnTriggerEnter(Collider other)
    {
        int rando = Random.Range(0,totalFruits);
        Instantiate(fruits[rando],Conveyer.transform.position,Quaternion.identity);
    }
}