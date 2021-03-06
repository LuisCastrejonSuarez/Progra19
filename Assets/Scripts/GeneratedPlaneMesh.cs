﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class GeneratedPlaneMesh : MonoBehaviour
{
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;

    public int columns = 3;
    public int rows = 2;

    private MeshFilter filter;

    private void Start()
    {
        CreateMesh();
    }
    private void Update()
    {
        CreateMesh();
    }
    private void CreateMesh()
    {
        // vertices
        vertex = new Vector3[columns* rows*6];

        for( int i=0; i<columns; ++i)
        {
            for(int j=0; j<rows; ++j)
            {
                int idx = (i * rows + j) * 6;

                /* animación, se cambia la altura según la función senoidal */
                float deltasin1 = Mathf.Sin(Time.time + i-j)*0.5f;
                float deltasin2 = Mathf.Sin(Time.time + i-j+1) * 0.5f;

                vertex[idx]     = new Vector3(i,    deltasin1, j);
                vertex[idx + 1] = new Vector3(i+1,  deltasin2, j);
                vertex[idx + 2] = new Vector3(i,    deltasin1, j+1);

                vertex[idx + 3] = new Vector3(i+1,  deltasin2, j);
                vertex[idx + 4] = new Vector3(i+1,  deltasin2, j+1);
                vertex[idx + 5] = new Vector3(i,    deltasin1, j+1);
            }
        }    

        // poligonos
        triangles = new int[rows * columns * 6];

        for (int i = 0; i < triangles.Length; ++i)
        {
            triangles[i] = i;
        }

        // uv map
        uvmap = new Vector2[columns * rows * 6];

        for (int i = 0; i < columns; ++i)
        {
            for (int j = 0; j < rows; ++j)
            {
                int idx = (i * rows + j) * 6;
                uvmap[idx] = new Vector2(0.375f, 1f);
                uvmap[idx+1] = new Vector2(0.5f, 1f);
                uvmap[idx+2] = new Vector2(0.375f, 0.875f);

                uvmap[idx+3] = new Vector2(0.5f, 1f);
                uvmap[idx+4] = new Vector2(0.5f, 0.875f);
                uvmap[idx+5] = new Vector2(0.375f, 0.875f);
            }
        }

        Mesh mesh = new Mesh();
        mesh.vertices = vertex;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.uv = uvmap;
        filter = gameObject.GetComponent<MeshFilter>();
        filter.mesh = mesh;
    }
}
