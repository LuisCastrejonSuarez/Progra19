using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedMesh : MonoBehaviour
{
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;
    private MeshFilter filter;
    private void Awake()
    {
        filter = gameObject.AddComponent<MeshFilter>();
    }
    private void Start()
    {
        CreateMesh();
    }
    private void Update()
    {
        //CreateMesh();
    }
    private void CreateMesh()
    {
        // vertices
        vertex = new Vector3[] {new Vector3(-1, -1, 1),     // vertice 0
                                new Vector3( 1, -1, 1),     // vertice 1
                                new Vector3( 1, -1, -1),    // vertice 2
                                new Vector3( -1, -1, -1),   // vertice 3
                                new Vector3(-1, 1, 1),      // vertice 4
                                new Vector3( 1, 1, 1),      // vertice 5
                                new Vector3( 1, 1, -1),     // vertice 6
                                new Vector3( -1, 1, -1)};   // vertice 7

        // poligonos
        triangles = new int[] { 4,5,6,
                                4,6,7,
                                0,2,1,
                                0,3,2,
                                7,6,2,
                                7,2,3,
                                4,7,3,
                                4,3,0,
                                6,5,1,
                                6,1,2,
                                5,4,0,
                                5,0,1};

        // uv map
        uvmap = new Vector2[] { new Vector2(1,0),
                                new Vector2(0,0),
                                new Vector2(0,1),
                                new Vector2(1,1),
                                new Vector2(1,0),
                                new Vector2(0,0),
                                new Vector2(0,1),
                                new Vector2(1,1),
                               };

        Mesh mesh = new Mesh();
        mesh.vertices = vertex;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.uv = uvmap;

        filter.mesh = mesh;
    }
}
