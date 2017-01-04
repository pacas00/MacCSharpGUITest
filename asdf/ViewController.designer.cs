// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace asdf
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton Button1 { get; set; }

		[Outlet]
		AppKit.NSButton ButtonInline1 { get; set; }

		[Outlet]
		AppKit.NSButton Checkbox1 { get; set; }

		[Outlet]
		AppKit.NSComboBox ComboBox1 { get; set; }

		[Outlet]
		AppKit.NSSlider dial1 { get; set; }

		[Outlet]
		AppKit.NSPopUpButton Dropdown1 { get; set; }

		[Outlet]
		AppKit.NSSlider HSlider1 { get; set; }

		[Outlet]
		AppKit.NSTextField Label1 { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator Progressbar1 { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator ProgressSpinner1 { get; set; }

		[Outlet]
		AppKit.NSSearchField SearchField { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator Spinner1 { get; set; }

		[Outlet]
		AppKit.NSTextField Textbox1 { get; set; }

		[Outlet]
		AppKit.NSSlider VSlider1 { get; set; }

		[Action ("Button1_Action:")]
		partial void Button1_Action (Foundation.NSObject sender);

		[Action ("Checkbox_Action:")]
		partial void Checkbox_Action (Foundation.NSObject sender);

		[Action ("dial_Action:")]
		partial void dial_Action (Foundation.NSObject sender);

		[Action ("dropdown_Action:")]
		partial void dropdown_Action (Foundation.NSObject sender);

		[Action ("HSlider1_Action:")]
		partial void HSlider1_Action (Foundation.NSObject sender);

		[Action ("search_Action:")]
		partial void search_Action (Foundation.NSObject sender);

		[Action ("textbox_Action:")]
		partial void textbox_Action (Foundation.NSObject sender);

		[Action ("VSlider1_Action:")]
		partial void VSlider1_Action (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Button1 != null) {
				Button1.Dispose ();
				Button1 = null;
			}

			if (Label1 != null) {
				Label1.Dispose ();
				Label1 = null;
			}

			if (HSlider1 != null) {
				HSlider1.Dispose ();
				HSlider1 = null;
			}

			if (VSlider1 != null) {
				VSlider1.Dispose ();
				VSlider1 = null;
			}

			if (Spinner1 != null) {
				Spinner1.Dispose ();
				Spinner1 = null;
			}

			if (ComboBox1 != null) {
				ComboBox1.Dispose ();
				ComboBox1 = null;
			}

			if (Checkbox1 != null) {
				Checkbox1.Dispose ();
				Checkbox1 = null;
			}

			if (ButtonInline1 != null) {
				ButtonInline1.Dispose ();
				ButtonInline1 = null;
			}

			if (ProgressSpinner1 != null) {
				ProgressSpinner1.Dispose ();
				ProgressSpinner1 = null;
			}

			if (Textbox1 != null) {
				Textbox1.Dispose ();
				Textbox1 = null;
			}

			if (Dropdown1 != null) {
				Dropdown1.Dispose ();
				Dropdown1 = null;
			}

			if (Progressbar1 != null) {
				Progressbar1.Dispose ();
				Progressbar1 = null;
			}

			if (dial1 != null) {
				dial1.Dispose ();
				dial1 = null;
			}

			if (SearchField != null) {
				SearchField.Dispose ();
				SearchField = null;
			}
		}
	}
}
