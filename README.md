# bugsnag-eat-exception-reproduce
Minimal ASP.NET MVC project reproduces Bugsnag issue about overriding exceptions.

Steps to reproduce:

1. Put API key in Web.config.
2. Build project.
3. Navigate to the root page "/".
4. Custom 500 page will be displayed.
5. Comment out Bugsnag action filter in Global.asax.cs.
6. Rebuild project.
7. Navigate to the root page "/".
8. Custom 500 page will be displayed again.
9. Open C:\logs\eat-exceptions.log.

In the log file will be two exceptions:

* One about not found error view.  This is the case then Bugsnag action filter activated.
* One about original exception -- InvalidOperationException.  This is the case then Bugsnag action filter disabled.
