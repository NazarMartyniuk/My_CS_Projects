namespace Курсова
{
    public struct Dimensions
    {
        public int height;
        public int length;
        public int width;
        public static bool operator ==(Dimensions obj1, Dimensions obj2)
        {
            if (obj1.height == obj2.height && obj1.length == obj2.length && obj1.width == obj2.width)
                return true;
            else
                return false;
        }
        public static bool operator !=(Dimensions obj1, Dimensions obj2) => !(obj1 == obj2);
        public static bool operator >=(Dimensions obj1, Dimensions obj2)
        {
            if (obj1.height >= obj2.height && obj1.length >= obj2.length && obj1.width >= obj2.width)
                return true;
            else
                return false;
        }
        public static bool operator <=(Dimensions obj1, Dimensions obj2)
        {
            if (obj1.height <= obj2.height && obj1.length <= obj2.length && obj1.width <= obj2.width)
                return true;
            else
                return false;
        }
    }
}
