using System;

namespace Chess
{
  public class Knight : Figure
  {

    public Knight (string color) : base (color)
    {
      this.rule = new coord (1, 2);
    }

    public override bool move (Figure[,] board, coord start, coord end)
    {
      int x = this.rule.x;
      int y = this.rule.y;

      for (int i = 0; i < 2; i++) {
        if (i == 1) {
          x = this.rule.y;
          y = this.rule.x;
        }
        if (start.x + x == end.x) {
          if (start.y + y == end.y) {
            return true;
          }
        }
        if (start.x - x == end.x) {
          if (start.y - y == end.y) {
            return true;
          }
        }
        if (start.x - x == end.x) {
          if (start.y + y == end.y) {
            return true;
          }
        }
        if (start.x + x == end.x) {
          if (start.y - y  == end.y) {
            return true;
          }
        }
      }
      return false;
    }
  }

}

