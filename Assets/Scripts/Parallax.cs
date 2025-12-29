using NUnit.Framework.Constraints;
using UnityEngine;

public class Background : MonoBehaviour
{
    private MeshRenderer meshRenderer; //for moving environment (background and foreground)
    public float animationSpeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
