// Lab 6

/*
 * A boolean 2D array represents the relationships between guests at a party
 * The goal of the algorithm is to find the famous person
 * This person doesn’t know anyone else at the party, but everyone else knows of them.
 * 
 * explain why there can be only one famous person at most in any 2D array:
 * 
 * if there are two famous people neither one of them fit the line "but everyone else knows of them"
 *                  or
 * two famous people will result in one row/column of the array to have an outstanding false,
 * making it hard to find the famous person
 */


bool[,] knowsPerson = new bool[4, 4]
{
    { true, false, true, true},
    { false, true, false, true},
    { false, false, true, true},
    { true, false, true, true}
};


int FindFamous(bool[,] room)
{

    /*
    if(famous = true)
    {
        return famous[index];
    }
    */

    return -1;
}