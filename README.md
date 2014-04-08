TumblrSharp
===========

Copy of the DontPanic.TumblrSharp repo, but improved.
Original code found on http://tumblrsharp.codeplex.com/

#Tumblr#
A fully featured C# Tumblr client for Windows 8, Windows Phone 8 and WPF. Includes multi-photo posting using multipart forms. 

#Main Features 
- Fully featured client for the Tumblr v2 API (http://www.tumblr.com/docs/en/api/v2)
- Core libraries are built as PCLs
- Can be used from .NET 4.5, Windows Store or Windows Phone 8 apps
- Extensible model

#Obtaining the binaries
You can download the project and compile the source yourself.

#Overview
Tumblr# is composed by two main assemblies: DontPanic.TumblrSharp. This is the main assembly and includes a base client for Tumblr. This client provides a few generic methods to call into the Tumblr API and expects the caller to provide the business entities to which to deserialize Tumblr's JSON responses. If you want to work with your types, you can just reference this assembly.
DontPanic.TumblrSharp.Client. This assembly contains a fully featured client and a whole set of business entities representing the responses received from the Tumblr API.
These assemblies are built as PCLs targeting: Windows 8
Windows Phone 8
.NET 4.5
Since PCLs have limited access to the .NET framework API (basically the intersection of all the selected platforms) I had to abstract out the cryptographic classes required to sign the OAuth requests as an interface and take that interface as a dependency. When creating instances of the OAuthClient or TumblrClient classes you will have to pass a concrete implementation of this dependency - or simply use one of the provided platform-specific extensions: 
DontPanic.TumblrSharp.WinRT
DontPanic.TumblrSharp.WP8
DontPanic.TumblrSharp.Net45
These assemblies contain a concrete implementation of the crypto dependency and also a couple of useful factory classes to create instances of the OAuthClient and the TumblrClient without having to pass the dependency.