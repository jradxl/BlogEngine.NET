## Linux/Mono BlogEngine.NET Source Code
Initial attempt at a Linux/Mono/MonoDevelop alternative.
Currently version 1003.3.7 which follows BlogEngine 3.3.7.
(I'm using 1000 more so I can track underlying BlogEngine changes!!).
This repository will always show commit differences to BlogEngine, as I am reapplying changes carefully using meld.
Main changes here are because Linux is filesystem case sensitive.
</br>

## Original BlogEngine.NET Source Code
This repository provides latest source code for BlogEngine.NET project (https://github.com/rxtur/BlogEngine.NET)
</br>

## Environment
  * Mono (Mono JIT compiler version 5.20.1.19) and MonoDevelop (Version 7.8.2 (build 2))
  * ASP.NET 4.5 +
</br>

## Get started
  1. Install Mono and MonoDevelop from PPA, as per their website.
  2. Install Mono-XSP4 webserver.
  3. Clone repository
  4. Open solution in MonoDevelop (I'm using Ubuntu 18.04)
  5. Builld and run solution to load website in the browser
  6. Use admin/admin to log into website administration
</br>

![dashboard-3](https://cloud.githubusercontent.com/assets/1932785/11760070/0012f9d8-a052-11e5-84a8-e9097cb85f23.png)
</br>

## Themes
We will share everything about themes and how you can create your own theme on [This page](http://francis.bio/BlogEngine/).
</br>

## What's not working
Comments as there is something wrong with the Ajax mechanisms.
BlogEngine.Tests, as won't load in MonoDevelop.
</br>

## Notes
##### Packages in BlogEngine.Core upgraded:-
Microsoft.Web.Xdt 3.0.0
Newtonsoft.Json 12.0.1
Nuget.Core 2.14.0

</br>


## My live site is at:-
[jsrsoft.co.uk/blog](https://jsrsoft.co.uk)
</br>

## Updated
April 2019
