using System;

namespace Chess
{
  class Bishop : Figure
	{
    public Bishop (string color) : base(color)
    {
    }
    public override bool move(Figure[,] board, coord start, coord end) {
      return true;
    }
  }

}

