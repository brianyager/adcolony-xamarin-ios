using System;
using ObjCRuntime;

[assembly: LinkWith ("AdColony.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = false, ForceLoad = true, Frameworks = "AudioToolbox AdSupport AVFoundation CoreGraphics CoreMedia CoreTelephony EventKit EventKitUI Foundation MediaPlayer MessageUI QuartzCore Social StoreKit SystemConfiguration UIKit WebKit")]
