using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class GeneratedMesh : MonoBehaviour
{
    public Vector3[] vertex;
    public Vector2[] uvmap;
    public int[] triangles;
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
        vertex = new Vector3[]{ /* vertices inferiores */
                                new Vector3(-1, -1, 1),     // vertice 0
                                new Vector3( 1, -1, 1),     // vertice 1
                                new Vector3( 1, -1, -1),    // vertice 2
                                new Vector3( -1, -1, -1),   // vertice 3
                                /* vertices superiores */
                                new Vector3(-1, 1, 1),      // vertice 4
                                new Vector3( 1, 1, 1),      // vertice 5
                                new Vector3( 1, 1, -1),     // vertice 6
                                new Vector3( -1, 1, -1),    // vertice 7
                                /* vertices frontales */
                                new Vector3( -1, 1, -1),     // vertice 8
                                new Vector3( 1, 1, -1),     // vertice 9
                                new Vector3( 1, -1, -1),     // vertice 10
                                new Vector3( -1, -1, -1),     // vertice 11
        };   

        // poligonos
        triangles = new int[] { // cara superior
                                4,5,6, 
                                4,6,7,
                                // cara inferior
                                0,2,1,
                                0,3,2,
                                // cara frontal
                                8,9,10,
                                8,10,11,
                                };

        // uv map
        uvmap = new Vector2[] { /* vertices inferiores */
                                new Vector2(0.250f,1),
                                new Vector2(0.125f,1),
                                new Vector2(0.125f,0.875f),
                                new Vector2(0.250f,0.875f),
                                /* vertices superiores */
                                new Vector2(0,1),
                                new Vector2(0.125f,1),
                                new Vector2(0.125f,0.875f),
                                new Vector2(0,0.875f),
                                /* vertices frontales */
                                new Vector2(0.125f,1),
                                new Vector2(0.250f,1),
                                new Vector2(0.250f,0.875f),
                                new Vector2(0.125f,0.875f),
                               };

        Mesh mesh = new Mesh();
        mesh.vertices = vertex;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        mesh.uv = uvmap;
        filter = gameObject.GetComponent<MeshFilter>();
        filter.mesh = mesh;
    }
}
