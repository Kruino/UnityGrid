using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Comp;

public class Testing : Buttons 
{
    private Grid grid;
    public int GridY = 14;
    public int GridX = 10;
    public float GridCellSize = 10f;
    public int GridPositionY = 0;
    public int GridPositionX = 0;

 

    void Start()
    {
        grid  = new Grid(GridY, GridX, GridCellSize, new Vector3(GridPositionX, GridPositionY));
       
    }

    private void Update()
    {

       
        if (Input.GetMouseButtonDown(0))
        {
           grid.SetValue(UtilsClass.GetMouseWorldPosition(), Value);
        }

        if (Input.GetMouseButtonDown(1))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 0);
            
        }

       

    }

   
}

