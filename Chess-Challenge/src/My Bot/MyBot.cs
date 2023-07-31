using ChessChallenge.API;
using Microsoft.CodeAnalysis;
using Raylib_cs;
using System;
using System.Threading.Tasks.Sources;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        // Console.WriteLine();
        for (int i = 0; i < board.GetAllPieceLists().Length; i++)
        {
            Console.Write($" ==> {board.GetAllPieceLists()[i]}");
        }
        Console.ReadKey();
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }

    public static float evaluate(Board board, int depth) {
        float score = 0;

        

        return score;
    }

    public static float minimax(Board board, int depth, bool maximisingPlayer) { 
        if (!(depth != 0 && !board.IsInCheckmate() && !board.IsInsufficientMaterial() && !board.IsInCheck()))
        {
            
        }

        if (maximisingPlayer) { 
            
        }

        return 0.0f;
    }
}