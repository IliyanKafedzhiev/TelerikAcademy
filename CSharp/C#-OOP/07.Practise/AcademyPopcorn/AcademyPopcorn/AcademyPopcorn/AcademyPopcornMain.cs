using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void AddBorder(ref Engine engine)
        {
            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock block = new IndestructibleBlock(new MatrixCoords(i, 0));
                engine.AddObject(block);
            }
            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock block = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(block);
            }
            for (int i = 1; i < WorldCols - 1; i++)
            {
                IndestructibleBlock block = new IndestructibleBlock(new MatrixCoords(0, i), '-');
                engine.AddObject(block);
            }
        }
        static void AddBlocksForGameplay(ref Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow+1, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow + 2, i));

                engine.AddObject(currBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow + 3, i));

                engine.AddObject(currBlock);
            }

        }
        static void Initialize(Engine engine)
        {
            AddBorder(ref engine);

            AddBlocksForGameplay(ref engine);

            MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard,250);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
