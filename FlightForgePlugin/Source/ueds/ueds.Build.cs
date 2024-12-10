// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ueds : ModuleRules
{
	public ueds(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		bEnableUndefinedIdentifierWarnings = false;
	    bEnableExceptions = true;
	    bUseRTTI = true;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Networking", "Sockets" });
		PrivateDependencyModuleNames.AddRange(new string[] { "MessageSerialization", "ProceduralMeshComponent" });

		string thirdPartyIncludePath = Path.GetFullPath(Path.Combine(ModuleDirectory, "../ThirdParty/include"));
		PublicIncludePaths.AddRange(new string[] {thirdPartyIncludePath});
		
		PrivateIncludePaths.AddRange(new string[] {thirdPartyIncludePath, "MessageSerialization/Private"});
		PrivateIncludePaths.Add("MessageSerialization/Public");
	}
}
