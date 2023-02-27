namespace DotNetARX;

/// <summary>
/// 视口操作类
/// </summary>
public static class ViewportTools
{
#pragma warning disable CA1806 // 不要忽略方法结果

    [DllImport("acad.exe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?acedSetCurrentVPort@@YA?AW4ErrorStatus@Acad@@PBVAcDbViewport@@@Z")]
    extern static int acedSetCurrentVPort(IntPtr AcDbVport);
    [DllImport("acad.exe", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?acedSetCurrentVPort@@YA?AW4ErrorStatus@Acad@@H@Z")]
    extern static int acedSetCurrentVPort(int vpnumber);
    /// <summary>
    /// 将视口置为当前
    /// </summary>
    /// <param name="editor">命令行对象</param>
    /// <param name="vport">视口对象</param>
#pragma warning disable IDE0060 // 删除未使用的参数
    public static void SetCurrentVPort(this Editor editor, Viewport vport)
    {
        acedSetCurrentVPort(vport.UnmanagedObject);
    }

    /// <summary>
    /// 将视口置为当前
    /// </summary>
    /// <param name="editor">命令行对象</param>
    /// <param name="vportNumber">视口编号</param>
    public static void SetCurrentVPort(this Editor editor, int vportNumber)
    {
        acedSetCurrentVPort(vportNumber);
    }
#pragma warning restore IDE0060 // 删除未使用的参数

    /// <summary>
    /// 获取当前活动视口
    /// </summary>
    /// <param name="db">数据库对象</param>
    /// <returns>返回当前活动视口的Id</returns>
    public static ObjectId CurrentViewportTableRecordId(this Database db)
    {
        var vtrId = ObjectId.Null;
        var vt = (ViewportTable)db.ViewportTableId.GetObject(OpenMode.ForRead);
        foreach (ObjectId id in vt)
        {
            if (!id.IsErased)
            {
                vtrId = id;
                break;
            }
        }
        return vtrId;
    }
#pragma warning restore CA1806 // 不要忽略方法结果
}
