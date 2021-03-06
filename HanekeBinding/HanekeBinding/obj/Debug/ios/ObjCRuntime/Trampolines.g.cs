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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DCallbackblock (IntPtr block, bool success);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCallbackblock {
			static internal readonly DCallbackblock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCallbackblock))]
			static unsafe void Invoke (IntPtr block, bool success) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::HanekeBinding.Callbackblock) (descriptor->Target);
				if (del != null)
					del (success);
			}
		} /* class SDCallbackblock */
		
		internal class NIDCallbackblock {
			IntPtr blockPtr;
			DCallbackblock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDCallbackblock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DCallbackblock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDCallbackblock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::HanekeBinding.Callbackblock Create (IntPtr block)
			{
				return new NIDCallbackblock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool success)
			{
				invoker (blockPtr, success);
			}
		} /* class NIDCallbackblock */
	}
}
