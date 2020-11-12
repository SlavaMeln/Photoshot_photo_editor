namespace Photoshot.BL.Model.Colors
{
    public struct Color
    {
        private byte _r;
        private byte _g;
        private byte _b;
        
        /// <summary>
        /// Цвет
        /// </summary>
        /// <param name="r">Красный</param>
        /// <param name="g">Зеленый</param>
        /// <param name="b">Синий</param>
        public Color(byte r, byte g, byte b)
        {
            _r = r;
            _g = g;
            _b = b;
        }
        /// <summary>
        /// Цвет
        /// </summary>
        /// <param name="color">Цвет из перечисления Colors</param>
        public Color(Colors color)
        {
            switch (color)
            {
                case Colors.White:
                    _r = 255;
                    _g = 255;
                    _b = 255;
                    break;
                case Colors.Black:
                    _r = 0;
                    _g = 0;
                    _b = 0;
                    break;
                case Colors.Red:
                    _r = 255;
                    _g = 0;
                    _b = 0;
                    break;
                case Colors.Blue:
                    _r = 0;
                    _g = 0;
                    _b = 255;
                    break;
                case Colors.Green:
                    _r = 0;
                    _g = 255;
                    _b = 0;
                    break;
                case Colors.Grey:
                    _r = 150;
                    _g = 150;
                    _b = 150;
                    break;
                case Colors.Purple:
                    _r = 255;
                    _g = 0;
                    _b = 255;
                    break;
                default:
                    _r = 0;
                    _g = 0;
                    _b = 0;
                    break;
            }
        }
    }
}