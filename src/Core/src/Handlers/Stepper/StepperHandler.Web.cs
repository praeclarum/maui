﻿using System;

namespace Microsoft.Maui.Handlers
{
	public partial class StepperHandler : ViewHandler<IStepper, Ooui.Element>
	{
		protected override Ooui.Element CreatePlatformView() => throw new NotImplementedException();

		public static void MapMinimum(IViewHandler handler, IStepper stepper) { }
		public static void MapMaximum(IViewHandler handler, IStepper stepper) { }
		public static void MapIncrement(IViewHandler handler, IStepper stepper) { }
		public static void MapValue(IViewHandler handler, IStepper stepper) { }
	}
}