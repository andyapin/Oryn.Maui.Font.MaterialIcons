namespace Plugin.Toolkit.Fonts.MaterialIcons;

/// <summary>
/// Provides extension methods for adding Material Icons fonts to an IFontCollection.
/// </summary>
public static class FontExtensions
{
    /// <summary>
    /// Add font to global. using: FontFamily="Icon" (Icon or IconFilled)
    /// </summary>
    /// <param name="fonts">The IFontCollection to add fonts to.</param>
    /// <returns>The updated IFontCollection with Material Icons fonts added.</returns>
    public static IFontCollection AddMaterialIconsFonts(this IFontCollection fonts)
    {
        fonts.AddFont("MaterialSymbolsOutlined.ttf", FontAliases.MaterialIcon);
        fonts.AddFont("MaterialSymbolsOutlinedFilled.ttf", FontAliases.MaterialIconFilled);
        return fonts;
    }

    /// <summary>
    /// Add font to partial. using: FontFamily="MaterialIcon" (MaterialIcon or MaterialIconFilled)
    /// </summary>
    /// <param name="fonts">The IFontCollection to add fonts to.</param>
    /// <returns>The updated IFontCollection with Material Icons fonts added.</returns>
    public static IFontCollection AddMaterialIconsFontsPartial(this IFontCollection fonts)
    {
        fonts.AddFont("MaterialSymbolsOutlined.ttf", nameof(FontAliases.MaterialIcon));
        fonts.AddFont("MaterialSymbolsOutlinedFilled.ttf", nameof(FontAliases.MaterialIconFilled));
        return fonts;
    }
}