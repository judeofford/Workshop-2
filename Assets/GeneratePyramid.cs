using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GeneratePyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = CreateMesh();
    }

    private Mesh CreateMesh()
    {
        var mesh = new Mesh
        {
            name = "Pyramid"
        };

        mesh.SetVertices(new[]
        {
            // Front Face
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            
            // Left Face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),

            // Back Face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, -1.0f),

            // Right Face
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f, -1.0f, -1.0f),

            // Bottom Face
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),

            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, -1.0f)

        });

        mesh.SetColors(new[]
        {
            // Front Face
            Color.yellow,
            Color.yellow,
            Color.yellow,

            // Left Face
            Color.blue,
            Color.blue,
            Color.blue,

            // Back Face
            Color.red, 
            Color.red,
            Color.red,

            // Right Face
            Color.blue,
            Color.blue,
            Color.blue,

            // Bottom Face
            Color.green, 
            Color.green,
            Color.green,
            
            Color.green, 
            Color.green,
            Color.green,
        });

        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        return mesh;
    }
}
