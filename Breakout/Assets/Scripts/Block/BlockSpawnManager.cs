using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnManager : MonoBehaviour
{
    [SerializeField] private List<BlockType> blockTypes = new List<BlockType>();

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
        int totalWeight = 0;
        foreach (BlockType blockType in blockTypes)
        {
            totalWeight += blockType.weight;
        }

        for (int i = 0; i < _rowCount; i++)
        {
            for (int j = 0; j < _columnCount; j++)
            {
                int randomWeight = Random.Range(0, totalWeight);
                BlockType selectedBlockType = null;

                foreach (BlockType blockType in blockTypes)
                {
                    randomWeight -= blockType.weight;
                    if (randomWeight < 0)
                    {
                        selectedBlockType = blockType;
                        break;
                    }
                }

                if (selectedBlockType != null)
                { 
                    Block block = Instantiate(selectedBlockType.blockPrefab);
                    block.transform.SetParent(gameObject.transform);
                    _spawnedBlocks.Add(block);
                }
            }
        }
    }


    public void SetSpawnStartPosition()
    {
        transform.position = new Vector2(
            ((float)_rowCount / -2f) + ((float)_blockOffsetX / 2f),
            (5f)
        );
    }

    public void SetLocations()
    {
        for (int j = 0; j < _columnCount; j++)
        {
            for (int i = 0; i < _rowCount; i++)
            {
                int index = (j * _rowCount) + i;
                if (index < _spawnedBlocks.Count)
                {
                    _spawnedBlocks[index].transform.localPosition = new Vector2(_blockOffsetX * i, _blockOffsetY * -j);
                }
            }
        }
    }




}
