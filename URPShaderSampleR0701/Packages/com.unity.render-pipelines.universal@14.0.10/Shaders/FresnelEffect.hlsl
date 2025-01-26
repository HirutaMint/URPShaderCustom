#ifndef FRESNEL_EFFECT_INCLUDED
#define FRESNEL_EFFECT_INCLUDED

// フレネル効果の計算関数
float CalculateFresnel(float3 worldNormal, float3 viewDir, float power)
{
    // 法線と視線方向の内積を計算
    float fresnelFactor = 1.0 - max(dot(worldNormal, viewDir), 0.0);
    return pow(fresnelFactor, power); // フレネル効果を強調するための指数
}

#endif // FRESNEL_EFFECT_INCLUDED