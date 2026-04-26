using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
public struct CursorSettings
{
    public int trail_length;
    public float blur_size;
    public float max_opacity;
    public float opacity_decay;
    public float size_decay;

    [MarshalAs(UnmanagedType.I1)] public bool use_images;

    public float trail_r, trail_g, trail_b;
    public float cursor_r, cursor_g, cursor_b;
    public float white_center_ratio;

    [MarshalAs(UnmanagedType.I1)] public bool enable_glow;
    [MarshalAs(UnmanagedType.I1)] public bool enable_white_center;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string cursor_image_path;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string trail_image_path;

    [MarshalAs(UnmanagedType.I1)] public bool enable_motion_blur;
    public float blur_intensity;
}