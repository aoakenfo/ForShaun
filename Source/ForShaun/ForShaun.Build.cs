// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class ForShaun : ModuleRules
{
	public ForShaun(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "NiagaraCore",
                "Niagara",
                "NiagaraShader",
                "RenderCore",
                "UtilityShaders",
                "ShaderCore",
                "UnrealEd",
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "Niagara",
                "CoreUObject",
                "VectorVM",
                "RHI",
                "UtilityShaders",
                "ShaderCore",
            }
        );
    }
}
