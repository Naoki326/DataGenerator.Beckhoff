using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Collections.Concurrent;

namespace PlcCore.Data
{

    //通信循环
    public sealed class CircleManager : IDisposable
    {
        private ConcurrentBag<IBaseData> circleCallbacks = new ConcurrentBag<IBaseData>();
        public CircleManager()
        {
        }

        //public void Shuffle()
        //{
        //    int currentIndex;
        //    IBaseData temp;
        //    Random rd = new Random();
        //    for (int i = circleCallbacks.Count - 1; i >= 0; i--)
        //    {
        //        currentIndex = rd.Next(0, i + 1);
        //        temp = circleCallbacks[currentIndex];
        //        circleCallbacks[currentIndex] = circleCallbacks[i];
        //        circleCallbacks[i] = temp;
        //    }
        //}

        Mutex mutex = new Mutex();

        public void AddCircleCallbacks(IEnumerable<IBaseData> ccs)
        {
            mutex.WaitOne();
            circleCallbacks = new ConcurrentBag<IBaseData>(circleCallbacks.Union(ccs));
            mutex.ReleaseMutex();
        }

        public void AddCircleCallback(IBaseData cc)
        {
            mutex.WaitOne();
            if (!circleCallbacks.Contains(cc))
            { circleCallbacks.Add(cc); }
            mutex.ReleaseMutex();
        }

        public void ClearCircleCallbacks()
        {
            while (circleCallbacks.TryTake(out _))
            {
                // 逐个移除元素
            }
        }

        public void StartCircle()
        {
            disposeToken = new CancellationTokenSource();
            readTask = Task.Factory.StartNew(readCircle, TaskCreationOptions.LongRunning);
        }

        private Task readTask = default!;

        public void StopCircle()
        {
            disposeToken?.Cancel();
            try
            {
                readTask?.Wait();
            }
            catch (AggregateException ex)
                when (ex.InnerException is OperationCanceledException)
            { }
            catch (OperationCanceledException) { }
        }


        private CancellationTokenSource disposeToken = default!;

        private bool disposedValue;

        public int ReadCircleSleepTime { get; set; } = 50;
        public int ReadSleepTime { get; set; } = 50;

        private IEnumerable<IBaseData> GetLeaf(IBaseData node)
        {
            if (node is null)
            {
                yield break;
            }
            if (!node.Children.Any())
            {
                yield return node;
                yield break;
            }
            foreach(var child in node.Children)
            {
                foreach(var leaf in GetLeaf(child))
                {
                    yield return leaf;
                }
            }
        }


        private void readCircle()
        {
            foreach (var callback in circleCallbacks)
            {
                if (disposeToken.IsCancellationRequested)
                    break;
                try
                {
                    foreach (var leaf in GetLeaf(callback))
                    {
                        if (leaf is BaseData b)
                        {
                            b.Refresh();
                            b.Init();
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    if (disposeToken.IsCancellationRequested)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"callback instance:{callback}, \r\nCircleManager Read Exception: {ex.Message}");
                }
                finally
                {
                    Thread.Sleep(ReadSleepTime);
                }
            }
            while (!disposeToken.IsCancellationRequested)
            {
                Thread.Sleep(ReadCircleSleepTime);
                foreach (var callback in circleCallbacks)
                {
                    if (disposeToken.IsCancellationRequested)
                        break;
                    try
                    {
                        callback.Refresh(token: disposeToken.Token);
                        callback.CheckAndNotify(token: disposeToken.Token);
                    }
                    catch (OperationCanceledException)
                    {
                        if (disposeToken.IsCancellationRequested)
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"callback instance:{callback}, \r\nCircleManager Read Exception: {ex.Message}");
                    }
                    finally
                    {
                        Thread.Sleep(ReadSleepTime);
                    }
                }
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    StopCircle();
                }
                // TODO: 释放未托管的资源(未托管的对象)并重写终结器

                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        //// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        //~CircleManager()
        //{
        //    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //    Dispose(disposing: false);
        //}

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
