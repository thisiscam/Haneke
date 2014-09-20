//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace HanekeBinding {
	public unsafe static partial class Haneke_UIImageView  {
		[CompilerGenerated]
		const string selHnk_cancelSetImage = "hnk_cancelSetImage";
		static readonly IntPtr selHnk_cancelSetImageHandle = Selector.GetHandle ("hnk_cancelSetImage");
		[CompilerGenerated]
		const string selHnk_setImageWithKey_ = "hnk_setImage:withKey:";
		static readonly IntPtr selHnk_setImageWithKey_Handle = Selector.GetHandle ("hnk_setImage:withKey:");
		[CompilerGenerated]
		const string selHnk_setImageWithKeyPlaceholder_ = "hnk_setImage:withKey:placeholder:";
		static readonly IntPtr selHnk_setImageWithKeyPlaceholder_Handle = Selector.GetHandle ("hnk_setImage:withKey:placeholder:");
		[CompilerGenerated]
		const string selHnk_setImageWithKeyPlaceholderSuccessFailure_ = "hnk_setImage:withKey:placeholder:success:failure:";
		static readonly IntPtr selHnk_setImageWithKeyPlaceholderSuccessFailure_Handle = Selector.GetHandle ("hnk_setImage:withKey:placeholder:success:failure:");
		[CompilerGenerated]
		const string selHnk_setImageFromFile_ = "hnk_setImageFromFile:";
		static readonly IntPtr selHnk_setImageFromFile_Handle = Selector.GetHandle ("hnk_setImageFromFile:");
		[CompilerGenerated]
		const string selHnk_setImageFromFilePlaceholder_ = "hnk_setImageFromFile:placeholder:";
		static readonly IntPtr selHnk_setImageFromFilePlaceholder_Handle = Selector.GetHandle ("hnk_setImageFromFile:placeholder:");
		[CompilerGenerated]
		const string selHnk_setImageFromFilePlaceholderSuccessFailure_ = "hnk_setImageFromFile:placeholder:success:failure:";
		static readonly IntPtr selHnk_setImageFromFilePlaceholderSuccessFailure_Handle = Selector.GetHandle ("hnk_setImageFromFile:placeholder:success:failure:");
		[CompilerGenerated]
		const string selHnk_setImageFromURL_ = "hnk_setImageFromURL:";
		static readonly IntPtr selHnk_setImageFromURL_Handle = Selector.GetHandle ("hnk_setImageFromURL:");
		[CompilerGenerated]
		const string selHnk_setImageFromURLPlaceholder_ = "hnk_setImageFromURL:placeholder:";
		static readonly IntPtr selHnk_setImageFromURLPlaceholder_Handle = Selector.GetHandle ("hnk_setImageFromURL:placeholder:");
		[CompilerGenerated]
		const string selHnk_setImageFromURLPlaceholderSuccessFailure_ = "hnk_setImageFromURL:placeholder:success:failure:";
		static readonly IntPtr selHnk_setImageFromURLPlaceholderSuccessFailure_Handle = Selector.GetHandle ("hnk_setImageFromURL:placeholder:success:failure:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::MonoTouch.UIKit.UIImageView");
		
		[Export ("hnk_cancelSetImage")]
		[CompilerGenerated]
		public static void Hnk_cancelSetImage (this global::MonoTouch.UIKit.UIImageView This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, selHnk_cancelSetImageHandle);
		}
		
		[Export ("hnk_setImage:withKey:")]
		[CompilerGenerated]
		public static void Hnk_setImage (this global::MonoTouch.UIKit.UIImageView This, global::MonoTouch.UIKit.UIImage image, string key)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, selHnk_setImageWithKey_Handle, image.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("hnk_setImage:withKey:placeholder:")]
		[CompilerGenerated]
		public static void Hnk_setImage (this global::MonoTouch.UIKit.UIImageView This, global::MonoTouch.UIKit.UIImage image, string key, global::MonoTouch.UIKit.UIImage placeholder)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			var nskey = NSString.CreateNative (key);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, selHnk_setImageWithKeyPlaceholder_Handle, image.Handle, nskey, placeholder.Handle);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("hnk_setImage:withKey:placeholder:success:failure:")]
		[CompilerGenerated]
		public unsafe static void Hnk_setImage (this global::MonoTouch.UIKit.UIImageView This, global::MonoTouch.UIKit.UIImage image, string key, global::MonoTouch.UIKit.UIImage placeholder, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock failureBlock)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, failureBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, selHnk_setImageWithKeyPlaceholderSuccessFailure_Handle, image.Handle, nskey, placeholder.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			NSString.ReleaseNative (nskey);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("hnk_setImageFromFile:")]
		[CompilerGenerated]
		public static void Hnk_setImageFromFile (this global::MonoTouch.UIKit.UIImageView This, string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, selHnk_setImageFromFile_Handle, nspath);
			NSString.ReleaseNative (nspath);
			
		}
		
		[Export ("hnk_setImageFromFile:placeholder:")]
		[CompilerGenerated]
		public static void Hnk_setImageFromFile (this global::MonoTouch.UIKit.UIImageView This, string path, global::MonoTouch.UIKit.UIImage placeholder)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			var nspath = NSString.CreateNative (path);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, selHnk_setImageFromFilePlaceholder_Handle, nspath, placeholder.Handle);
			NSString.ReleaseNative (nspath);
			
		}
		
		[Export ("hnk_setImageFromFile:placeholder:success:failure:")]
		[CompilerGenerated]
		public unsafe static void Hnk_setImageFromFile (this global::MonoTouch.UIKit.UIImageView This, string path, global::MonoTouch.UIKit.UIImage placeholder, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock failureBlock)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, failureBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, selHnk_setImageFromFilePlaceholderSuccessFailure_Handle, nspath, placeholder.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			NSString.ReleaseNative (nspath);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
		[Export ("hnk_setImageFromURL:")]
		[CompilerGenerated]
		public static void Hnk_setImageFromURL (this global::MonoTouch.UIKit.UIImageView This, NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, selHnk_setImageFromURL_Handle, url.Handle);
		}
		
		[Export ("hnk_setImageFromURL:placeholder:")]
		[CompilerGenerated]
		public static void Hnk_setImageFromURL (this global::MonoTouch.UIKit.UIImageView This, NSUrl url, global::MonoTouch.UIKit.UIImage placeholder)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (placeholder == null)
				throw new ArgumentNullException ("placeholder");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, selHnk_setImageFromURLPlaceholder_Handle, url.Handle, placeholder.Handle);
		}
		
		[Export ("hnk_setImageFromURL:placeholder:success:failure:")]
		[CompilerGenerated]
		public unsafe static void Hnk_setImageFromURL (this global::MonoTouch.UIKit.UIImageView This, NSUrl url, global::MonoTouch.UIKit.UIImage placeholder, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock successBlock, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDCallbackblock))]Callbackblock failureBlock)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			if (failureBlock == null)
				throw new ArgumentNullException ("failureBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, successBlock);
			BlockLiteral *block_ptr_failureBlock;
			BlockLiteral block_failureBlock;
			block_failureBlock = new BlockLiteral ();
			block_ptr_failureBlock = &block_failureBlock;
			block_failureBlock.SetupBlock (Trampolines.SDCallbackblock.Handler, failureBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, selHnk_setImageFromURLPlaceholderSuccessFailure_Handle, url.Handle, placeholder == null ? IntPtr.Zero : placeholder.Handle, (IntPtr) block_ptr_successBlock, (IntPtr) block_ptr_failureBlock);
			block_ptr_successBlock->CleanupBlock ();
			block_ptr_failureBlock->CleanupBlock ();
			
		}
		
	} /* class Haneke_UIImageView */
}
