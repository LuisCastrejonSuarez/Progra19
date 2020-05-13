using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class GeneratedPatternMesh : MonoBehaviour
{
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;

    public int columns = 3;
    public int rows = 2;

    private MeshFilter filter;
    private List<Vector2[]> uvmaps;

    private void Awake()
    {
        Vector2[] tmp;
        uvmaps = new List<Vector2[]>();
        // arriba
        tmp = new Vector2[6];
        tmp[0] = new Vector2(0, 1);
        tmp[1] = new Vector2(1, 1);
        tmp[2] = new Vector2(0, 0);
        tmp[3] = new Vector2(1, 1);
        tmp[4] = new Vector2(1, 0);
        tmp[5] = new Vector2(0, 0);
        uvmaps.Add(tmp);

        // izquierda
        tmp = new Vector2[6];
        tmp[0] = new Vector2(1, 1);
        tmp[1] = new Vector2(1, 0);
        tmp[2] = new Vector2(0, 1);
        tmp[3] = new Vector2(1, 0);
        tmp[4] = new Vector2(0, 0);
        tmp[5] = new Vector2(0, 1);
        uvmaps.Add(tmp);

        // derecha
        tmp = new Vector2[6];
        tmp[0] = new Vector2(0, 0);
        tmp[1] = new Vector2(0, 1);
        tmp[2] = new Vector2(1, 0);
        tmp[3] = new Vector2(0, 1);
        tmp[4] = new Vector2(1, 1);
        tmp[5] = new Vector2(1, 0);
        uvmaps.Add(tmp);

        // abajo
        tmp = new Vector2[6];
        tmp[0] = new Vector2(1, 0);
        tmp[1] = new Vector2(0, 0);
        tmp[2] = new Vector2(1, 1);
        tmp[3] = new Vector2(0, 0);
        tmp[4] = new Vector2(0, 1);
        tmp[5] = new Vector2(1, 1);
        uvmaps.Add(tmp);
    }

    private void Start()
    {
        CreateMesh();
    }
    private void Update()
    {
        
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

                vertex[idx]     = new Vector3(i,    0, j);
                vertex[idx + 1] = new Vector3(i+1,  0, j);
                vertex[idx + 2] = new Vector3(i,    0, j+1);

                vertex[idx + 3] = new Vector3(i+1,  0, j);
                vertex[idx + 4] = new Vector3(i+1,  0, j+1);
                vertex[idx + 5] = new Vector3(i,    0, j+1);
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
                Vector2[] tmp = uvmaps[UnityEngine.Random.Range(0, uvmaps.Count)];

                uvmap[idx] = tmp[0];
                uvmap[idx+1] = tmp[1];
                uvmap[idx+2] = tmp[2];

                uvmap[idx+3] = tmp[3];
                uvmap[idx+4] = tmp[4];
                uvmap[idx+5] = tmp[5];
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
