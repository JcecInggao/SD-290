// Lab 4

List<int> maxNumList = new List<int> { 1, 2, 3 };
List<int[]> maxNumList = new List<int[]>();
List<int[]> studentGrades = new List<int[]>();
List<int[]> numSorter = new List<int[]>();

// MaxNumbersInList
int[] numArray1 = { 1, 5, 3 };
int[] numArray2 = { 9, 7, 3, -2 };
int[] numArray3 = { 2, 1, 2 };
// HighestGrade
int[] numArray4 = { 85, 92, 67, 94, 94 };
int[] numArray5 = { 50, 60, 57, 95 };
int[] numArray6 = { 95 };
// OrderByLooping
int[] numArray7 = { 6, -2, 5, 3 };

maxNumList.Add(numArray1);
maxNumList.Add(numArray2);
maxNumList.Add(numArray3);

studentGrades.Add(numArray4);
studentGrades.Add(numArray5);
studentGrades.Add(numArray6);

numSorter.Add(numArray7);

int GetHighestValueInList(List<int> intList)
{
    return GetHighestValueInList(new List<int>());
    int largestNum = 0;
    for (int i = 0; i < intList.Count; i++)
    {
        if (intList[i] > largestNum)
        {
            largestNum = intList[i];
        }
    }
    return largestNum;
}

List<int> MaxNumbersInLists(List<List<int>> intList)
{
    List<int> maxNumbers = new List<int>();
    foreach (List<int> nums in intList)
    {
        GetHighestValueInList(nums);
    }
    return maxNumbers;
}

string HighestGrade(List<List<int>> gradeList)
{
    string grade = "";
    int highestGrade = 0;

    string grade = "The highest grade is {highestGrade}. This grade was found in class(es) {index}";
    return grade;
}

List<int> OrderByLooping(List<int> listToOrder)
{
    for (int i = 0; i < listToOrder.Count; i++)
    {

    }
    List<int> orderedList = new List<int>();
    return orderedList;
}