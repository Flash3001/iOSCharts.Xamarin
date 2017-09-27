# iOSCharts.Xamarin

A Xamarin binding by Lucas Teixeira for Charts (ios-charts) by Daniel Cohen Gindi, inspired by Philipp Jahoda
https://github.com/danielgindi/Charts

<h2>Charts 3.0</h2>
Requires Xcode 8 as the project has moved to Swift3. It's also a breaking change. To see the release notes go to: https://github.com/danielgindi/Charts/releases/tag/v3.0.0

If you are updating from an older version of the library, please remove the Xamarin.Swift23.Support dependency, as it is not necessary anymore.

All the dependencies for Swift3 are already listed in the NuGet package. You can find the project for them in here: https://github.com/Flash3001/Xamarin.Swift3.Support

<h2>Important Notes for Charts 3.0.4 and Xcode 9</h2>
A version of the library was released to support Xcode 9 and it's dependencies in Nuget changed from Xamarin.Swift3.* to Xamarin.Swift4.* , please remove the old packages from your project.

<h2>Important Notes for Charts 2.2.5 and Xcode 8</h2>
If you updated to Xcode 8 there's a version of this library uploaded in NuGet pre-release channel.
https://www.nuget.org/packages/iOSCharts/2.2.5.2-xcode8

It is important as Xcode 8 dropped support for Swift 2.2 and now only works with 2.3 and 3.0.
This version was updated to work on 2.3.

Its SwiftSupport dependence has changed to https://github.com/Flash3001/Xamarin.Swift23.Support NuGet: https://www.nuget.org/packages/Xamarin.Swift23.Support/

<h2>Troubleshooting</h2>
When creating the IPA for publish you might get the following error:

<i>"Invalid Swift Support - The SwiftSupport folder is missing. Rebuild your app using the current public (GM) version of Xcode and resubmit it."</i>

When using Xcode 7 you might need use this script: https://github.com/jamesbar2/auto-ipa-packager or https://github.com/bq/ipa-packager

When using Xcode 8 (which updated Swift to 2.3 and 3.0) you should use this: https://github.com/Flash3001/ipa-packager

When using Xcode 9 (Swift 3.2 and 4.0) you should use this: https://github.com/Flash3001/ipa-packager

<h2>Binding Swift Libraries</h2>
If you got here after googling for a way to bind Swift libraries in Xamarin, you may find this Documentation useful: stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries 

In case you wish help, feel free to contact me https://twitter.com/flash3001

<h2>License</h2>
Copyright 2017 Lucas Teixeira, Daniel Cohen Gindi & Philipp Jahoda

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
