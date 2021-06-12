namespace Wildcat.Logic.SHCA.Engineering.GasMeters
{
    public class MeterReadItem
    {
        private string _itemName = string.Empty;
        private string _message = string.Empty;
        private int _progress = 0;
        private string _taskDetail = string.Empty;

        public MeterReadItem(string itemName, string message)
        {
            _itemName = itemName;
            _message = message;
        }

        public MeterReadItem()
        {
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string TaskDetail
        {
            get { return _taskDetail; }
            set { _taskDetail = value; }
        }

        public int Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }
    }
}