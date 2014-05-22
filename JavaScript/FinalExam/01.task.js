function solve(params)
{
    var s = parseInt(params[0]), c1 = parseInt(params[1]), c2 = parseInt(params[2]), c3 = parseInt(params[3]);
    var answer = s;
    // Your solution here

    while (answer > 0)
    {
        if (answer >= c1)
        {
            var optimal = answer % c1;
            if ((optimal > (answer % c2)) && (answer >= c2))
            {
                optimal = answer % c2;
                if ((optimal > (answer % c3)) && (answer >= c3))
                {
                    answer -= c3;
                }
                else
                {
                    answer -= c2;
                }
            }
            else
            {
                answer -= c1;
            }
        }
        else
        {

            break;
        }
    }

    console.log(s - answer);
}

var par = [110, 13, 15, 17]

//solve(par);

var test2 = [20,
11,
200,
300
]

//solve(test2);

var test3 = [110,
19,
29,
39,
];

//solve(test3);
