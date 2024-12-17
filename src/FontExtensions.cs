namespace Plugin.Toolkit.Fonts.MaterialIcons;

public static class FontExtensions
{
    /// <summary>
    /// Add font to global. using: FontFamily="Icon" (Icon or IconFilled)
    /// </summary>
    public static IFontCollection AddMaterialIconsFonts(this IFontCollection fonts)
    {
        var thisAssembly = typeof(FontExtensions).Assembly;
        fonts.AddEmbeddedResourceFont(thisAssembly, "MaterialSymbolsOutlined.ttf", FontAliases.MaterialIcon);
        fonts.AddEmbeddedResourceFont(thisAssembly, "MaterialSymbolsOutlinedFilled.ttf", FontAliases.MaterialIconFilled);
        return fonts;
    }

    /// <summary>
    /// Add font to partial. using: FontFamily="MaterialIcon" (MaterialIcon or MaterialIconFilled)
    /// </summary>
    public static IFontCollection AddMaterialIconsFontsPartial(this IFontCollection fonts)
    {
        var thisAssembly = typeof(FontExtensions).Assembly;
        fonts.AddEmbeddedResourceFont(thisAssembly, "MaterialSymbolsOutlined.ttf", FontAliases.Name + FontAliases.MaterialIcon);
        fonts.AddEmbeddedResourceFont(thisAssembly, "MaterialSymbolsOutlinedFilled.ttf", FontAliases.Name + FontAliases.MaterialIconFilled);
        return fonts;
    }
}