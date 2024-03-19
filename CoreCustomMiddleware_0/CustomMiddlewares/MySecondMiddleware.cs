namespace CoreCustomMiddleware_0.CustomMiddlewares
{
    public class MySecondMiddleware
    {
        RequestDelegate _requestDelegate;

        public MySecondMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);

            if (context.Response.StatusCode == StatusCodes.Status200OK)
                await context.Response.WriteAsync("Basarili");
            else
                await context.Response.WriteAsync("Bulunamadi");
        }
    }
}
