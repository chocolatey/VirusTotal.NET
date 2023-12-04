#load nuget:?package=Chocolatey.Cake.Recipe&version=0.20.1

///////////////////////////////////////////////////////////////////////////////
// RECIPE SCRIPT
///////////////////////////////////////////////////////////////////////////////

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./",
                            testDirectoryPath: "./UnitTests",
                            solutionFilePath: "./VirusTotal.NET.sln",
                            solutionDirectoryPath: "./",
                            resharperSettingsFileName: "VirusTotal.NET.sln.DotSettings",
                            title: "VirusTotal.NET",
                            repositoryOwner: "chocolatey",
                            repositoryName: "VirusTotal.NET.sln",
                            productName: "Chocolatey VirusTotal.NET.sln",
                            productDescription: "chocolatey is a product of Chocolatey Software, Inc. - All Rights Reserved.",
                            productCopyright: string.Format("Copyright © 2017 - {0} Chocolatey Software, Inc. Copyright © 2011 - 2017, RealDimensions Software, LLC - All Rights Reserved.", DateTime.Now.Year),
                            shouldStrongNameSignDependentAssemblies: true,
                            treatWarningsAsErrors: false,
                            shouldRunNuGet: IsRunningOnWindows(),
                            shouldPublishAwsLambdas: false,
                            unitTestAssemblyProjectPattern: "/**/*[tT]ests.csproj",
                            shouldObfuscateOutputAssemblies: false,
                            shouldAuthenticodeSignOutputAssemblies: false,
                            shouldRunInspectCode: false,
                            shouldRunDotNetPack: true,
                            shouldGenerateSolutionVersionCSharpFile: false,
                            strongNameDependentAssembliesInputPath: "./packages/restsharp");

ToolSettings.SetToolSettings(context: Context);

BuildParameters.PrintParameters(Context);

Build.RunDotNet();