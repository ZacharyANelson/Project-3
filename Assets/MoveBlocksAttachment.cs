using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocksAttachment : MonoBehaviour
{
    public GameObject MoveBlocks;
    public GameObject ThePlayer;

void OnTriggerEnter()
    {
        ThePlayer.transform.parent = MoveBlocks.transform;
    }
}
