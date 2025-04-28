using UnrealBuildTool;

public class OTG_DungeonTrain : ModuleRules
{
	public OTG_DungeonTrain(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
