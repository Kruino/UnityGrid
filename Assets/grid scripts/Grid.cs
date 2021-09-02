using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Comp;


    public class Grid
    {

        private int width;
        private int height;
        private float cellSize;
        public Vector3 originPosition;
        private static int[,] gridArray;
        private TextMesh[,] debugTextArray;


        public Grid(int width, int height, float cellSize, Vector3 originPosition)
        {

            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.originPosition = originPosition;

            gridArray = new int[width, height];
            debugTextArray = new TextMesh[width, height];

            for (int x = 0; x < gridArray.GetLength(0); x++)
            {
                for (int y = 0; y < gridArray.GetLength(1); y++)
                {

                    debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWordPosition(x, y) + new Vector3(cellSize, cellSize) * 0.5f, 20, Color.white, TextAnchor.MiddleCenter);
                    Debug.DrawLine(GetWordPosition(x, y), GetWordPosition(x, y + 1), Color.white, 100000f);
                    Debug.DrawLine(GetWordPosition(x, y), GetWordPosition(x + 1, y), Color.white, 100000f);
                }
            }
            Debug.DrawLine(GetWordPosition(0, height), GetWordPosition(width, height), Color.white, 100000f);
            Debug.DrawLine(GetWordPosition(width, 0), GetWordPosition(width, height), Color.white, 100000f);


       
        }

        private Vector3 GetWordPosition(int x, int y)
        {
            return new Vector3(x, y) * cellSize + originPosition;
        }

        private void GetXY(Vector3 worldPosition, out int x, out int y)
        {
            x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
            y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
        }
        public void SetValue(int x, int y, int value)
        {
            if (x >= 0 && y >= 0 && x < width && y < height)
            {
                gridArray[x, y] = value;
                debugTextArray[x, y].text = gridArray[x, y].ToString();
            }
        }


        public void SetValue(Vector3 worldPosition, int value)
        {
            int x, y;
            GetXY(worldPosition, out x, out y);
            SetValue(x, y, value);
        }

        public int GetValue(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < width && y < height)
            {
                return gridArray[x, y];
            }
            else
            {
                return 0;
            }
        }

        public int GetValue(Vector3 worldPosition)
        {
            int x, y;
            GetXY(worldPosition, out x, out y);
            return GetValue(x, y);
        }

    

    }


