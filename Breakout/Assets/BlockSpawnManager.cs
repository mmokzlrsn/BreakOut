using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnManager : MonoBehaviour
{
    [SerializeField] List<Block> blocks= new List<Block>();
    private readonly float _blockOffsetX = 1;
    private readonly float _blockOffsetY = 0.4f;
    [SerializeField] List<Block> _spawnedBlocks = new List<Block>();

    [SerializeField] int _rowCount = 1;
    [SerializeField] int _columnCount =1;

    private void Start()
    {
        StartSpawn();
        SetSpawnStartPosition();
        SetLocations();
    }


    public void StartSpawn()
    {
        for(int i = 0; i < _rowCount; i++)
        {
            for(int j = 0; j < _columnCount; j++)
            {
                Block block = Instantiate(blocks[Random.Range(0, blocks.Count)]);
                block.transform.SetParent(gameObject.transform);
                _spawnedBlocks.Add(block);
            }
        }
    }

    public void SetSpawnStartPosition()
    {
        //transform.position = new Vector2(
        //    (-(float)_rowCount / 2f)

        //    +

        //    ((float)_blockOffsetX / 2f)



        //    , 

        //    ()


        //    );
    }

    public void SetLocations()
    {
        for (int j = 0; j < _rowCount; j++)
        {
            for (int i = 0; i < _columnCount; i++)
            {
                int index = (j * _columnCount) + i;
                if (index < _spawnedBlocks.Count)
                {
                    _spawnedBlocks[index].transform.localPosition = new Vector2(_blockOffsetX * i, _blockOffsetY * j);
                }
            }
        }
    }


}
