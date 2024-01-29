using System;
using System.IO;
using UnityEngine;

public class ColorsData
{
    private string[] _data;
    private string _filePath, _fileName;
    private int _stringCount;
    private int _stringLength;


    public void InitData()
    {
        _fileName = "ColorsData.txt";
        _filePath = Application.dataPath + "/" + _fileName;
    }

    public void ReadColorsData()
    {
        _data = File.ReadAllLines(_filePath);
        if (_data.Length == 0)
            throw new ArgumentOutOfRangeException();
        _stringLength = _data[0].Length;
        _stringCount = _data.Length;
    }

    public int[] GetColorsData(int positionX, int positionY, int gridSize)
    {
        if (positionX < 0 || positionY < 0)
            throw new ArgumentOutOfRangeException();

        positionX--;
        positionY--;

        int[] colors = new int[gridSize * gridSize];
        int ind = 0;

        for (int i = 0; i < gridSize; ++i)
        {
            for (int j = 0; j < gridSize; ++j)
            {
                colors[ind++] = (int)Char.GetNumericValue(_data[(positionY + i + _stringCount) % _stringCount]
                    [(positionX + j + _stringLength) % _stringLength]);
            }
        }

        return colors;
    }
}


