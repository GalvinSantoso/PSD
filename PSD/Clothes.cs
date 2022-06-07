using System;

namespace PSD
{
    public class Clothes
    {
        public string clothesName { get; set; }
        public string clothesSize { get; set; }
        public int clothesPrice { get; set; }
        public string clothesColor { get; set; }

        public Clothes(string aClothesName, string aClothesSize, int aClothesPrice, string aClothesColor)
        {
            this.clothesName = aClothesName;
            this.clothesSize = aClothesSize;
            this.clothesPrice = aClothesPrice;
            this.clothesColor = aClothesColor;
        }

    }
}