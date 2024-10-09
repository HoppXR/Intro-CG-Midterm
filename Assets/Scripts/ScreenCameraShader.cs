using UnityEngine;

public class ScreenCameraShader : MonoBehaviour
{
    [SerializeField] private Material renderMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, renderMaterial);
    }
}
