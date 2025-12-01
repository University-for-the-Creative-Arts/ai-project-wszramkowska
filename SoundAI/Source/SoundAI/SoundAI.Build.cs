// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SoundAI : ModuleRules
{
	public SoundAI(ReadOnlyTargetRules Target) : base(Target)
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
			"SoundAI",
			"SoundAI/Variant_Platforming",
			"SoundAI/Variant_Platforming/Animation",
			"SoundAI/Variant_Combat",
			"SoundAI/Variant_Combat/AI",
			"SoundAI/Variant_Combat/Animation",
			"SoundAI/Variant_Combat/Gameplay",
			"SoundAI/Variant_Combat/Interfaces",
			"SoundAI/Variant_Combat/UI",
			"SoundAI/Variant_SideScrolling",
			"SoundAI/Variant_SideScrolling/AI",
			"SoundAI/Variant_SideScrolling/Gameplay",
			"SoundAI/Variant_SideScrolling/Interfaces",
			"SoundAI/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
