using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeDoor : MazePassage
{
    public Transform hinge;
    private MazeDoor OtherSizeDoor {
        get {
            return otherCell.GetEdge(direction.GetOpposite()) as MazeDoor;
        }
    }
    public override void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        base.Initialize(cell, otherCell, direction);
        if (OtherSizeDoor != null)
        {
            hinge.localScale = new Vector3(-1f, 1f, 1f);
            Vector3 position = hinge.localPosition;
            position.x = -position.x;
            hinge.localPosition = position;
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if (child != hinge)
            {
                child.GetComponent<Renderer>().material = cell.room.settings.wallMaterial;
            }
        }
    }

}
