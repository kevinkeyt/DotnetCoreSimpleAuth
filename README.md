# DotnetCoreSimpleAuth
**A simple dotnet core razor application that uses basic cookie authentication.**

This application adds the needed framework and files to use basic cookie and login information to your dotnet core application.
It's meant to be used for small sites where you might have just one user needing to login to view secure information. 

**You can setup the needed AppSettings using user secrets in core using the following commands.**
```
dotnet user-secrets set AppSettings:LoginEmail "joe@testing.com"
dotnet user-secrets set AppSettings:LoginPassword "Passw0rd"
dotnet user-secrets set AppSettings:FullName "Joe Tester"
```

If you would like a full description of the code you can view a post on my blog that goes into more detail here. 
(http://kevinkeyt.com/post/cookie-auth-with-dotnet-core)
