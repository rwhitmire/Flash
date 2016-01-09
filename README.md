# Flash
Express-like flash messages for ASP.NET MVC

[![Build status](https://ci.appveyor.com/api/projects/status/skcbkn6de97ja0qi/branch/master?svg=true)](https://ci.appveyor.com/project/rwhitmire/flash/branch/master)

## Install
```
PM> Install-Package Flash.Mvc5
```

## Use
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
