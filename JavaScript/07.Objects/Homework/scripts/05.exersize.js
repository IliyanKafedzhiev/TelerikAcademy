var persons = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Pesho', lastname: 'Petrov', age: 3 }, ];

function findYoungestPerson(persons)
{
    var yangest = persons[0];
    for (var i in persons)
    {
        if (persons[i].age < yangest.age)
        {
            yangest = persons[i];
        }
    }
    return yangest;
}

jsConsole.writeLine("Yangest Person is " + findYoungestPerson(persons).firstname + " Age :" + findYoungestPerson(persons).age);
