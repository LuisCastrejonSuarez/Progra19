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
        vertex = new Vector3[]
        {
            /* vertices inferiores */
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
            new Vector3( -1, 1, -1),    // vertice 8
            new Vector3( 1, 1, -1),     // vertice 9
            new Vector3( 1, -1, -1),    // vertice 10
            new Vector3( -1, -1, -1),   // vertice 11
            /* vertices derecho */
            new Vector3( 1, 1, -1 ),    // vertice 12
            new Vector3( 1, 1, 1),      // vertice 13
            new Vector3( 1, -1, 1),     // vertice 14
            new Vector3( 1, -1, -1),    // vertice 15
            /* vertices izquierdo */
            new Vector3( -1, 1, 1),     // vertice 16
            new Vector3( -1, 1, -1),    // vertice 17
            new Vector3( -1, -1, -1),   // vertice 18
            new Vector3( -1, -1, 1),    // vertice 19
            /* vertices trasero */
            new Vector3( 1, 1, 1),      // vertice 20
            new Vector3( -1, 1, 1),     // vertice 21
            new Vector3( -1, -1, 1),    // vertice 22
            new Vector3( 1, -1, 1),     // vertice 23
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
                                // cara derecha
                                12,13,14,
                                12,14,15,
                                // cara izquierda
                                16,17,18,
                                16,18,19,
                                // cara trasera
                                20,21,22,
                                20,22,23,
                                };
        // uv map
        uvmap = new Vector2[] { /* vertices inferiores */
                                new Vector2(0.75f,1),
                                new Vector2(0.625f,1),
                                new Vector2(0.625f,0.875f),
                                new Vector2(0.75f,0.875f),
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
                                /* vertices derecho */
                                new Vector2(0.250f,1),
                                new Vector2(0.375f,1),
                                new Vector2(0.375f,0.875f),
                                new Vector2(0.250f,0.875f),
                                /* vertices izquierdo */
                                new Vector2(0.375f,1),
                                new Vector2(0.5f,1),
                                new Vector2(0.5f,0.875f),
                                new Vector2(0.375f,0.875f),
                                /* vertices trasero */
                                new Vector2(0.5f,1),
                                new Vector2(0.625f,1),
                                new Vector2(0.625f,0.875f),
                                new Vector2(0.5f,0.875f),
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
