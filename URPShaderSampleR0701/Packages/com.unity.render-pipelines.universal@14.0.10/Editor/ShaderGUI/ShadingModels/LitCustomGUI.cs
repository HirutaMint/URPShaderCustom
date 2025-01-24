﻿using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class LitCustomGUI
    {
        public struct LitProperties
        {
            //UVスクロール機能の管理用フラグ
            public MaterialProperty uv_Scroll;

            public LitProperties(MaterialProperty[] properties)
            {
                uv_Scroll = BaseShaderGUI.FindProperty("_uv_Scroll", properties, false);
            }
        }
        
    }
}