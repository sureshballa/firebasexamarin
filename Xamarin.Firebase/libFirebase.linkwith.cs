// WARNING: this feature is deprecated, use the "Native References" folder instead.
using ObjCRuntime;

[assembly: LinkWith ("libFirebase.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, 
	Frameworks = "Security CFNetwork SystemConfiguration", 
	SmartLink = true, IsCxx = true, ForceLoad = true,LinkerFlags="-licucore")]