using System;
using ObjCRuntime;

namespace Xamarin.Firebase
{
	[Native]
	public enum FEventType : long
	{
		ChildAdded,
		ChildRemoved,
		ChildChanged,
		ChildMoved,
		Value
	}

	[Native]
	public enum FAuthenticationError : int
	{
		ProviderDisabled = -1,
		InvalidConfiguration = -2,
		InvalidOrigin = -3,
		InvalidProvider = -4,
		InvalidEmail = -5,
		InvalidPassword = -6,
		InvalidToken = -7,
		UserDoesNotExist = -8,
		EmailTaken = -9,
		DeniedByUser = -10,
		InvalidCredentials = -11,
		InvalidArguments = -12,
		ProviderError = -13,
		LimitsExceeded = -14,
		NetworkError = -15,
		Preempted = -16,
		Unknown = -9999
	}
}


