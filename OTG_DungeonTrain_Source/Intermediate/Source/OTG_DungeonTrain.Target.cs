using UnrealBuildTool;

public class OTG_DungeonTrainTarget : TargetRules
{
	public OTG_DungeonTrainTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("OTG_DungeonTrain");
	}
}
