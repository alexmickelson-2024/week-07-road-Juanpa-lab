public class Road : IRoad
    {
        private IVehicle[,] _vehicles;

        public int RowCount { get; private set; }
        public int ColCount { get; private set; }

        public Road(int rows, int columns)
        {
            RowCount = rows;
            ColCount = columns;
            _vehicles = new IVehicle[rows, columns];
        }

        public IVehicle GetVehicle(int row, int col)
        {
            if (row < 0 || row >= RowCount || col < 0 || col >= ColCount)
                return null;
            return _vehicles[row, col];
        }

        public void SetVehicle(int row, int col, IVehicle vehicle)
        {
            if (row >= 0 && row < RowCount && col >= 0 && col < ColCount)
            {
                _vehicles[row, col] = vehicle;
            }
        }
    }