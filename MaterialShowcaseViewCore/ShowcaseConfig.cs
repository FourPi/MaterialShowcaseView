using Android.Graphics;
using Android.Views;
using MaterialShowcaseViewCore.Shape;

namespace MaterialShowcaseViewCore
{
	public class ShowcaseConfig
	{
		public static readonly Color DefaultMaskColour = Color.ParseColor("#dd335075");
		public const long DefaultFadeTime = 300;
		public const long DefaultDelay = 0;
		public static readonly IShape DefaultShape = new CircleShape();
		public const int DefaultShapePadding = 10;

		public long Delay { get; set; } = DefaultDelay;
		public Color MaskColor { get; set; } = DefaultMaskColour;
		public Color ContentTextColor { get; set; } = Color.ParseColor("#ffffff");
		public Color TitleTextColor { get; set; } = Color.ParseColor("#ffffff");
		public Color DismissTextColor { get; set; } = Color.ParseColor("#ffffff");
		public Typeface TitleTextStyle { get; set; } = Typeface.DefaultBold;
		public Typeface DismissTextStyle { get; set; } = Typeface.DefaultBold;
		public Typeface ContentTextStyle { get; set; } = Typeface.Default;
		public GravityFlags TitleTextGravity { get; set; } = GravityFlags.Center;
		public GravityFlags DismissTextGravity { get; set; } = GravityFlags.Center;
		public GravityFlags ContentTextGravity { get; set; } = GravityFlags.Center;
		public float TitleTextFontSize { get; set; } = 30;
		public float DismissTextFontSize { get; set; } = 15;
		public float ContentTextFontSize { get; set; } = 15;

		public long FadeDuration { get; set; } = DefaultFadeTime;
		public IShape Shape { get; set; } = DefaultShape;
		public int ShapePadding { get; set; } = DefaultShapePadding;
		public bool RenderOverNavigationBar { get; set; }
	}
}