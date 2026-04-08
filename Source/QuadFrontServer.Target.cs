using UnrealBuildTool;
using System.Collections.Generic;

public class QuadFrontServerTarget : TargetRules
{
    public QuadFrontServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        ExtraModuleNames.Add("QuadFront");
    }
}