using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GUI
{
    public class Board : IEnumerable<Cell>
    {
        private readonly Cell[,] _area;

        public State this[int row, int column]
        {
            get => _area[row, column].State;
            set => _area[row, column].State = value;
        }

        public Board()
        {
            _area = new Cell[8, 8];
            for (int i = 0; i < _area.GetLength(0); i++)
                for (int j = 0; j < _area.GetLength(1); j++)
                    _area[i, j] = new Cell();
        }

        public IEnumerator<Cell> GetEnumerator()
            => _area.Cast<Cell>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => _area.GetEnumerator();

        //public void Save(string filename) => File.WriteAllText(filename, JsonSerializer.Serialize(_area.Cast<Cell>()));
        //public Board(string filename) 
        //{ 
        //    _area = new Cell[8, 8]; 
        //    Cell[] data = JsonSerializer.Deserialize<Cell[]>(File.ReadAllText(filename)); 
        //    for (int i = 0; i < _area.GetLength(0); i++) 
        //        for (int j = 0; j < _area.GetLength(1); j++) 
        //            _area[i, j] = data[i * 8 + j]; 
        //}
    }
}
