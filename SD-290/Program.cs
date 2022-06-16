// Lab 4

// incomplete, please remember to finish later!

List<List<int>> maxNumList = new List<List<int>>();
List<List<int>> studentGrades = new List<List<int>>();
List<List<int>> numSorter = new List<List<int>>();

// MaxNumbersInList
List<int> numArray1 = new List<int> { 1, 5, 3 };
List<int> numArray2 = new List<int> { 9, 7, 3, -2 };
List<int> numArray3 = new List<int> { 2, 1, 2 };
// HighestGrade
List<int> numArray4 = new List<int> { 85, 92, 67, 94, 94 };
List<int> numArray5 = new List<int> { 50, 60, 57, 95 };
List<int> numArray6 = new List<int> { 95 };
// OrderByLooping
List<int> numArray7 = new List<int> { 6, -2, 5, 3 };

// MaxNumbersInList
maxNumList.Add(numArray1);
maxNumList.Add(numArray2);
maxNumList.Add(numArray3);
// HighestGrade
studentGrades.Add(numArray4);
studentGrades.Add(numArray5);
studentGrades.Add(numArray6);
// OrderByLooping
numSorter.Add(numArray7);

// How to find the value inside the list
//foreach (List<int> list in maxNumList)
//{
//    foreach (int listItem in list)
//    {
//        Console.WriteLine(listItem);
//    }
//}

//foreach (List<int> list in maxNumList)
//{
//    Console.WriteLine($"List {counter} has a maximum of {GetHighestValueInList(list)}");
//}

Console.WriteLine(MaxNumbersInLists(maxNumList));

//foreach (List<int> nums in maxNumList)
//{
//    Console.WriteLine(GetHighestValueInList(nums));
//}

int GetHighestValueInList(List<int> intList)
{
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
        maxNumbers.Add(GetHighestValueInList(nums));
    }

    return maxNumbers;
}

string HighestGrade(List<List<int>> gradeList)
{
    string grade = "";
    int highestGrade = 0;
    int index = new int { };
    for (int i = 0; i < gradeList.Count; i++)
    {
        grade = gradeList[i].ToString();
    }

    grade = $"The highest grade is {highestGrade}. This grade was found in class(es) {index}";
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