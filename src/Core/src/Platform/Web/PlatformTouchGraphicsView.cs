using System;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Primitives;

namespace Microsoft.Maui.Platform
{
	public class PlatformTouchGraphicsView : Ooui.Canvas, IGraphicsView
	{
		public IDrawable Drawable => throw new NotImplementedException();

		public string AutomationId => throw new NotImplementedException();

		public FlowDirection FlowDirection => throw new NotImplementedException();

		public LayoutAlignment HorizontalLayoutAlignment => throw new NotImplementedException();

		public LayoutAlignment VerticalLayoutAlignment => throw new NotImplementedException();

		public Semantics? Semantics => throw new NotImplementedException();

		public IShape? Clip => throw new NotImplementedException();

		public IShadow? Shadow => throw new NotImplementedException();

		public bool IsEnabled => throw new NotImplementedException();

		public bool IsFocused { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Visibility Visibility => throw new NotImplementedException();

		public double Opacity => throw new NotImplementedException();

		public Paint? Background => throw new NotImplementedException();

		public Rect Frame { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public double Width => throw new NotImplementedException();

		public double MinimumWidth => throw new NotImplementedException();

		public double MaximumWidth => throw new NotImplementedException();

		public double Height => throw new NotImplementedException();

		public double MinimumHeight => throw new NotImplementedException();

		public double MaximumHeight => throw new NotImplementedException();

		public Thickness Margin => throw new NotImplementedException();

		public Size DesiredSize => throw new NotImplementedException();

		public int ZIndex => throw new NotImplementedException();

		public IViewHandler? Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public bool InputTransparent => throw new NotImplementedException();

		public IElement? Parent => throw new NotImplementedException();

		public double TranslationX => throw new NotImplementedException();

		public double TranslationY => throw new NotImplementedException();

		public double Scale => throw new NotImplementedException();

		public double ScaleX => throw new NotImplementedException();

		public double ScaleY => throw new NotImplementedException();

		public double Rotation => throw new NotImplementedException();

		public double RotationX => throw new NotImplementedException();

		public double RotationY => throw new NotImplementedException();

		public double AnchorX => throw new NotImplementedException();

		public double AnchorY => throw new NotImplementedException();

		IElementHandler? IElement.Handler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Size Arrange(Rect bounds)
		{
			throw new NotImplementedException();
		}

		public void CancelInteraction()
		{
			throw new NotImplementedException();
		}

        public void Connect(IGraphicsView virtualView)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

		public void DragInteraction(PointF[] points)
		{
			throw new NotImplementedException();
		}

		public void EndHoverInteraction()
		{
			throw new NotImplementedException();
		}

		public void EndInteraction(PointF[] points, bool isInsideBounds)
		{
			throw new NotImplementedException();
		}

		public new bool Focus()
		{
			throw new NotImplementedException();
		}

		public void Invalidate()
		{
			throw new NotImplementedException();
		}

		public void InvalidateArrange()
		{
			throw new NotImplementedException();
		}

		public void InvalidateMeasure()
		{
			throw new NotImplementedException();
		}

		public Size Measure(double widthConstraint, double heightConstraint)
		{
			throw new NotImplementedException();
		}

		public void MoveHoverInteraction(PointF[] points)
		{
			throw new NotImplementedException();
		}

		public void StartHoverInteraction(PointF[] points)
		{
			throw new NotImplementedException();
		}

		public void StartInteraction(PointF[] points)
		{
			throw new NotImplementedException();
		}

		public void Unfocus()
		{
			throw new NotImplementedException();
		}
	}
}
