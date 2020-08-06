using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ChessCoreEngine
{
    class VarientBoardGenerator
    {
        public static string Chess960()
        {
            char[] positions = new char[8];
            List<int> avaliablePositions = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            Random rng = new Random();
            int selector;
            int bishop1 = rng.Next(4) * 2;
            avaliablePositions.RemoveAt(bishop1);
            int bishop2 = rng.Next(4) * 2 + 1;
            avaliablePositions.Remove(bishop2);
            selector = rng.Next(6);
            int queen = avaliablePositions[selector];
            avaliablePositions.RemoveAt(selector);
            selector = rng.Next(5);
            int knight1 = avaliablePositions[selector];
            avaliablePositions.RemoveAt(selector);
            selector = rng.Next(4);
            int knight2 = avaliablePositions[selector];
            avaliablePositions.RemoveAt(selector);
            int rook1 = avaliablePositions[0];
            int king = avaliablePositions[1];
            int rook2 = avaliablePositions[2];

            positions[bishop1] = 'b';
            positions[bishop2] = 'b';
            positions[queen] = 'q';
            positions[knight1] = 'n';
            positions[knight2] = 'n';
            positions[rook1] = 'r';
            positions[king] = 'k';
            positions[rook2] = 'r';

            return new string(positions) + "/pppppppp/8/8/8/8/PPPPPPPP/" + new string(positions).ToUpper();
        }
    }
}
