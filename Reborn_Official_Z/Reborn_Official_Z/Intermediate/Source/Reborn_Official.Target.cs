using UnrealBuildTool;

public class Reborn_OfficialTarget : TargetRules
{
	public Reborn_OfficialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Reborn_Official");
	}
}
