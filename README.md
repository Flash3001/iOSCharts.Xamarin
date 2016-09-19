# iOSCharts.Xamarin

A Xamarin port by Lucas Teixeira for Charts (ios-charts) by Daniel Cohen Gindi, inspired by Philipp Jahoda
https://github.com/danielgindi/Charts

<h2>Important Notes for Xcode 8</h2>
If you updated to Xcode 8 there's a version of this library uploaded in NuGet pre-release channel.
https://www.nuget.org/packages/iOSCharts/2.2.5.2-xcode8

Its SwiftSupport dependence has changed to https://github.com/Flash3001/Xamarin.Swift23.Support

<h2>Troubleshooting</h2>
When creating the IPA for publish you might get the following error:

<i>"Invalid Swift Support - The SwiftSupport folder is missing. Rebuild your app using the current public (GM) version of Xcode and resubmit it."</i>

When using Xcode 7 you might need use this script: https://github.com/jamesbar2/auto-ipa-packager or https://github.com/bq/ipa-packager

When using Xcode 8 (which updated Swift to 2.3 and 3.0) you should use this: https://github.com/Flash3001/ipa-packager


<h2>License</h2>
Copyright 2016 Lucas Teixeira, Daniel Cohen Gindi & Philipp Jahoda

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
