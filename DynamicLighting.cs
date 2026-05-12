#include "Components/PointLightComponent.h"

void ANoirLightController::SetCinematicLighting(FLinearColor AIColor, float Intensity, bool bEnableVolumetric)
{
    // PointLightComponent is the physical lamp in the scene
    if (PointLight)
    {
        // Set the color suggested by the AI (e.g., Cold Blue or Dim Orange)
        PointLight->SetLightColor(AIColor);
        
        // Set intensity (Noir typically uses high intensity but small radius)
        PointLight->SetIntensity(Intensity);

        // Volumetric scattering creates the "smoky" look in Noir
        PointLight->bAffectReflection = true;
        PointLight->SetVolumetricScatteringIntensity(bEnableVolumetric ? 2.0f : 0.0f);
        
        // Ensure sharp shadows for that classic detective silhouette
        PointLight->ShadowResolutionScale = 2.0f;
    }
}
