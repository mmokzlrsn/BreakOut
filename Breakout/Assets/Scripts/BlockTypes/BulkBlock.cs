using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulkBlock : Block
{
    [SerializeField] int _bulkHP = 5;
    // Start is called before the first frame update
    void Start()
    {
        HP = _bulkHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
