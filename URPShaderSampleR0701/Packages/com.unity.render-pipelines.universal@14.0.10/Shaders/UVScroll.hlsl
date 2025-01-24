#ifndef UV_SCROLL_INCLUDED
#define UV_SCROLL_INCLUDED

// UVスクロール実行の関数
float2 ScrollUV(float2 uv, float2 scrollSpeed, float time)
{
    return uv + scrollSpeed * time;
}

#endif //UV_SCROLL_INCLUDED
