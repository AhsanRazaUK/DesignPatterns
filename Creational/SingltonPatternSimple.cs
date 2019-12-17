namespace Creational
{
    public class SingltonPatternSimple
    {
        private static SingltonPatternSimple _instance;
        private SingltonPatternSimple() { }

        public static SingltonPatternSimple Instance
        {
            get
            {
                // Only create new instance if it's not created before

                if (_instance == null)
                {
                    _instance = new SingltonPatternSimple();
                }

                return _instance;
            }
        }

        public int SomeValue { get; set; }
    }


}
