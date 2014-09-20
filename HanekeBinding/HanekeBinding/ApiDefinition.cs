using System.Drawing;
using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HanekeBinding {
	public delegate void Callbackblock(bool success);

	[Category, BaseType (typeof (UIButton))]
	public partial interface Haneke_UIButton {

		[Export ("hnk_setImageFromURL:forState:")]
		void Hnk_setImageFromURL (NSUrl URL, UIControlState state);

		[Export ("hnk_setImageFromURL:forState:placeholder:")]
		void Hnk_setImageFromURL (NSUrl URL, UIControlState state, UIImage placeholder);

		[Export ("hnk_setImageFromURL:forState:placeholder:success:failure:")]
		void Hnk_setImageFromURL (NSUrl URL, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setImageFromFile:forState:")]
		void Hnk_setImageFromFile (string path, UIControlState state);

		[Export ("hnk_setImageFromFile:forState:placeholder:")]
		void Hnk_setImageFromFile (string path, UIControlState state, UIImage placeholder);

		[Export ("hnk_setImageFromFile:forState:placeholder:success:failure:")]
		void Hnk_setImageFromFile (string path, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setImage:withKey:forState:")]
		void Hnk_setImage (UIImage image, string key, UIControlState state);

		[Export ("hnk_setImage:withKey:forState:placeholder:")]
		void Hnk_setImage (UIImage image, string key, UIControlState state, UIImage placeholder);

		[Export ("hnk_setImage:withKey:forState:placeholder:success:failure:")]
		void Hnk_setImage (UIImage image, string key, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

//		[Export ("hnk_setImageFromFetcher:forState:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher, UIControlState state);
//
//		[Export ("hnk_setImageFromFetcher:forState:placeholder:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher, UIControlState state, UIImage placeholder);
//
//		[Export ("hnk_setImageFromFetcher:forState:placeholder:success:failure:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_cancelSetImage")]
		void Hnk_cancelSetImage ();

//		[Export ("hnk_imageFormat", ArgumentSemantic.Retain)]
//		HNKCacheFormat Hnk_imageFormat { get; set; }

		[Export ("hnk_setBackgroundImageFromURL:forState:")]
		void Hnk_setBackgroundImageFromURL (NSUrl URL, UIControlState state);

		[Export ("hnk_setBackgroundImageFromURL:forState:placeholder:")]
		void Hnk_setBackgroundImageFromURL (NSUrl URL, UIControlState state, UIImage placeholder);

		[Export ("hnk_setBackgroundImageFromURL:forState:placeholder:success:failure:")]
		void Hnk_setBackgroundImageFromURL (NSUrl URL, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setBackgroundImageFromFile:forState:")]
		void Hnk_setBackgroundImageFromFile (string path, UIControlState state);

		[Export ("hnk_setBackgroundImageFromFile:forState:placeholder:")]
		void Hnk_setBackgroundImageFromFile (string path, UIControlState state, UIImage placeholder);

		[Export ("hnk_setBackgroundImageFromFile:forState:placeholder:success:failure:")]
		void Hnk_setBackgroundImageFromFile (string path, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setBackgroundImage:withKey:forState:")]
		void Hnk_setBackgroundImage (UIImage image, string key, UIControlState state);

		[Export ("hnk_setBackgroundImage:withKey:forState:placeholder:")]
		void Hnk_setBackgroundImage (UIImage image, string key, UIControlState state, UIImage placeholder);

		[Export ("hnk_setBackgroundImage:withKey:forState:placeholder:success:failure:")]
		void Hnk_setBackgroundImage (UIImage image, string key, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

//		[Export ("hnk_setBackgroundImageFromFetcher:forState:")]
//		void Hnk_setBackgroundImageFromFetcher (HNKFetcher fetcher, UIControlState state);
//
//		[Export ("hnk_setBackgroundImageFromFetcher:forState:placeholder:")]
//		void Hnk_setBackgroundImageFromFetcher (HNKFetcher fetcher, UIControlState state, UIImage placeholder);
//
//		[Export ("hnk_setBackgroundImageFromFetcher:forState:placeholder:success:failure:")]
//		void Hnk_setBackgroundImageFromFetcher (HNKFetcher fetcher, UIControlState state, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_cancelSetBackgroundImage")]
		void Hnk_cancelSetBackgroundImage ();

//		[Export ("hnk_backgroundImageFormat", ArgumentSemantic.Retain)]
//		HNKCacheFormat Hnk_backgroundImageFormat { get; set; }
	}
		


	[Category, BaseType (typeof (UIImageView))]
	public partial interface Haneke_UIImageView {

		[Export ("hnk_setImageFromFile:")]
		void Hnk_setImageFromFile (string path);

		[Export ("hnk_setImageFromFile:placeholder:")]
		void Hnk_setImageFromFile (string path, UIImage placeholder);

		[Export ("hnk_setImageFromFile:placeholder:success:failure:")]
		void Hnk_setImageFromFile (string path, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setImageFromURL:")]
		void Hnk_setImageFromURL (NSUrl url);

		[Export ("hnk_setImageFromURL:placeholder:")]
		void Hnk_setImageFromURL (NSUrl url, UIImage placeholder);

		[Export ("hnk_setImageFromURL:placeholder:success:failure:")]
		void Hnk_setImageFromURL (NSUrl url, [NullAllowed] UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_setImage:withKey:")]
		void Hnk_setImage (UIImage image, string key);

		[Export ("hnk_setImage:withKey:placeholder:")]
		void Hnk_setImage (UIImage image, string key, UIImage placeholder);

		[Export ("hnk_setImage:withKey:placeholder:success:failure:")]
		void Hnk_setImage (UIImage image, string key, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

//		[Export ("hnk_setImageFromFetcher:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher);
//
//		[Export ("hnk_setImageFromFetcher:placeholder:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher, UIImage placeholder);
//
//		[Export ("hnk_setImageFromFetcher:placeholder:success:failure:")]
//		void Hnk_setImageFromFetcher (HNKFetcher fetcher, UIImage placeholder, Callbackblock successBlock, Callbackblock failureBlock);

		[Export ("hnk_cancelSetImage")]
		void Hnk_cancelSetImage ();

//		[Export ("hnk_cacheFormat", ArgumentSemantic.Retain)]
//		HNKCacheFormat Hnk_cacheFormat { get; set; }
	}

//	[Category, BaseType (typeof (UIView))]
//	public partial interface Haneke_UIView {
//
//		[Export ("hnk_scaleMode")]
//		HNKScaleMode Hnk_scaleMode { get; }
//
////		[Static, Export ("registerSharedFormat:")]
////		void RegisterSharedFormat (HNKCacheFormat format);
////
////		[Static, Export ("sharedFormatWithSize:scaleMode:")]
////		HNKCacheFormat SharedFormatWithSize (SizeF size, HNKScaleMode scaleMode);
//	}
}
