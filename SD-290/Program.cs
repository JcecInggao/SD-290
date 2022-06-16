// Lab 5


Dictionary<int, string> CarPark = new Dictionary<int, string>();

/*
 * this function adds a set number of keys to the dictionary, with null values.
 */
Dictionary<int, string> InitializeCarPark(int capacity)
{
    Dictionary<int, string> parkingLot = new Dictionary<int, string>();

    return parkingLot;
}

/*
 * this function will loop through the dictionary and try to find a value of "null"
 * if it is succesful, it will replace the null value with the string license value
 * it will then return the key value (stall number)
 * if it is unseccesful, or if the string license is invalid it will return a -1
 */
int AddVehicle(Dictionary<int, string> CarPark, string licence)
{
    int stallNumber = 0;
    return stallNumber;
}


/*
 * this function will try to remove an occupying vehicle from a stall 
 * if that stall is unoccupied or does not exist, it should return false, otherwise, return true.
 */
bool VacateStall(Dictionary<int, string> CarPark, int stallNumber)
{
    bool vacateStall = false;

    if (stallNumber != null)
    {
        vacateStall = true;
    }

    return vacateStall;
}


/*
 * takes the string licence and loops through dictionary to find a match
 * if successful, return true (resulting in a null parking spot)
 * unsuccessful when provided licence is invalid or does not refer to a parked vehicle
 */
bool LeaveParkade(Dictionary<int, string> CarPark, string licenceNumber)
{
    bool carRemoved = true;
    bool validLicense = true;

    if (licenceNumber == "")
    {
        validLicense = false;
    }

    if (!validLicense)
    {
        carRemoved = false;
    }


    return carRemoved;
}

/*
 * return a string of all the stalls occupied and their license
 */
string Manifest(Dictionary<int, string> CarPark)
{

    string manifest = "";
    return manifest;
}