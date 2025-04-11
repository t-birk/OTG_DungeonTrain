using UnrealBuildTool;

public class OTG_DungeonTrainServerTarget : TargetRules
{
	public OTG_DungeonTrainServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("OTG_DungeonTrain");
	}
}
