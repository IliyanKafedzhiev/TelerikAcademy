function solve1(args)
{
    var dim = args[0];
    var dim = dim.split(" ");
    var rows = parseInt(dim[0]);
    var cols = parseInt(dim[1]);
    var matrix = Array(rows);
    var visited = Array(rows);
    var sums = Array(rows);
    for (var i = 0; i < rows; i++)
    {
        matrix[i] = Array(cols);
        visited[i] = Array(cols);
        sums[i] = Array(cols);
    }
    for (var i = 0; i < rows; i++)
    {
        var string = args[i + 1];
        var sum = Math.pow(2, i);
        for (var j = 0; j < cols; j++)
        {
            visited[i][j] = false;
            matrix[i][j] = string[j];
            sums[i][j] = sum;
            sum--;
        }
    }
    var FinalSum = 0;
    var InBox = true;
    var Row = rows - 1;
    var Col = cols - 1;
    var steps = 0;

    while (InBox)
    {
        if ((Row < 0) || (Row >= rows) || (Col < 0) || (Col >= cols))
        {
            InBox = false;
            console.log("Go go Horsy! Collected " + FinalSum + " weeds");
            break;
        }
        if (visited[Row][Col] === false)
        {
            visited[Row][Col] = true;
            FinalSum += sums[Row][Col];
            steps++;
        }
        else
        {
            console.log("Sadly the horse is doomed in " + steps + " jumps");
            break;
        }
        var dir = matrix[Row][Col];

        switch (dir)
        {
            case '1':
                Row -= 2;
                Col += 1;
                break;
            case '2':
                Row -= 1;
                Col += 2;
                break;
            case '3':
                Row += 1;
                Col += 2;
                break;
            case '4':
                Row += 2;
                Col += 1;
                break;
            case '5':
                Row += 2;
                Col -= 1;
                break;
            case '6':
                Row += 1;
                Col -= 2;
                break;
            case '7':
                Row -= 1;
                Col -= 2;
                break;
            case '8':
                Row -= 2;
                Col -= 1;
                break;
            default:
                break;
        }
    }
}

var args = [
  '3 5',
  '54561',
  '43328',
  '52388',
];
var args2 = [
  '3 5',
  '54361',
  '43326',
  '52188',
];

solve1(args);
