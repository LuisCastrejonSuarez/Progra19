using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTransform : MonoBehaviour
{
    public Vector3 EulerAngles;
    private MeshFilter filter;
    private Vector3[] overtex;
    private Vector3[] tvertex;
    void Start()
    {
        filter = GetComponent<MeshFilter>();
        overtex = filter.mesh.vertices;
        tvertex = new Vector3[overtex.Length];
        
    }
    private void Update()
    {
        Quaternion quat = Quaternion.Euler(EulerAngles);
        Matrix4x4 m = Matrix4x4.Rotate(quat);
        for(int i=0;i<overtex.Length;++i)
        {
            tvertex[i] = m.MultiplyPoint3x4(overtex[i]);
        }
        filter.mesh.vertices = tvertex;
    }
}
