using System;

namespace Steamworks2
{
	// Token: 0x0200004B RID: 75
	public enum EHTTPStatusCode
	{
		// Token: 0x040002F1 RID: 753
		k_EHTTPStatusCodeInvalid,
		// Token: 0x040002F2 RID: 754
		k_EHTTPStatusCode100Continue = 100,
		// Token: 0x040002F3 RID: 755
		k_EHTTPStatusCode101SwitchingProtocols,
		// Token: 0x040002F4 RID: 756
		k_EHTTPStatusCode200OK = 200,
		// Token: 0x040002F5 RID: 757
		k_EHTTPStatusCode201Created,
		// Token: 0x040002F6 RID: 758
		k_EHTTPStatusCode202Accepted,
		// Token: 0x040002F7 RID: 759
		k_EHTTPStatusCode203NonAuthoritative,
		// Token: 0x040002F8 RID: 760
		k_EHTTPStatusCode204NoContent,
		// Token: 0x040002F9 RID: 761
		k_EHTTPStatusCode205ResetContent,
		// Token: 0x040002FA RID: 762
		k_EHTTPStatusCode206PartialContent,
		// Token: 0x040002FB RID: 763
		k_EHTTPStatusCode300MultipleChoices = 300,
		// Token: 0x040002FC RID: 764
		k_EHTTPStatusCode301MovedPermanently,
		// Token: 0x040002FD RID: 765
		k_EHTTPStatusCode302Found,
		// Token: 0x040002FE RID: 766
		k_EHTTPStatusCode303SeeOther,
		// Token: 0x040002FF RID: 767
		k_EHTTPStatusCode304NotModified,
		// Token: 0x04000300 RID: 768
		k_EHTTPStatusCode305UseProxy,
		// Token: 0x04000301 RID: 769
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		// Token: 0x04000302 RID: 770
		k_EHTTPStatusCode400BadRequest = 400,
		// Token: 0x04000303 RID: 771
		k_EHTTPStatusCode401Unauthorized,
		// Token: 0x04000304 RID: 772
		k_EHTTPStatusCode402PaymentRequired,
		// Token: 0x04000305 RID: 773
		k_EHTTPStatusCode403Forbidden,
		// Token: 0x04000306 RID: 774
		k_EHTTPStatusCode404NotFound,
		// Token: 0x04000307 RID: 775
		k_EHTTPStatusCode405MethodNotAllowed,
		// Token: 0x04000308 RID: 776
		k_EHTTPStatusCode406NotAcceptable,
		// Token: 0x04000309 RID: 777
		k_EHTTPStatusCode407ProxyAuthRequired,
		// Token: 0x0400030A RID: 778
		k_EHTTPStatusCode408RequestTimeout,
		// Token: 0x0400030B RID: 779
		k_EHTTPStatusCode409Conflict,
		// Token: 0x0400030C RID: 780
		k_EHTTPStatusCode410Gone,
		// Token: 0x0400030D RID: 781
		k_EHTTPStatusCode411LengthRequired,
		// Token: 0x0400030E RID: 782
		k_EHTTPStatusCode412PreconditionFailed,
		// Token: 0x0400030F RID: 783
		k_EHTTPStatusCode413RequestEntityTooLarge,
		// Token: 0x04000310 RID: 784
		k_EHTTPStatusCode414RequestURITooLong,
		// Token: 0x04000311 RID: 785
		k_EHTTPStatusCode415UnsupportedMediaType,
		// Token: 0x04000312 RID: 786
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable,
		// Token: 0x04000313 RID: 787
		k_EHTTPStatusCode417ExpectationFailed,
		// Token: 0x04000314 RID: 788
		k_EHTTPStatusCode4xxUnknown,
		// Token: 0x04000315 RID: 789
		k_EHTTPStatusCode429TooManyRequests = 429,
		// Token: 0x04000316 RID: 790
		k_EHTTPStatusCode500InternalServerError = 500,
		// Token: 0x04000317 RID: 791
		k_EHTTPStatusCode501NotImplemented,
		// Token: 0x04000318 RID: 792
		k_EHTTPStatusCode502BadGateway,
		// Token: 0x04000319 RID: 793
		k_EHTTPStatusCode503ServiceUnavailable,
		// Token: 0x0400031A RID: 794
		k_EHTTPStatusCode504GatewayTimeout,
		// Token: 0x0400031B RID: 795
		k_EHTTPStatusCode505HTTPVersionNotSupported,
		// Token: 0x0400031C RID: 796
		k_EHTTPStatusCode5xxUnknown = 599
	}
}
