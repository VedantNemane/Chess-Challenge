using ChessChallenge.API;
using Microsoft.CodeAnalysis;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
         Move[] moves = board.GetLegalMoves();
         return moves[0];
    }

    public static bool minimax(Board board, int depth, int maximisingPlayer) { 
        if (!(depth != 0 && !board.IsInCheckmate() && !board.IsInsufficientMaterial() && !board.IsInCheck()))
        {
            return true;
        }

        if (maximisingPlayer) { 
            
        }
    }
}