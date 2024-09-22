namespace ObjectOrientedPractics
{
    internal class IDGenerator
    {
        private static int _currentId = 0;
        private static readonly object _lockingObject = new object();

        public static int GetNextId()
        {
            lock (_lockingObject)
            {
                _currentId++;
                return _currentId;
            }
        }
    }
}
