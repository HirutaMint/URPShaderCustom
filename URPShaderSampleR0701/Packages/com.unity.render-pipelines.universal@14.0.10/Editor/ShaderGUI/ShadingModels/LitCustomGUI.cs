using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class LitCustomGUI
    {
        public struct LitProperties
        {
            //UVスクロール機能の管理用フラグ
            public MaterialProperty uv_Scroll;
            //UVスクロールの速度
            public MaterialProperty scrollSpeed;
            //フレネル効果の管理用フラグ
            public MaterialProperty useFresnel;
            //フレネル効果の強度
            public MaterialProperty fresnelPower;
            //フレネル効果の色
            public MaterialProperty fresnelColor;

            public LitProperties(MaterialProperty[] properties)
            {
                uv_Scroll = BaseShaderGUI.FindProperty("_Uv_Scroll", properties, false);
                scrollSpeed = BaseShaderGUI.FindProperty("_ScrollSpeed", properties, false);
                useFresnel = BaseShaderGUI.FindProperty("_Use_Fresnel", properties, false);
                fresnelPower = BaseShaderGUI.FindProperty("_FresnelPower", properties, false);
                fresnelColor = BaseShaderGUI.FindProperty("_FresnelColor", properties, false);
            }
        }
        
    }
}