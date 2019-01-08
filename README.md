# Tools for your libraries [![Official Site](https://img.shields.io/badge/site-servodroid.com-orange.svg)](http://servodroid.com)

Format your .net object to be displayed on web. There is also a little web research tool, but not very efficient.

Tools.Utilities : [![Version Status](https://img.shields.io/nuget/v/Tools.Utilities.svg)](https://www.nuget.org/packages/Tools.Utilities/)
<br/>
Tools.Utilities.UI : [![Version Status](https://img.shields.io/nuget/v/Tools.Utilities.UI.svg)](https://www.nuget.org/packages/Tools.Utilities.UI/)
<br/>
Tools.Slider : [![Version Status](https://img.shields.io/nuget/v/Tools.Slider.svg)](https://www.nuget.org/packages/Tools.Slider/)
<br/>

[![License](https://img.shields.io/github/license/brandondahler/Data.HashFunction.svg)](https://raw.githubusercontent.com/ThibaultMontaufray/Tools4Libraries/master/License)
[![Build Status](https://travis-ci.org/ThibaultMontaufray/Tools4Libraries.svg?branch=master)](https://travis-ci.org/ThibaultMontaufray/Tools4Libraries) 
[![Build status](https://ci.appveyor.com/api/projects/status/sidmejyg6biq7gkr?svg=true)](https://ci.appveyor.com/project/ThibaultMontaufray/manager-database)
[![Issue Count](https://codeclimate.com/github/ThibaultMontaufray/Tools4Libraries/badges/issue_count.svg)](https://codeclimate.com/github/ThibaultMontaufray/Tools4Libraries)
[![Coverage Status](https://coveralls.io/repos/github/ThibaultMontaufray/Tools4Libraries/badge.svg?branch=master)](https://coveralls.io/github/ThibaultMontaufray/Tools4Libraries?branch=master)

# Usage examples

<h3>For pictures library : </h3>
```csharp
Image bigImg = Tools4Libraries.Resources.ResourceIconSet32Default.door_out;
Image smallImg = Tools4Libraries.Resources.ResourceIconSet16Default.door_out;
```

<h3>For config parameters :</h3>

if the config file is not present, the dll will create it by name :"configmanagers.xml"
here is an extrat of params :
```xml
		<proxy>
			<host>mysuperproxyname</host>
			<login>userlogin</login>
			<password>*****</password>
			<port>8080</port>
		</proxy>
```
and the code to use it :
```csharp
string proxyLogin = Tools4Libraries.Params.WebProxyLogin;
string proxyPassword = Tools4Libraries.Params.WebProxyPassword;
```
