using System;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace AdColonySDK
{

	// @interface AdColonyAdInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface AdColonyAdInfo
	{

		// @property (readonly, nonatomic) BOOL shown;
		[Export ("shown")]
		bool Shown { get; }

		// @property (readonly, nonatomic) NSString * zoneID;
		[Export ("zoneID")]
		string ZoneID { get; }

		// @property (readonly, nonatomic) BOOL iapEnabled;
		[Export ("iapEnabled")]
		bool IapEnabled { get; }

		// @property (readonly, nonatomic) NSString * iapProductID;
		[Export ("iapProductID")]
		string IapProductID { get; }

		// @property (readonly, nonatomic) int iapQuantity;
		[Export ("iapQuantity")]
		int IapQuantity { get; }

		// @property (readonly, nonatomic) ADCOLONY_IAP_ENGAGEMENT iapEngagementType;
		[Export ("iapEngagementType")]
		ADCOLONY_IAP_ENGAGEMENT IapEngagementType { get; }
	}

	// @protocol AdColonyDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AdColonyDelegate
	{

		// @optional -(void)onAdColonyAdAvailabilityChange:(BOOL)available inZone:(NSString *)zoneID;
		[Export ("onAdColonyAdAvailabilityChange:inZone:")]
		void OnAdColonyAdAvailabilityChange (bool available, string zoneID);

		// @optional -(void)onAdColonyV4VCReward:(BOOL)success currencyName:(NSString *)currencyName currencyAmount:(int)amount inZone:(NSString *)zoneID;
		[Export ("onAdColonyV4VCReward:currencyName:currencyAmount:inZone:")]
		void OnAdColonyV4VCReward (bool success, string currencyName, int amount, string zoneID);
	}

	// @protocol AdColonyAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AdColonyAdDelegate
	{

		// @optional -(void)onAdColonyAdStartedInZone:(NSString *)zoneID;
		[Export ("onAdColonyAdStartedInZone:")]
		void OnAdColonyAdStartedInZone (string zoneID);

		// @optional -(void)onAdColonyAdAttemptFinished:(BOOL)shown inZone:(NSString *)zoneID;
		[Export ("onAdColonyAdAttemptFinished:inZone:")]
		void OnAdColonyAdAttemptFinished (bool shown, string zoneID);

		// @optional -(void)onAdColonyAdFinishedWithInfo:(AdColonyAdInfo *)info;
		[Export ("onAdColonyAdFinishedWithInfo:")]
		void OnAdColonyAdFinishedWithInfo (AdColonyAdInfo info);
	};

	// @interface AdColony : NSObject
	[BaseType (typeof(NSObject))]
	interface AdColony
	{

		// +(void)configureWithAppID:(NSString *)appID zoneIDs:(NSArray *)zoneIDs delegate:(id<AdColonyDelegate>)del logging:(BOOL)log;
		[Static, Export ("configureWithAppID:zoneIDs:delegate:logging:")]
		void ConfigureWithAppID (string appID, NSObject[] zoneIDs, AdColonyDelegate del, bool log);

		// +(void)playVideoAdForZone:(NSString *)zoneID withDelegate:(id<AdColonyAdDelegate>)del;
		[Static, Export ("playVideoAdForZone:withDelegate:")]
		void PlayVideoAdForZone (string zoneID, AdColonyAdDelegate del);

		// +(void)playVideoAdForZone:(NSString *)zoneID withDelegate:(id<AdColonyAdDelegate>)del withV4VCPrePopup:(BOOL)showPrePopup andV4VCPostPopup:(BOOL)showPostPopup;
		[Static, Export ("playVideoAdForZone:withDelegate:withV4VCPrePopup:andV4VCPostPopup:")]
		void PlayVideoAdForZone (string zoneID, AdColonyAdDelegate del, bool showPrePopup, bool showPostPopup);

		// +(AdColonyNativeAdView *)getNativeAdForZone:(NSString *)zoneID presentingViewController:(UIViewController *)viewController;
		[Static, Export ("getNativeAdForZone:presentingViewController:")]
		AdColonyNativeAdView GetNativeAdForZone (string zoneID, UIViewController viewController);

		// +(ADCOLONY_ZONE_STATUS)zoneStatusForZone:(NSString *)zoneID;
		[Static, Export ("zoneStatusForZone:")]
		ADCOLONY_ZONE_STATUS ZoneStatusForZone (string zoneID);

		// +(void)setCustomID:(NSString *)customID;
		[Static, Export ("setCustomID:")]
		void SetCustomID (string customID);

		// +(NSString *)getCustomID;
		[Static, Export ("getCustomID")]
		string GetCustomID ();

		// +(NSString *)getOpenUDID;
		[Static, Export ("getOpenUDID")]
		string GetOpenUDID ();

		// +(NSString *)getUniqueDeviceID;
		[Static, Export ("getUniqueDeviceID")]
		string GetUniqueDeviceID ();

		// +(NSString *)getODIN1;
		[Static, Export ("getODIN1")]
		string GetODIN1 ();

		// +(NSString *)getAdvertisingIdentifier;
		[Static, Export ("getAdvertisingIdentifier")]
		string GetAdvertisingIdentifier ();

		// +(NSString *)getVendorIdentifier;
		[Static, Export ("getVendorIdentifier")]
		string GetVendorIdentifier ();

		// +(BOOL)isVirtualCurrencyRewardAvailableForZone:(NSString *)zoneID;
		[Static, Export ("isVirtualCurrencyRewardAvailableForZone:")]
		bool IsVirtualCurrencyRewardAvailableForZone (string zoneID);

		// +(int)getVirtualCurrencyRewardsAvailableTodayForZone:(NSString *)zoneID;
		[Static, Export ("getVirtualCurrencyRewardsAvailableTodayForZone:")]
		int GetVirtualCurrencyRewardsAvailableTodayForZone (string zoneID);

		// +(NSString *)getVirtualCurrencyNameForZone:(NSString *)zoneID;
		[Static, Export ("getVirtualCurrencyNameForZone:")]
		string GetVirtualCurrencyNameForZone (string zoneID);

		// +(int)getVirtualCurrencyRewardAmountForZone:(NSString *)zoneID;
		[Static, Export ("getVirtualCurrencyRewardAmountForZone:")]
		int GetVirtualCurrencyRewardAmountForZone (string zoneID);

		// +(int)getVideosPerReward:(NSString *)currencyName;
		[Static, Export ("getVideosPerReward:")]
		int GetVideosPerReward (string currencyName);

		// +(int)getVideoCreditBalance:(NSString *)currencyName;
		[Static, Export ("getVideoCreditBalance:")]
		int GetVideoCreditBalance (string currencyName);

		// +(void)cancelAd;
		[Static, Export ("cancelAd")]
		void CancelAd ();

		// +(BOOL)videoAdCurrentlyRunning;
		[Static, Export ("videoAdCurrentlyRunning")]
		bool VideoAdCurrentlyRunning ();

		// +(void)turnAllAdsOff;
		[Static, Export ("turnAllAdsOff")]
		void TurnAllAdsOff ();

		// +(void)setUserMetadata:(NSString *)metadataType withValue:(NSString *)value;
		[Static, Export ("setUserMetadata:withValue:")]
		void SetUserMetadata (string metadataType, string value);

		// +(void)userInterestedIn:(NSString *)topic;
		[Static, Export ("userInterestedIn:")]
		void UserInterestedIn (string topic);

		// +(void)notifyIAPComplete:(NSString *)transactionID productID:(NSString *)productID quantity:(int)quantity price:(NSNumber *)price currencyCode:(NSString *)currencyCode;
		[Static, Export ("notifyIAPComplete:productID:quantity:price:currencyCode:")]
		void NotifyIAPComplete (string transactionID, string productID, int quantity, NSNumber price, string currencyCode);
	}



	// @interface AdColonyNativeAdView : UIView
	[BaseType (typeof(UIView))]
	interface AdColonyNativeAdView
	{

		// @property (nonatomic, weak) id<AdColonyNativeAdDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<AdColonyNativeAdDelegate> delegate;
		[Wrap ("WeakDelegate")]
		AdColonyNativeAdDelegate Delegate { get; set; }

		// @property (readonly, nonatomic) NSString * advertiserName;
		[Export ("advertiserName")]
		string AdvertiserName { get; }

		// @property (readonly, nonatomic) UIImage * advertiserIcon;
		[Export ("advertiserIcon")]
		UIImage AdvertiserIcon { get; }

		// @property (readonly, nonatomic) NSString * adTitle;
		[Export ("adTitle")]
		string AdTitle { get; }

		// @property (readonly, nonatomic) NSString * adDescription;
		[Export ("adDescription")]
		string AdDescription { get; }

		// @property (readonly, nonatomic) UIButton * engagementButton;
		[Export ("engagementButton")]
		UIButton EngagementButton { get; }

		// @property (nonatomic) float volume;
		[Export ("volume")]
		float Volume { get; set; }

		// @property (nonatomic) BOOL muted;
		[Export ("muted")]
		bool Muted { get; set; }

		// -(CGFloat)recommendedHeightForWidth:(CGFloat)width;
		[Export ("recommendedHeightForWidth:")]
		nfloat RecommendedHeightForWidth (nfloat width);

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)resume;
		[Export ("resume")]
		void Resume ();
	}

	// @protocol AdColonyNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AdColonyNativeAdDelegate
	{

		// @optional -(void)onAdColonyNativeAdStarted:(AdColonyNativeAdView *)ad;
		[Export ("onAdColonyNativeAdStarted:")]
		void OnAdColonyNativeAdStarted (AdColonyNativeAdView ad);

		// @optional -(void)onAdColonyNativeAdExpanded:(AdColonyNativeAdView *)ad;
		[Export ("onAdColonyNativeAdExpanded:")]
		void OnAdColonyNativeAdExpanded (AdColonyNativeAdView ad);

		// @optional -(void)onAdColonyNativeAdFinished:(AdColonyNativeAdView *)ad expanded:(BOOL)expanded;
		[Export ("onAdColonyNativeAdFinished:expanded:")]
		void Expanded (AdColonyNativeAdView ad, bool expanded);

		// @optional -(void)onAdColonyNativeAd:(AdColonyNativeAdView *)ad finishedWithInfo:(AdColonyAdInfo *)info expanded:(BOOL)expanded;
		[Export ("onAdColonyNativeAd:finishedWithInfo:expanded:")]
		void FinishedWithInfo (AdColonyNativeAdView ad, AdColonyAdInfo info, bool expanded);

		// @optional -(void)onAdColonyNativeAd:(AdColonyNativeAdView *)ad muted:(BOOL)muted;
		[Export ("onAdColonyNativeAd:muted:")]
		void Muted (AdColonyNativeAdView ad, bool muted);

		// @optional -(void)onAdColonyNativeAdEngagementPressed:(AdColonyNativeAdView *)ad expanded:(BOOL)expanded;
		[Export ("onAdColonyNativeAdEngagementPressed:expanded:")]
		void ExpandedPressed (AdColonyNativeAdView ad, bool expanded);
	}


}

