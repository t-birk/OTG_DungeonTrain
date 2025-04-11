using UnrealBuildTool;

public class OTG_DungeonTrainClientTarget : TargetRules
{
	public OTG_DungeonTrainClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("OTG_DungeonTrain");
	}
}
