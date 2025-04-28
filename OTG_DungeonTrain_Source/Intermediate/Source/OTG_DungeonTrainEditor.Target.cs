using UnrealBuildTool;

public class OTG_DungeonTrainEditorTarget : TargetRules
{
	public OTG_DungeonTrainEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("OTG_DungeonTrain");
	}
}
