namespace DotNetARX;

/// <summary>
/// 进度条管理类,可以解决常规进度条显示闪烁的问题
/// </summary>
public class ProgressManager : IDisposable
{
    //更新进度条的次数,由于一些特殊原因,你必须把它设置为600
    const int progressMeterIncrements = 600;
    private readonly ProgressMeter pm;//进度条对象
    private long updateIncrement;//进度条需要更新的增量,即更新一次需要多少进度
    private long currentInc;//当前进度

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="message">进度条的显示信息</param>
    public ProgressManager(string message)
    {
        pm = new ProgressMeter();//新建一个进度条
        pm.Start(message);//进度条开始
        //设置进度条需要更新的次数
        pm.SetLimit(progressMeterIncrements);
        //设置当前进度为0
        currentInc = 0;
    }


    /// <summary>
    /// 设置进度条需要更新,一般为循环次数
    /// </summary>
    /// <param name="totalOps">循环次数</param>
    public void SetTotalOperations(long totalOps)
    {
        // 设置进度条需要更新的增量
        updateIncrement =
            totalOps > progressMeterIncrements ?
            totalOps / progressMeterIncrements :
            totalOps;
    }

    /// <summary>
    /// 当进度增量达到需要更新的量时,则更新进度条
    /// </summary>
    public void Tick()
    {
        //当进度增量达到需要更新的量时,则更新进度条
        if (++currentInc == updateIncrement)
        {
            pm.MeterProgress();//更新进度条
            currentInc = 0;//更新完毕,重置进度增量为0
            //让AutoCAD在长时间任务处理时仍然能接收消息
            System.Windows.Forms.Application.DoEvents();
        }
    }


    #region Dispose
    public bool Disposed = false;

    /// <summary>
    /// 显式调用Dispose方法,继承IDisposable
    /// </summary>
    public void Dispose()
    {
        //由手动释放
        Dispose(true);
        //通知垃圾回收机制不再调用终结器(析构器)_跑了这里就不会跑析构函数了
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// 析构函数,以备忘记了显式调用Dispose方法
    /// </summary>
    ~ProgressManager()
    {
        //由系统释放
        Dispose(false);
    }

    /// <summary>
    /// 释放
    /// </summary>
    /// <param name="ing"></param>
    protected virtual void Dispose(bool ing)
    {
        if (Disposed)
        {
            //不重复释放
            return;
        }
        //让类型知道自己已经被释放
        Disposed = true;

        pm.Stop();//停止进度条的更新
        pm.Dispose();//销毁进度条对象
    }
    #endregion

}
