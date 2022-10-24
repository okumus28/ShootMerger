using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelGroup : MonoBehaviour
{
    public int[] barrelHealt;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Barrel>().maxHealt = barrelHealt[i];
        }
    }
}
