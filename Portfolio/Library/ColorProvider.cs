namespace Portfolio.Library
{
    public class ColorProvider : IProvideColors
    {
        private readonly Dictionary<string, string> ColorMap = new Dictionary<string, string>();

        public string FetchCSSColor(string colorTag)
        {
            //Return the pregenerated color for that tag, or a new color if the tag is new.
            Random random = new Random();
            if (!ColorMap.ContainsKey(colorTag))
            {
                ColorMap.Add(colorTag, $"rgb({random.Next(75, 175)}, {random.Next(75, 175)}, {random.Next(75, 175)})");
            }
            return ColorMap[colorTag];
        }
    }
}
