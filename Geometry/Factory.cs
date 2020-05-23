using System;

namespace areyesram.Geometry
{
    internal class Factory
    {
        private static readonly IFinder[] _instance = { null, new V1(), new V2(), new V3() };

        public static IFinder GetFinder(int version)
        {
            if (version < 1 || version > 3)
                throw new Exception("Unknown version");
            return _instance[version];
        }
    }
}
