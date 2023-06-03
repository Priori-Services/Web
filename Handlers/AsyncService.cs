namespace PRIORI_SERVICES_WEB.Handler;

public interface IAsyncService
{
    public void RunTaskAsSync(Func<Task> asyncfun);
}

public class AsyncService : IAsyncService
{
    public void RunTaskAsSync(Func<Task> asyncfun)
    {
        try
        {
            asyncfun().RunSynchronously();
        }
        catch (Exception e) when (e is ObjectDisposedException || e is InvalidOperationException) { }
    }
}
