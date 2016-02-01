using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Xamarin.Firebase
{
	// @interface FDataSnapshot : NSObject
	[BaseType (typeof(NSObject))]
	interface FDataSnapshot
	{
		// -(FDataSnapshot *)childSnapshotForPath:(NSString *)childPathString;
		[Export ("childSnapshotForPath:")]
		FDataSnapshot ChildSnapshotForPath (string childPathString);

		// -(BOOL)hasChild:(NSString *)childPathString;
		[Export ("hasChild:")]
		bool HasChild (string childPathString);

		// -(BOOL)hasChildren;
		[Export ("hasChildren")]

		bool HasChildren { get; }

		// -(BOOL)exists;
		[Export ("exists")]
		bool Exists { get; }

		// -(id)valueInExportFormat;
		[Export ("valueInExportFormat")]

		NSObject ValueInExportFormat { get; }

		// @property (readonly, nonatomic, strong) id value;
		[Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }

		// @property (readonly, nonatomic) NSUInteger childrenCount;
		[Export ("childrenCount")]
		nuint ChildrenCount { get; }

		// @property (readonly, nonatomic, strong) Firebase * ref;
		[Export ("ref", ArgumentSemantic.Strong)]
		Firebase Ref { get; }

		// @property (readonly, nonatomic, strong) NSString * key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, nonatomic, strong) NSEnumerator * children;
		[Export ("children", ArgumentSemantic.Strong)]
		NSEnumerator Children { get; }

		// @property (readonly, nonatomic, strong) id priority;
		[Export ("priority", ArgumentSemantic.Strong)]
		NSObject Priority { get; }
	}

	// @interface FQuery : NSObject
	[BaseType (typeof(NSObject))]
	interface FQuery
	{
		// -(FirebaseHandle)observeEventType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block;
		[Export ("observeEventType:withBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot> block);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block;
		[Export ("observeEventType:andPreviousSiblingKeyWithBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot, NSString> block);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeEventType:withBlock:withCancelBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot> block, Action<NSError> cancelBlock);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeEventType:andPreviousSiblingKeyWithBlock:withCancelBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot, NSString> block, Action<NSError> cancelBlock);

		// -(void)observeSingleEventOfType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block;
		[Export ("observeSingleEventOfType:withBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot> block);

		// -(void)observeSingleEventOfType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block;
		[Export ("observeSingleEventOfType:andPreviousSiblingKeyWithBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot, NSString> block);

		// -(void)observeSingleEventOfType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeSingleEventOfType:withBlock:withCancelBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot> block, Action<NSError> cancelBlock);

		// -(void)observeSingleEventOfType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeSingleEventOfType:andPreviousSiblingKeyWithBlock:withCancelBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot, NSString> block, Action<NSError> cancelBlock);

		// -(void)removeObserverWithHandle:(FirebaseHandle)handle;
		[Export ("removeObserverWithHandle:")]
		void RemoveObserverWithHandle (nuint handle);

		// -(void)removeAllObservers;
		[Export ("removeAllObservers")]
		void RemoveAllObservers ();

		// -(void)keepSynced:(BOOL)keepSynced;
		[Export ("keepSynced:")]
		void KeepSynced (bool keepSynced);

		// -(FQuery *)queryStartingAtPriority:(id)startPriority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryStartingAtValue:] instead")));
		[Export ("queryStartingAtPriority:")]
		FQuery QueryStartingAtPriority (NSObject startPriority);

		// -(FQuery *)queryStartingAtPriority:(id)startPriority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryStartingAtValue:childKey:] instead")));
		[Export ("queryStartingAtPriority:andChildName:")]
		FQuery QueryStartingAtPriority (NSObject startPriority, string childName);

		// -(FQuery *)queryEndingAtPriority:(id)endPriority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEndingAtValue:] instead")));
		[Export ("queryEndingAtPriority:")]
		FQuery QueryEndingAtPriority (NSObject endPriority);

		// -(FQuery *)queryEndingAtPriority:(id)endPriority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEndingAtValue:childKey:] instead")));
		[Export ("queryEndingAtPriority:andChildName:")]
		FQuery QueryEndingAtPriority (NSObject endPriority, string childName);

		// -(FQuery *)queryEqualToPriority:(id)priority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEqualToValue:] instead")));
		[Export ("queryEqualToPriority:")]
		FQuery QueryEqualToPriority (NSObject priority);

		// -(FQuery *)queryEqualToPriority:(id)priority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEqualToValue:childKey:] instead")));
		[Export ("queryEqualToPriority:andChildName:")]
		FQuery QueryEqualToPriority (NSObject priority, string childName);

		// -(FQuery *)queryLimitedToNumberOfChildren:(NSUInteger)limit __attribute__((deprecated("Use [FQuery queryLimitedToFirst:limit] or [FQuery queryLimitedToLast:limit] instead")));
		[Export ("queryLimitedToNumberOfChildren:")]
		FQuery QueryLimitedToNumberOfChildren (nuint limit);

		// -(FQuery *)queryLimitedToFirst:(NSUInteger)limit;
		[Export ("queryLimitedToFirst:")]
		FQuery QueryLimitedToFirst (nuint limit);

		// -(FQuery *)queryLimitedToLast:(NSUInteger)limit;
		[Export ("queryLimitedToLast:")]
		FQuery QueryLimitedToLast (nuint limit);

		// -(FQuery *)queryOrderedByChild:(NSString *)key;
		[Export ("queryOrderedByChild:")]
		FQuery QueryOrderedByChild (string key);

		// -(FQuery *)queryOrderedByKey;
		[Export ("queryOrderedByKey")]

		FQuery QueryOrderedByKey { get; }

		// -(FQuery *)queryOrderedByValue;
		[Export ("queryOrderedByValue")]

		FQuery QueryOrderedByValue { get; }

		// -(FQuery *)queryOrderedByPriority;
		[Export ("queryOrderedByPriority")]

		FQuery QueryOrderedByPriority { get; }

		// -(FQuery *)queryStartingAtValue:(id)startValue;
		[Export ("queryStartingAtValue:")]
		FQuery QueryStartingAtValue (NSObject startValue);

		// -(FQuery *)queryStartingAtValue:(id)startValue childKey:(NSString *)childKey;
		[Export ("queryStartingAtValue:childKey:")]
		FQuery QueryStartingAtValue (NSObject startValue, string childKey);

		// -(FQuery *)queryEndingAtValue:(id)endValue;
		[Export ("queryEndingAtValue:")]
		FQuery QueryEndingAtValue (NSObject endValue);

		// -(FQuery *)queryEndingAtValue:(id)endValue childKey:(NSString *)childKey;
		[Export ("queryEndingAtValue:childKey:")]
		FQuery QueryEndingAtValue (NSObject endValue, string childKey);

		// -(FQuery *)queryEqualToValue:(id)value;
		[Export ("queryEqualToValue:")]
		FQuery QueryEqualToValue (NSObject value);

		// -(FQuery *)queryEqualToValue:(id)value childKey:(NSString *)childKey;
		[Export ("queryEqualToValue:childKey:")]
		FQuery QueryEqualToValue (NSObject value, string childKey);

		// @property (readonly, nonatomic, strong) Firebase * ref;
		[Export ("ref", ArgumentSemantic.Strong)]
		Firebase Ref { get; }
	}

	// @interface FirebaseApp : NSObject
	[BaseType (typeof(NSObject))]
	interface FirebaseApp
	{
		// -(void)purgeOutstandingWrites;
		[Export ("purgeOutstandingWrites")]
		void PurgeOutstandingWrites ();

		// -(void)goOffline;
		[Export ("goOffline")]
		void GoOffline ();

		// -(void)goOnline;
		[Export ("goOnline")]
		void GoOnline ();
	}

	// @interface FMutableData : NSObject
	[BaseType (typeof(NSObject))]
	interface FMutableData
	{
		// -(BOOL)hasChildren;
		[Export ("hasChildren")]

		bool HasChildren { get; }

		// -(BOOL)hasChildAtPath:(NSString *)path;
		[Export ("hasChildAtPath:")]
		bool HasChildAtPath (string path);

		// -(FMutableData *)childDataByAppendingPath:(NSString *)path;
		[Export ("childDataByAppendingPath:")]
		FMutableData ChildDataByAppendingPath (string path);

		// @property (readonly, nonatomic, strong) FMutableData * parent __attribute__((deprecated("Deprecated. Do not use.")));
		[Export ("parent", ArgumentSemantic.Strong)]
		FMutableData Parent { get; }

		// @property (nonatomic, strong) id value;
		[Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; set; }

		// @property (nonatomic, strong) id priority;
		[Export ("priority", ArgumentSemantic.Strong)]
		NSObject Priority { get; set; }

		// @property (readonly, nonatomic) NSUInteger childrenCount;
		[Export ("childrenCount")]
		nuint ChildrenCount { get; }

		// @property (readonly, nonatomic, strong) NSEnumerator * children;
		[Export ("children", ArgumentSemantic.Strong)]
		NSEnumerator Children { get; }

		// @property (readonly, nonatomic, strong) NSString * key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }
	}

	// @interface FTransactionResult : NSObject
	[BaseType (typeof(NSObject))]
	interface FTransactionResult
	{
		// +(FTransactionResult *)successWithValue:(FMutableData *)value;
		[Static]
		[Export ("successWithValue:")]
		FTransactionResult SuccessWithValue (FMutableData value);

		// +(FTransactionResult *)abort;
		[Static]
		[Export ("abort")]

		FTransactionResult Abort { get; }
	}

	// @interface FAuthData : NSObject
	[BaseType (typeof(NSObject))]
	interface FAuthData
	{
		// @property (readonly, nonatomic, strong) NSDictionary * auth;
		[Export ("auth", ArgumentSemantic.Strong)]
		NSDictionary Auth { get; }

		// @property (readonly, nonatomic, strong) NSNumber * expires;
		[Export ("expires", ArgumentSemantic.Strong)]
		NSNumber Expires { get; }

		// @property (readonly, nonatomic, strong) NSString * uid;
		[Export ("uid", ArgumentSemantic.Strong)]
		string Uid { get; }

		// @property (readonly, nonatomic) NSString * provider;
		[Export ("provider")]
		string Provider { get; }

		// @property (readonly, nonatomic, strong) NSString * token;
		[Export ("token", ArgumentSemantic.Strong)]
		string Token { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * providerData;
		[Export ("providerData", ArgumentSemantic.Strong)]
		NSDictionary ProviderData { get; }
	}

	// @interface FirebaseServerValue : NSObject
	[BaseType (typeof(NSObject))]
	interface FirebaseServerValue
	{
		// +(NSDictionary *)timestamp;
		[Static]
		[Export ("timestamp")]

		NSDictionary Timestamp { get; }
	}

	// @interface FConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FConfig
	{
		// @property (nonatomic) BOOL persistenceEnabled;
		[Export ("persistenceEnabled")]
		bool PersistenceEnabled { get; set; }

		// @property (nonatomic) NSUInteger persistenceCacheSizeBytes;
		[Export ("persistenceCacheSizeBytes")]
		nuint PersistenceCacheSizeBytes { get; set; }

		// @property (nonatomic, strong) dispatch_queue_t callbackQueue;
		[Export ("callbackQueue", ArgumentSemantic.Strong)]
		DispatchQueue CallbackQueue { get; set; }
	}

	// @interface Firebase : FQuery
	[BaseType (typeof(FQuery))]
	interface Firebase
	{
		// -(id)initWithUrl:(NSString *)url;
		[Export ("initWithUrl:")]
		IntPtr Constructor (string url);

		// -(Firebase *)childByAppendingPath:(NSString *)pathString;
		[Export ("childByAppendingPath:")]
		Firebase ChildByAppendingPath (string pathString);

		// -(Firebase *)childByAutoId;
		[Export ("childByAutoId")]

		Firebase ChildByAutoId { get; }

		// -(void)setValue:(id)value;
		[Export ("setValue:")]
		void SetValue (NSObject value);

		// -(void)setValue:(id)value withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("setValue:withCompletionBlock:")]
		void SetValue (NSObject value, Action<NSError, Firebase> block);

		// -(void)setValue:(id)value andPriority:(id)priority;
		[Export ("setValue:andPriority:")]
		void SetValue (NSObject value, NSObject priority);

		// -(void)setValue:(id)value andPriority:(id)priority withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("setValue:andPriority:withCompletionBlock:")]
		void SetValue (NSObject value, NSObject priority, Action<NSError, Firebase> block);

		// -(void)removeValue;
		[Export ("removeValue")]
		void RemoveValue ();

		// -(void)removeValueWithCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("removeValueWithCompletionBlock:")]
		void RemoveValueWithCompletionBlock (Action<NSError, Firebase> block);

		// -(void)setPriority:(id)priority;
		[Export ("setPriority:")]
		void SetPriority (NSObject priority);

		// -(void)setPriority:(id)priority withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("setPriority:withCompletionBlock:")]
		void SetPriority (NSObject priority, Action<NSError, Firebase> block);

		// -(void)updateChildValues:(NSDictionary *)values;
		[Export ("updateChildValues:")]
		void UpdateChildValues (NSDictionary values);

		// -(void)updateChildValues:(NSDictionary *)values withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("updateChildValues:withCompletionBlock:")]
		void UpdateChildValues (NSDictionary values, Action<NSError, Firebase> block);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block;
		[Export ("observeEventType:withBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot> block);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block;
		[Export ("observeEventType:andPreviousSiblingKeyWithBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot, NSString> block);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeEventType:withBlock:withCancelBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot> block, Action<NSError> cancelBlock);

		// -(FirebaseHandle)observeEventType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeEventType:andPreviousSiblingKeyWithBlock:withCancelBlock:")]
		nuint ObserveEventType (FEventType eventType, Action<FDataSnapshot, NSString> block, Action<NSError> cancelBlock);

		// -(void)observeSingleEventOfType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block;
		[Export ("observeSingleEventOfType:withBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot> block);

		// -(void)observeSingleEventOfType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block;
		[Export ("observeSingleEventOfType:andPreviousSiblingKeyWithBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot, NSString> block);

		// -(void)observeSingleEventOfType:(FEventType)eventType withBlock:(void (^)(FDataSnapshot *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeSingleEventOfType:withBlock:withCancelBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot> block, Action<NSError> cancelBlock);

		// -(void)observeSingleEventOfType:(FEventType)eventType andPreviousSiblingKeyWithBlock:(void (^)(FDataSnapshot *, NSString *))block withCancelBlock:(void (^)(NSError *))cancelBlock;
		[Export ("observeSingleEventOfType:andPreviousSiblingKeyWithBlock:withCancelBlock:")]
		void ObserveSingleEventOfType (FEventType eventType, Action<FDataSnapshot, NSString> block, Action<NSError> cancelBlock);

		// -(void)removeObserverWithHandle:(FirebaseHandle)handle;
		[Export ("removeObserverWithHandle:")]
		void RemoveObserverWithHandle (nuint handle);

		// -(void)keepSynced:(BOOL)keepSynced;
		[Export ("keepSynced:")]
		void KeepSynced (bool keepSynced);

		// -(void)removeAllObservers;
		[Export ("removeAllObservers")]
		void RemoveAllObservers ();

		// -(FQuery *)queryStartingAtPriority:(id)startPriority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryStartingAtValue:] instead")));
		[Export ("queryStartingAtPriority:")]
		FQuery QueryStartingAtPriority (NSObject startPriority);

		// -(FQuery *)queryStartingAtPriority:(id)startPriority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryStartingAtValue:childKey:] instead")));
		[Export ("queryStartingAtPriority:andChildName:")]
		FQuery QueryStartingAtPriority (NSObject startPriority, string childName);

		// -(FQuery *)queryEndingAtPriority:(id)endPriority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEndingAtValue:] instead")));
		[Export ("queryEndingAtPriority:")]
		FQuery QueryEndingAtPriority (NSObject endPriority);

		// -(FQuery *)queryEndingAtPriority:(id)endPriority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEndingAtValue:childKey:] instead")));
		[Export ("queryEndingAtPriority:andChildName:")]
		FQuery QueryEndingAtPriority (NSObject endPriority, string childName);

		// -(FQuery *)queryEqualToPriority:(id)priority __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEqualToValue:] instead")));
		[Export ("queryEqualToPriority:")]
		FQuery QueryEqualToPriority (NSObject priority);

		// -(FQuery *)queryEqualToPriority:(id)priority andChildName:(NSString *)childName __attribute__((deprecated("Use [[FQuery queryOrderedByPriority] queryEqualToValue:childKey:] instead")));
		[Export ("queryEqualToPriority:andChildName:")]
		FQuery QueryEqualToPriority (NSObject priority, string childName);

		// -(FQuery *)queryLimitedToNumberOfChildren:(NSUInteger)limit __attribute__((deprecated("Use [FQuery queryLimitedToFirst:limit] or [FQuery queryLimitedToLast:limit] instead")));
		[Export ("queryLimitedToNumberOfChildren:")]
		FQuery QueryLimitedToNumberOfChildren (nuint limit);

		// -(FQuery *)queryLimitedToFirst:(NSUInteger)limit;
		[Export ("queryLimitedToFirst:")]
		FQuery QueryLimitedToFirst (nuint limit);

		// -(FQuery *)queryLimitedToLast:(NSUInteger)limit;
		[Export ("queryLimitedToLast:")]
		FQuery QueryLimitedToLast (nuint limit);

		// -(FQuery *)queryOrderedByChild:(NSString *)key;
		[Export ("queryOrderedByChild:")]
		FQuery QueryOrderedByChild (string key);

		// -(FQuery *)queryOrderedByKey;
		[Export ("queryOrderedByKey")]

		FQuery QueryOrderedByKey { get; }

		// -(FQuery *)queryOrderedByPriority;
		[Export ("queryOrderedByPriority")]

		FQuery QueryOrderedByPriority { get; }

		// -(FQuery *)queryStartingAtValue:(id)startValue;
		[Export ("queryStartingAtValue:")]
		FQuery QueryStartingAtValue (NSObject startValue);

		// -(FQuery *)queryStartingAtValue:(id)startValue childKey:(NSString *)childKey;
		[Export ("queryStartingAtValue:childKey:")]
		FQuery QueryStartingAtValue (NSObject startValue, string childKey);

		// -(FQuery *)queryEndingAtValue:(id)endValue;
		[Export ("queryEndingAtValue:")]
		FQuery QueryEndingAtValue (NSObject endValue);

		// -(FQuery *)queryEndingAtValue:(id)endValue childKey:(NSString *)childKey;
		[Export ("queryEndingAtValue:childKey:")]
		FQuery QueryEndingAtValue (NSObject endValue, string childKey);

		// -(FQuery *)queryEqualToValue:(id)value;
		[Export ("queryEqualToValue:")]
		FQuery QueryEqualToValue (NSObject value);

		// -(FQuery *)queryEqualToValue:(id)value childKey:(NSString *)childKey;
		[Export ("queryEqualToValue:childKey:")]
		FQuery QueryEqualToValue (NSObject value, string childKey);

		// -(void)onDisconnectSetValue:(id)value;
		[Export ("onDisconnectSetValue:")]
		void OnDisconnectSetValue (NSObject value);

		// -(void)onDisconnectSetValue:(id)value withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("onDisconnectSetValue:withCompletionBlock:")]
		void OnDisconnectSetValue (NSObject value, Action<NSError, Firebase> block);

		// -(void)onDisconnectSetValue:(id)value andPriority:(id)priority;
		[Export ("onDisconnectSetValue:andPriority:")]
		void OnDisconnectSetValue (NSObject value, NSObject priority);

		// -(void)onDisconnectSetValue:(id)value andPriority:(id)priority withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("onDisconnectSetValue:andPriority:withCompletionBlock:")]
		void OnDisconnectSetValue (NSObject value, NSObject priority, Action<NSError, Firebase> block);

		// -(void)onDisconnectRemoveValue;
		[Export ("onDisconnectRemoveValue")]
		void OnDisconnectRemoveValue ();

		// -(void)onDisconnectRemoveValueWithCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("onDisconnectRemoveValueWithCompletionBlock:")]
		void OnDisconnectRemoveValueWithCompletionBlock (Action<NSError, Firebase> block);

		// -(void)onDisconnectUpdateChildValues:(NSDictionary *)values;
		[Export ("onDisconnectUpdateChildValues:")]
		void OnDisconnectUpdateChildValues (NSDictionary values);

		// -(void)onDisconnectUpdateChildValues:(NSDictionary *)values withCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("onDisconnectUpdateChildValues:withCompletionBlock:")]
		void OnDisconnectUpdateChildValues (NSDictionary values, Action<NSError, Firebase> block);

		// -(void)cancelDisconnectOperations;
		[Export ("cancelDisconnectOperations")]
		void CancelDisconnectOperations ();

		// -(void)cancelDisconnectOperationsWithCompletionBlock:(void (^)(NSError *, Firebase *))block;
		[Export ("cancelDisconnectOperationsWithCompletionBlock:")]
		void CancelDisconnectOperationsWithCompletionBlock (Action<NSError, Firebase> block);

		// @property (readonly, nonatomic, strong) FAuthData * authData;
		[Export ("authData", ArgumentSemantic.Strong)]
		FAuthData AuthData { get; }

		// -(FirebaseHandle)observeAuthEventWithBlock:(void (^)(FAuthData *))block;
		[Export ("observeAuthEventWithBlock:")]
		nuint ObserveAuthEventWithBlock (Action<FAuthData> block);

		// -(void)removeAuthEventObserverWithHandle:(FirebaseHandle)handle;
		[Export ("removeAuthEventObserverWithHandle:")]
		void RemoveAuthEventObserverWithHandle (nuint handle);

		// -(void)createUser:(NSString *)email password:(NSString *)password withCompletionBlock:(void (^)(NSError *))block;
		[Export ("createUser:password:withCompletionBlock:")]
		void CreateUser (string email, string password, Action<NSError> block);

		// -(void)createUser:(NSString *)email password:(NSString *)password withValueCompletionBlock:(void (^)(NSError *, NSDictionary *))block;
		[Export ("createUser:password:withValueCompletionBlock:")]
		void CreateUser (string email, string password, Action<NSError, NSDictionary> block);

		// -(void)removeUser:(NSString *)email password:(NSString *)password withCompletionBlock:(void (^)(NSError *))block;
		[Export ("removeUser:password:withCompletionBlock:")]
		void RemoveUser (string email, string password, Action<NSError> block);

		// -(void)changePasswordForUser:(NSString *)email fromOld:(NSString *)oldPassword toNew:(NSString *)newPassword withCompletionBlock:(void (^)(NSError *))block;
		[Export ("changePasswordForUser:fromOld:toNew:withCompletionBlock:")]
		void ChangePasswordForUser (string email, string oldPassword, string newPassword, Action<NSError> block);

		// -(void)changeEmailForUser:(NSString *)email password:(NSString *)password toNewEmail:(NSString *)newEmail withCompletionBlock:(void (^)(NSError *))block;
		[Export ("changeEmailForUser:password:toNewEmail:withCompletionBlock:")]
		void ChangeEmailForUser (string email, string password, string newEmail, Action<NSError> block);

		// -(void)resetPasswordForUser:(NSString *)email withCompletionBlock:(void (^)(NSError *))block;
		[Export ("resetPasswordForUser:withCompletionBlock:")]
		void ResetPasswordForUser (string email, Action<NSError> block);

		// -(void)authAnonymouslyWithCompletionBlock:(void (^)(NSError *, FAuthData *))block;
		[Export ("authAnonymouslyWithCompletionBlock:")]
		void AuthAnonymouslyWithCompletionBlock (Action<NSError, FAuthData> block);

		// -(void)authUser:(NSString *)email password:(NSString *)password withCompletionBlock:(void (^)(NSError *, FAuthData *))block;
		[Export ("authUser:password:withCompletionBlock:")]
		void AuthUser (string email, string password, Action<NSError, FAuthData> block);

		// -(void)authWithCustomToken:(NSString *)token withCompletionBlock:(void (^)(NSError *, FAuthData *))block;
		[Export ("authWithCustomToken:withCompletionBlock:")]
		void AuthWithCustomToken (string token, Action<NSError, FAuthData> block);

		// -(void)authWithOAuthProvider:(NSString *)provider token:(NSString *)oauthToken withCompletionBlock:(void (^)(NSError *, FAuthData *))block;
		[Export ("authWithOAuthProvider:token:withCompletionBlock:")]
		void AuthWithOAuthProvider (string provider, string oauthToken, Action<NSError, FAuthData> block);

		// -(void)authWithOAuthProvider:(NSString *)provider parameters:(NSDictionary *)parameters withCompletionBlock:(void (^)(NSError *, FAuthData *))block;
		[Export ("authWithOAuthProvider:parameters:withCompletionBlock:")]
		void AuthWithOAuthProvider (string provider, NSDictionary parameters, Action<NSError, FAuthData> block);

		// -(void)makeReverseOAuthRequestTo:(NSString *)provider withCompletionBlock:(void (^)(NSError *, NSDictionary *))block;
		[Export ("makeReverseOAuthRequestTo:withCompletionBlock:")]
		void MakeReverseOAuthRequestTo (string provider, Action<NSError, NSDictionary> block);

		// -(void)unauth;
		[Export ("unauth")]
		void Unauth ();

		// -(void)authWithCredential:(NSString *)credential withCompletionBlock:(void (^)(NSError *, id))block withCancelBlock:(void (^)(NSError *))cancelBlock __attribute__((deprecated("Use authWithCustomToken:withCompletionblock: instead")));
		[Export ("authWithCredential:withCompletionBlock:withCancelBlock:")]
		void AuthWithCredential (string credential, Action<NSError, NSObject> block, Action<NSError> cancelBlock);

		// -(void)unauthWithCompletionBlock:(void (^)(NSError *))block __attribute__((deprecated("Use unauth: instead")));
		[Export ("unauthWithCompletionBlock:")]
		void UnauthWithCompletionBlock (Action<NSError> block);

		// +(void)goOffline;
		[Static]
		[Export ("goOffline")]
		void GoOffline ();

		// +(void)goOnline;
		[Static]
		[Export ("goOnline")]
		void GoOnline ();

		// -(void)runTransactionBlock:(FTransactionResult *(^)(FMutableData *))block;
		[Export ("runTransactionBlock:")]
		void RunTransactionBlock (Func<FMutableData, FTransactionResult> block);

		// -(void)runTransactionBlock:(FTransactionResult *(^)(FMutableData *))block andCompletionBlock:(void (^)(NSError *, BOOL, FDataSnapshot *))completionBlock;
		[Export ("runTransactionBlock:andCompletionBlock:")]
		void RunTransactionBlock (Func<FMutableData, FTransactionResult> block, Action<NSError, bool, FDataSnapshot> completionBlock);

		// -(void)runTransactionBlock:(FTransactionResult *(^)(FMutableData *))block andCompletionBlock:(void (^)(NSError *, BOOL, FDataSnapshot *))completionBlock withLocalEvents:(BOOL)localEvents;
		[Export ("runTransactionBlock:andCompletionBlock:withLocalEvents:")]
		void RunTransactionBlock (Func<FMutableData, FTransactionResult> block, Action<NSError, bool, FDataSnapshot> completionBlock, bool localEvents);

		// -(NSString *)description;
		[Export ("description")]

		string Description { get; }

		// @property (readonly, nonatomic, strong) Firebase * parent;
		[Export ("parent", ArgumentSemantic.Strong)]
		Firebase Parent { get; }

		// @property (readonly, nonatomic, strong) Firebase * root;
		[Export ("root", ArgumentSemantic.Strong)]
		Firebase Root { get; }

		// @property (readonly, nonatomic, strong) NSString * key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, nonatomic, strong) FirebaseApp * app;
		[Export ("app", ArgumentSemantic.Strong)]
		FirebaseApp App { get; }

		// +(void)setDispatchQueue:(dispatch_queue_t)queue __attribute__((deprecated("")));
		[Static]
		[Export ("setDispatchQueue:")]
		void SetDispatchQueue (DispatchQueue queue);

		// +(NSString *)sdkVersion;
		[Static]
		[Export ("sdkVersion")]

		string SdkVersion { get; }

		// +(void)setLoggingEnabled:(BOOL)enabled;
		[Static]
		[Export ("setLoggingEnabled:")]
		void SetLoggingEnabled (bool enabled);

		// +(FConfig *)defaultConfig;
		[Static]
		[Export ("defaultConfig")]

		FConfig DefaultConfig { get; }

		// +(void)setOption:(NSString *)option to:(id)value __attribute__((deprecated("")));
		[Static]
		[Export ("setOption:to:")]
		void SetOption (string option, NSObject value);
	}
}
