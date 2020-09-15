﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRoom : ScriptableObject
{
    public int settingIndex;
    public MazeRoomSettings settings;
    private List<MazeCell> cells = new List<MazeCell>();
    public void Add(MazeCell cell)
    {
        cell.room = this;
        cells.Add(cell);
    }
}
