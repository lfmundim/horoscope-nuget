﻿namespace Horoscope.Model
{
    internal class OxChineseZodiacModel: ChineseZodiacModel
    {
        internal OxChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
                  : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static OxChineseZodiacModel GetOxModel()
        {
            return new OxChineseZodiacModel("chǒu", ChineseZodiacSigns.Ox.ToString(), "Ox people are dependable & calm. They are good listeners & have very strong ideas.", ChineseZodiacElements.Earth);
        }
    }
}
