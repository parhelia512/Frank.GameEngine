﻿namespace Frank.GameEngine.Rendering;

public interface IGraphicsDeviceContext
{
    bool IsInitialized { get; }
    
    void Initialize();
    
    void SetResolution(int width, int height);
    
    void SetFullscreen(bool fullscreen);
    
    void SetVSync(bool vsync);
    
    void SetFixedTimeStep(bool fixedTimeStep);
    
    void SetShowFps(bool showFps);
    
    void SetShowDebugInfo(bool showDebugInfo);
    
    void SetShowMouse(bool showMouse);
}