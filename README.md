# Flash
Express-like flash messages for ASP.NET MVC

MyController.cs
``` csharp
public ActionResult Index()
{
    Request.Flash("success", "it worked!");
    return View();
}
```

_Layout.cshtml
``` html
@foreach (var flash in Request.GetFlashMessages())
{
    <div>@flash.Type @flash.Message</div>
}
```
