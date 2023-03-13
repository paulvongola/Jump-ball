using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Start is called before the first frame update
/*[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]*/

public class Triangle : MonoBehaviour
{

    Mesh m;
    MeshFilter mf;
    // Use this for initialization




    /* public float stemLength;
         public float stemWidth;
         public float tipLength;
         public float tipWidth;

         [System.NonSerialized]
         public List<Vector3> verticesList;
         [System.NonSerialized]
         public List<int> trianglesList;

         Mesh mesh;*/

    void Start()
    {/*
            //make sure Mesh Renderer has a material
            mesh = new Mesh();
            this.GetComponent<MeshFilter>().mesh = mesh;*/
        mf = GetComponent();
        m = new Mesh();
        mf.mesh = m;
        drawTriangle();


    }

    void Update()
    {
        //GenerateArrow();
    }

    //arrow is generated starting at Vector3.zero
    //arrow is generated facing right, towards radian 0.
    /*void GenerateArrow()
    {
        //setup
        verticesList = new List<Vector3>();
        trianglesList = new List<int>();

        //stem setup
        Vector3 stemOrigin = Vector3.zero;
        float stemHalfWidth = stemWidth / 2f;
        //Stem points
        verticesList.Add(stemOrigin + (stemHalfWidth * Vector3.down));
        verticesList.Add(stemOrigin + (stemHalfWidth * Vector3.up));
        verticesList.Add(verticesList[0] + (stemLength * Vector3.right));
        verticesList.Add(verticesList[1] + (stemLength * Vector3.right));

        //Stem triangles
        trianglesList.Add(0);
        trianglesList.Add(1);
        trianglesList.Add(3);

        trianglesList.Add(0);
        trianglesList.Add(3);
        trianglesList.Add(2);

        //tip setup
        Vector3 tipOrigin = stemLength * Vector3.right;
        float tipHalfWidth = tipWidth / 2;

        //tip points
        verticesList.Add(tipOrigin + (tipHalfWidth * Vector3.up));
        verticesList.Add(tipOrigin + (tipHalfWidth * Vector3.down));
        verticesList.Add(tipOrigin + (tipLength * Vector3.right));

        //tip triangle
        trianglesList.Add(4);
        trianglesList.Add(6);
        trianglesList.Add(5);

        //assign lists to mesh.
        mesh.vertices = verticesList.ToArray();
        mesh.triangles = trianglesList.ToArray();
    }*/
    void drawTriangle()
    {
        //We need two arrays one to hold the vertices and one to hold the triangles
        Vector3[] VerteicesArray = new Vector3[3];
        int[] trianglesArray = new int[3];

        //lets add 3 vertices in the 3d space
        VerteicesArray[0] = new Vector3(0, 1, 0);
        VerteicesArray[1] = new Vector3(-1, 0, 0);
        VerteicesArray[2] = new Vector3(1, 0, 0);

        //define the order in which the vertices in the VerteicesArray shoudl be used to draw the triangle
        trianglesArray[0] = 0;
        trianglesArray[1] = 1;
        trianglesArray[2] = 2;

        //add these two triangles to the mesh
        m.vertices = VerteicesArray;
        m.triangles = trianglesArray;
    }
}