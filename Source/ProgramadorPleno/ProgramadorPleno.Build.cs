// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProgramadorPleno : ModuleRules
{
	public ProgramadorPleno(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProgramadorPleno",
			"ProgramadorPleno/Variant_Platforming",
			"ProgramadorPleno/Variant_Platforming/Animation",
			"ProgramadorPleno/Variant_Combat",
			"ProgramadorPleno/Variant_Combat/AI",
			"ProgramadorPleno/Variant_Combat/Animation",
			"ProgramadorPleno/Variant_Combat/Gameplay",
			"ProgramadorPleno/Variant_Combat/Interfaces",
			"ProgramadorPleno/Variant_Combat/UI",
			"ProgramadorPleno/Variant_SideScrolling",
			"ProgramadorPleno/Variant_SideScrolling/AI",
			"ProgramadorPleno/Variant_SideScrolling/Gameplay",
			"ProgramadorPleno/Variant_SideScrolling/Interfaces",
			"ProgramadorPleno/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
