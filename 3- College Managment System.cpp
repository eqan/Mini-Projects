/**
 * ? Folders Required
 * TODOFolder:- "Project#1"
 * TODO Sub Folder:- "Assessment Marks". "Courses", "Fees", "Marks", "Students", "Teachers", "Assigned Course"
 * */
#include <iostream>
#include <fstream>
#include <stdlib.h>
#include <sstream>
#include <string>
#include <climits>

using namespace std;

ifstream inFile;
ofstream outFile;

string filePath = "/home/eqan/Desktop/OOP/Project#1/", folder, fileName, extension = ".txt";

// ? As linux doesn't support system("CLS"), I'm using this as an alternative
void clearScreen()
{
    cout << string(100, '\n');
}

class AdministrationModule
{
protected:
    string firstName, lastName, registrationDate, address, joiningDate, email, gender, contactNumb;
    AdministrationModule()
    {
        firstName = "", lastName = "", registrationDate = "", address = "", contactNumb = "", email = "", gender = "";
    }
    virtual void store() = 0;
};

class Courses : public AdministrationModule
{
    Courses *arr;

protected:
    string courseName, parentCourse, studentGrade, _class, section;
    int courseCode, numbOfCourses;

public:
    static int teacherCount;
    Courses()
    {
        courseName = "", parentCourse = "", studentGrade = "", _class = "", courseCode = 0, numbOfCourses = 0;
    }
    void addCourse()
    {
        int i = 0;
        cout << "Enter Number Of Courses: ";
        cin >> numbOfCourses;
        arr = new Courses[numbOfCourses];
        cout << "Enter Class: ";
        cin >> arr[i]._class;
        for (i; i < numbOfCourses; i++)
        {
            clearScreen();
            cout << "Course_" << i << '\n';
            cout << "Enter Course Name[Press '.' & then enter to end]: ";
            cin.ignore();
            getline(cin, arr[i].courseName, '.');
            cout << "Enter Course Code: ";
            cin >> arr[i].courseCode;
            cout << "Enter Parent Course[Press '.' & then enter to end]: ";
            cin.ignore();
            getline(cin, arr[i].parentCourse, '.');
        }
        store();
    }
    void viewAllCourses()
    {
        cout << "\n\n_____COURSES_____\n\n";
        folder = "Courses/";
        string tempData, file;
        cout << "Enter Class: ";
        cin >> _class;
        inFile.open(filePath + folder + _class + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        string statement = "Course Name: ";
        infoDisplay(file, _class, statement, "", 2);
    }
    void assignCourse()
    {
        char dec;
        int numb;
        string section;
        ++teacherCount;
        folder = "Assigned Courses/";
        cout << "Enter Teacher Name: ";
        cin >> firstName >> lastName;
        firstName = firstName + " " + lastName;
        outFile.open(filePath + folder + firstName + extension, ios::app);
        outFile << "Name: " << firstName << '\n';
    loop2:
        cout << "Enter Class: ";
        cin >> _class;
        viewAllCourses(_class);
        cout << "Enter Course to Assign[Press '.' & Enter to end]: ";
        cin.ignore();
        getline(cin, courseName, '.');
        cout << "Enter Section/Secions[e.g A or A-B-C]: ";
        cin >> section;
        cout << "Enter Number of Students: ";
        cin >> numb;
        outFile << "Classes: " << _class << " "
                << "Section/Sections: " << section << '\n';
        outFile << "Course Assigned: " << courseName << '\n';
        outFile << "Number Of Students: " << numb << '\n';
        cout << "Do you want to add another course under this teacher[Press 'y' || 'Y']?\n";
        cin >> dec;
        if (dec == 'y' || dec == 'Y')
        {
            clearScreen();
            goto loop2;
        }
        outFile << "\n#\n";
        outFile.close();
    }

protected:
    virtual void store()
    {
        folder = "Courses/";
        int i = 0;
        outFile.open(filePath + folder + arr[i]._class + extension, ios::app);
        for (i; i < numbOfCourses; i++)
        {
            outFile << "\n$ Course_" << i << '\n'
                    << "Course Name: " << arr[i].courseName << '\n';
            outFile << "Course Code: " << arr[i].courseCode << '\n';
            outFile << "Parent Course: " << arr[i].parentCourse << '\n';
        }
        outFile << "\n#\n";
        outFile.close();
        cout << "[+] Information Stored Successfully!\n";
    }
    void viewAllCourses(string &_class)
    {
        cout << "\n\n_____COURSES_____\n\n";
        folder = "Courses/";
        string tempData, file;
        inFile.open(filePath + folder + _class + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        string statement = "Course Name: ";
        infoDisplay(file, _class, statement, "", 1);
        return;
    }
    void infoDisplay(string &file, string &fileName, string &statement, string statement2, int opt)
    {
        int start = 0, reset = 0, countCohesiveness = 0, count = 0;
        switch (opt)
        {
        case 0: // ? This is for any string that has numbers in it
        {
            for (int i = 0; i < file.length(); ++i)
            {
            loop:
            {
                start = reset;
                if (file[i] != statement[start])
                {
                    while (file[i] != statement[start])
                    {
                        ++i;
                        if (file[i] == '#')
                        {
                            return;
                        }
                    }
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            countCohesiveness = reset;
                            goto loop;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length())
                {
                    start = reset;
                    cout << ++count << ". ";
                    if (file[i] != '\n')
                    {
                        while (file[i] != '\n' && file[i] >= 48 && file[i] <= 57)
                        {
                            cout << file[i];
                            ++i;
                        }
                    }
                    cout << '\n';
                    countCohesiveness = reset;
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
                break;
            }
        }
        break;
        case 1: // ? This is for any string that has characters or maybe numbers in it
        {
            for (int i = 0; i < file.length(); i++)
            {
            loop1:
            {
                start = reset;
                if (file[i] != statement[start])
                {
                    while (file[i] != statement[start])
                    {
                        ++i;
                        if (file[i] == '#')
                        {
                            return;
                        }
                    }
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            countCohesiveness = reset;
                            goto loop1;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length())
                {
                    start = reset;
                    cout << ++count << ". ";
                    if (file[i] != '\n')
                    {
                        while (file[i] != '\n')
                        {
                            cout << file[i], ++i;
                        }
                    }
                    cout << '\n';
                    countCohesiveness = reset, start = reset;
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
            }
            return;
        }
        break;
        case 2: // ? This case prints out all of the information of a specific individual instead of just names or numbers
        {
            for (int i = 0; i < file.length(); i++)
            {
            loop2:
            {
                start = reset;
                if (file[i] != statement[start])
                {
                    while (file[i] != statement[start])
                    {
                        ++i;
                        if (file[i] == '#')
                        {
                            return;
                        }
                    }
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            countCohesiveness = reset;
                            goto loop2;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length())
                {
                    start = reset;
                    cout << ++count << ". ";
                    if (file[i] != '$')
                    {
                        while (file[i] != '$')
                        {
                            cout << file[i];
                            if (file[i] == '#')
                            {
                                return;
                            }
                            ++i;
                        }
                    }
                    cout << '\n';
                    countCohesiveness = reset, start = reset;
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
            }
        }
        break;
        case 3: // ! Unstable can't be used
                // ? This function can display two statements at a time
        {
            for (int i = 0; i < file.length(); i++)
            {
            loop3:
            {
                start = reset;
                if (file[i] != statement[start] || file[i] != statement2[start])
                {
                    while (file[i] != statement[start] || file[i] != statement2[start])
                    {
                        ++i;
                        if (file[i] == '#')
                        {
                            return;
                        }
                    }
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            countCohesiveness = reset;
                            goto loop3;
                        }
                    }
                }
                if (file[i] == statement2[start])
                {
                    while (file[i] == statement2[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement2.length())
                        {
                            continue;
                        }
                        if (file[i] != statement2[start])
                        {
                            goto loop3;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length() || countCohesiveness >= statement2.length())
                {
                    start = reset;
                    cout << ++count << ". ";
                    if (file[i] != '\n')
                    {
                        while (file[i] != '\n')
                        {
                            cout << file[i], ++i;
                        }
                    }
                    cout << '\n';
                    countCohesiveness = reset, start = reset;
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
            }
            return;
        }
        break;
        }
        cout << "[+] Information Displayed Successfully!\n";
    }
    void modifyInfo(string &folder, string &file, string &statement, string &content, string &fileName, int opt, int &staticPosition)
    {
        int start = 0, reset = 0, countCohesiveness = 0, i = staticPosition;
        switch (opt)
        {
        case 0: // ? This is for any string that has numbers in it
        {
            for (i; i < file.length(); i++)
            {
            loop:
            {
                start = reset;
                if (file[i] != statement[start])
                {
                    while (file[i] != statement[start])
                        ++i;
                    if (file[i] == '#')
                    {
                        exit;
                    }
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            goto loop;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length())
                {
                    start = reset;
                    if (file[i] != '\n')
                    {
                        while (file[i] != '\n' && file[i] >= 48 && file[i] <= 57)
                        {
                            if (content[start] != '\n')
                            {
                                file[i] = content[start];
                                ++start, ++i;
                            }
                        }
                    }
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
                break;
            }
        }
        break;
        case 1: // ? This is for any string that has characters or maybe numbers in it
        {
            for (i; i < file.length(); i++)
            {
            loop1:
            {
                start = reset;
                if (file[i] != statement[start])
                {
                    while (file[i] != statement[start])
                        ++i;
                }
                if (file[i] == statement[start])
                {
                    while (file[i] == statement[start] && file[i] != '\n')
                    {
                        ++i, ++start, ++countCohesiveness;
                        if (countCohesiveness >= statement.length())
                        {
                            continue;
                        }
                        if (file[i] != statement[start])
                        {
                            goto loop;
                        }
                    }
                }
            }
                if (countCohesiveness >= statement.length())
                {
                    start = reset;
                    if (file[i] != '\n')
                    {
                        while (file[i] != '\n')
                        {
                            if (content[start] != '\n')
                            {
                                file[i] = content[start];
                                ++start, ++i;
                            }
                        }
                    }
                }
                else
                {
                    start = reset, countCohesiveness = reset;
                }
                break;
            }
        }
        break;
        }
        outFile.open(filePath + folder + fileName + extension);
        for (int i = 0; i < file.length(); i++)
        {
            outFile << file[i];
        }
        cout << "\n[+] File Modified\n";
        outFile.close();
    }
};

int Courses::teacherCount = 0;

class Students : protected Courses
{
protected:
    int studentSize, marks, totalFee, feeSubmitted, remainingFee, financialAid, totalMarks;
    string _class, section, fatherName, fatherProfession, parentContact, bloodGroup, status, rollNumb;
    Students *arr;

public:
    Students()
    {
        totalMarks = 0, marks = 0, studentSize = 0, totalFee = 0, feeSubmitted = 0, remainingFee = 0, financialAid = 0, _class = "", fatherName = "", fatherProfession = "";
        parentContact = "", bloodGroup = "", status = "", section = "";
    }
    void addStudents()
    {
        int i = 0;
        cout << "Enter Number of Students: ";
        cin >> studentSize;
        arr = new Students[studentSize];
        cout << "Enter Class: ";
        cin >> arr[i]._class;
        cout << "Enter Section: ";
        cin >> arr[i].section;
        for (i; i < studentSize; i++)
        {
            cout << "Student_" << i << '\n';
            cout << "Enter First Name: ";
            cin >> arr[i].firstName;
            cout << "Enter Last Name: ";
            cin >> arr[i].lastName;
            cout << "Enter Roll Number[Only Integers e.g 0256]: ";
            cin >> arr[i].rollNumb;
            cout << "Enter Email: ";
            cin >> arr[i].email;
            cout << "Enter Registration Date: ";
            cin >> arr[i].registrationDate;
            cout << "Enter Gender: ";
            cin >> arr[i].gender;
            cout << "Enter Contact Number: ";
            cin >> arr[i].contactNumb;
            cout << "Enter Father Name[Press '.' & Enter to end]: ";
            cin.ignore();
            getline(cin, arr[i].fatherName, '.');
            cout << "Enter Father Profession[Press '.' & Enter to end]: ";
            cin.ignore();
            getline(cin, arr[i].fatherProfession, '.');
            cout << "Enter Parent Contact: ";
            cin >> arr[i].parentContact;
            cout << "Enter Fee: ";
            cin >> arr[i].feeSubmitted;
            cout << "Enter Blood Group: ";
            cin >> arr[i].bloodGroup;
            cout << "Enter Address[Press '.' & Enter to end]: ";
            cin.ignore();
            getline(cin, arr[i].address, '.');
        }
        store();
    }

    void editStudent()
    {
        cout << "Enter Class: ";
        cin >> _class;
        cout << "Enter Section: ";
        cin >> section;
        viewAllStudents(_class, section);
        folder = "Students/", fileName = _class + section;
        int countCohesiveness = 0, opt, staticPosition = 0, start = 0, reset = 0;
        char dec;
        string file, tempData, statement;
        inFile.open(filePath + folder + fileName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        cout << "Roll Number: ";
        cin >> rollNumb;
        for (int i = 0; i < file.length(); i++)
        {
            if (file[i] == rollNumb[start])
            {
                while (file[i] == rollNumb[start] && file[i] != '\n')
                {
                    ++countCohesiveness, ++i, ++start;
                    if (countCohesiveness >= (rollNumb.length()))
                        continue;
                }
            }
            else
            {
                countCohesiveness = reset, start = reset;
            }
            if (countCohesiveness >= (rollNumb.length()))
            {
                staticPosition = i;
                cout << "0. Name\n1. Fee\n2. Address\n3. Contact Number\n";
                cout << "Option: ";
                cin >> opt;
                clearScreen();
                while (cin.fail())
                {
                    clearScreen();
                    cin.clear();
                    cin.ignore(INT_MAX, '\n');
                    cout << "You can only enter numbers.\n";
                    cout << "0. Name\n1. Fee\n2. Address\n3. Contact Number\n";
                    cout << "Option: ";
                    cin >> opt;
                }
                switch (opt)
                {
                case 0:
                {
                    statement = "Name: ";
                    cout << statement;
                    cin >> firstName >> lastName;
                    firstName = firstName + " " + lastName;
                    modifyInfo(folder, file, statement, firstName, fileName, 1, staticPosition);
                    break;
                }
                case 1:
                {
                    statement = "Fee: ";
                    cout << statement;
                    cin >> feeSubmitted;
                    stringstream ostr;
                    ostr << feeSubmitted;
                    string fee = ostr.str();
                    modifyInfo(folder, file, statement, fee, fileName, 0, staticPosition);
                    break;
                }
                case 2:
                {
                    statement = "Address: ";
                    cout << "Enter Address[Press '.' & then enter to end]: ";
                    cin.ignore();
                    getline(cin, address, '.');
                    modifyInfo(folder, file, statement, address, fileName, 1, staticPosition);
                    break;
                }
                case 3:
                {
                    statement = "Contact Number: ";
                    cout << statement;
                    cin >> contactNumb;
                    modifyInfo(folder, file, statement, contactNumb, fileName, 0, staticPosition);
                    break;
                }
                default:
                    cout << "Your input exceeded the number of options\n";
                    break;
                }
            }
        }
    }

    void viewAllStudents()
    {
        int opt;
        cout << "0. View All Students\n1. View One By search\n";
        cout << "Option: ";
        cin >> opt;
        clearScreen();
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "You can only enter numbers.\n";
            cout << "0. View All Students\n1. View One By search\n";
            cout << "Option: ";
            cin >> opt;
        }
        switch (opt)
        {
        case 0:
        {
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            cout << "\n____Students____\n";
            string file, tempData, statement;
            folder = "Students/";
            fileName = _class + section;
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            statement = "Roll Number: ";
            infoDisplay(file, fileName, statement, "", 2);
            break;
        }
        case 1:
        {
            cout << "Enter Roll Number: ";
            cin >> rollNumb;
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            cout << "\n____Student____\n";
            string file, tempData;
            folder = "Students/";
            fileName = _class + section;
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            infoDisplay(file, fileName, rollNumb, "", 2);
            break;
        }
        default:
            cout << "Options have exceeded the limit, Please try again";
            break;
        }
    }

    void updateStudentMarks()
    {
        int opt;
        cout << "0. Assessment Marks\n1. Result Marks\n";
        cout << "Option: ";
        cin >> opt;
        clearScreen();
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "You can only enter numbers.\n";
            cout << "0. Assessment Marks\n1. Result Marks\n";
            cout << "Option: ";
            cin >> opt;
        }
        switch (opt)
        {
        case 0:
        {
            char dec;
            int count = 0, studentCount = 0, opt;
            string statement;
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
        loop:
            folder = "Courses/";
            viewAllCourses(_class);
            cout << "Enter Roll Number: ";
            cin >> rollNumb;
            cout << "Enter Name: ";
            cin >> firstName >> lastName;
            firstName = firstName + " " + lastName;
            storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 0);
        loop2:
            cout << "0. Quizes\n1. Assignments\n2. Project\n3. Presentation\n4. Class Participations\n";
            cout << "Option: ";
            cin >> opt;
            clearScreen();
            while (cin.fail())
            {
                clearScreen();
                cin.clear();
                cin.ignore(INT_MAX, '\n');
                cout << "You can only enter numbers.\n";
                cout << "0. Quizes\n1. Assignments\n2. Project\n3. Presentation\n4. Class Participations\n";
                cout << "Option: ";
                cin >> opt;
            }
            cout << "Enter Obtained Marks: ";
            cin >> marks;
            cout << "Enter Total Marks: ";
            cin >> totalMarks;
            switch (opt)
            {
            case 0:
                ++count;
                statement = "Quiz ";
                storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 1);
                cout << "Do you want to add another[Press 'y' || 'Y']?";
                cin >> dec;
                if (dec == 'y' || dec == 'Y')
                {
                    goto loop2;
                }
                break;
            case 1:
                ++count;
                statement = "Assignment ";
                storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 1);
                cout << "Do you want to add another[Press 'y' || 'Y']?";
                cin >> dec;
                if (dec == 'y' || dec == 'Y')
                {
                    goto loop2;
                }
                else
                {
                    count = 0;
                    break;
                }
            case 3:
                ++count;
                statement = "Project ";
                storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 1);
                cout << "Do you want to add another[Press 'y' || 'Y']?";
                cin >> dec;
                if (dec == 'y' || dec == 'Y')
                {
                    goto loop2;
                }
                else
                {
                    count = 0;
                    break;
                }
            case 4:
                ++count;
                statement = "Presentation ";
                storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 1);
                cout << "Do you want to add another[Press 'y' || 'Y']?";
                cin >> dec;
                if (dec == 'y' || dec == 'Y')
                {
                    goto loop2;
                }
                else
                {
                    count = 0;
                    break;
                }
            case 5:
                ++count;
                statement = "Class Participation ";
                storeAssessmentMarks(firstName, rollNumb, fileName, statement, marks, totalMarks, count, studentCount, 1);
                cout << "Do you want to add another[Press 'y' || 'Y']?";
                cin >> dec;
                if (dec == 'y' || dec == 'Y')
                {
                    goto loop2;
                }
                else
                {
                    count = 0;
                    break;
                }
            default:
                cout << "Option has exceeded limit, Please try again!\n";
                break;
            }
            cout << "Do you want to add another student's assessment marks[Press 'y' || 'Y']?";
            cin >> dec;
            if (dec == 'y' || dec == 'Y')
            {
                clearScreen();
                ++studentCount;
                goto loop;
            }
            // ? To add # at the end to prevent the program from crashing '#' acts as the end point of a file
            outFile.open(filePath + folder + fileName + extension, ios::app);
            outFile << "\n#\n";
            outFile.close();
            break;
        }
        case 1:
        {
            string file, data, statement;
            int j = 0;
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            fileName = _class + section;
            folder = "Marks/";
            outFile.open(filePath + folder + fileName + extension, ios::app);
            cout << "Enter Number of Students: ";
            cin >> studentSize;
            arr = new Students[studentSize];
            for (j; j < studentSize; j++)
            {
                cout << "Student_" << j << endl;
                cout << "Enter Roll Number: ";
                cin >> arr[j].rollNumb;
                cout << "Enter Name: ";
                cin >> arr[j].firstName;
                cin >> arr[j].lastName;
                viewAllCourses(_class);
                cout << "Enter Number Of Courses: ";
                cin >> arr[j].numbOfCourses;
                string *tempData = new string[arr[j].numbOfCourses];
                for (int i = 0; i < arr[j].numbOfCourses; i++)
                {
                    cout << "Enter Course Name[Press '.' & then enter to end]: ";
                    cin.ignore();
                    getline(cin, arr[j].courseName, '.');
                    cout << "Enter Marks: ";
                    cin >> arr[j].marks;
                    arr[j].studentGrade = marksChecker(arr[j].marks);
                    ostringstream ostr;
                    ostr << arr[j].marks;
                    string iMarks = ostr.str();
                    tempData[i] = "Course Name: " + arr[j].courseName + " " + "Marks: " + iMarks + " " + "Grade: " + arr[j].studentGrade + '\n';
                }
                folder = "Marks/";
                outFile << "$ Student_" << j << endl;
                outFile << "Roll Number: " << arr[j].rollNumb << endl;
                outFile << "Name: " << arr[j].firstName << " " << arr[j].lastName << endl;
                for (int i = 0; i < arr[j].numbOfCourses; i++)
                {
                    outFile << tempData[i];
                }
                outFile << '\n';
            }
            outFile << "\n#\n";
            outFile.close();
            break;
        }

        default:
            cout << "Option has exceeded the limit, Please try again!\n";
            break;
        }
    }
    void feeStatus()
    {
        folder = "Fees/";
        int count = 0;
        char dec;
        cout << "Enter Class: ";
        cin >> _class;
        cout << "Enter Section: ";
        cin >> section;
        cout << "Enter Total Fee: ";
        cin >> totalFee;
    loop2:
        cout << "Enter Roll Number: ";
        cin >> rollNumb;
        cout << "Enter Name: ";
        cin >> firstName;
        cin >> lastName;
        cout << "Enter Fee Submitted: ";
        cin >> feeSubmitted;
        cout << "Enter Financial Aid[in Percent]: ";
        cin >> financialAid;
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "Enter in numbers!\n";
            cout << "Enter Financial Aid[in Percent]: ";
            cin >> financialAid;
        }
        financialAid = (totalFee * financialAid) / 100;
        remainingFee = totalFee - feeSubmitted - financialAid;
        if (remainingFee == 0)
            status = "Submitted";
        else if (remainingFee == totalFee)
            status = "Not Submitted";
        else if (remainingFee > 0 && remainingFee <= totalFee)
            status = "Partly Submitted";
        else
        {
            status = "Unprecedented: Admin Recheck";
        }
        outFile.open(filePath + folder + _class + section + extension);
        outFile << "$ Student_" << count << '\n';
        outFile << "Roll Number: " << rollNumb << '\n';
        outFile << "Name: " << firstName << " " << lastName << '\n';
        outFile << "Total Fee: " << totalFee << '\n';
        outFile << "Fee Submitted: " << feeSubmitted << '\n';
        outFile << "Financial Aid: " << financialAid << '\n';
        outFile << "Remaining Fee: " << remainingFee << '\n';
        outFile << "Over All Status: " << status << '\n';
        outFile.close();
        cout << "Do you want to add more students in this class and section[Press 'y' || 'Y']?\n";
        cin >> dec;
        if (dec == 'y' || dec == 'Y')
        {
            clearScreen();
            goto loop2;
        }
    }

    void viewFeeStatus()
    {
        cout << "0. View Fees Of All Students\n1. View Fees Of One student\n";
        cout << "Option: ";
        int opt;
        cin >> opt;
        clearScreen();
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "You can only enter numbers.\n";
            cout << "0. View Fees Of All Students\n1. View Fees Of One student\n";
            cout << "Option: ";
            cin >> opt;
        }
        switch (opt)
        {
        case 0:
        {
            string file, tempData;
            folder = "Fees/";
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            fileName = _class + section;
            string statement = "Roll Number: ";
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            infoDisplay(file, fileName, statement, "", 2);
            return;
        }
        case 1:
        {
            string file, tempData;
            folder = "Fees/";
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            fileName = _class + section;
            viewAllStudents(_class, section);
            cout << "Enter Roll Number: ";
            cin >> rollNumb;
            clearScreen();
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            infoDisplay(file, fileName, rollNumb, "", 2);
            return;
        }
        default:
            cout << "Option has exceeded the limit, Please try again";
            break;
        }
    }

    void viewMarks()
    {
        cout << "0. Assessment Marks\n1. Total Result Card\n";
        cout << "Option: ";
        int opt;
        cin >> opt;
        clearScreen();
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "You can only enter numbers.\n";
            cout << "0. Assessment Marks\n1. Total Result Card\n";
            cout << "Option: ";
            cin >> opt;
        }
        switch (opt)
        {
        case 0:
        {
            string file, tempData;
            folder = "Assessment Marks/";
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            fileName = _class + section;
            viewAllStudents(_class, section);
            cout << "Enter Roll Number: ";
            cin >> rollNumb;
            clearScreen();
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            infoDisplay(file, fileName, rollNumb, "", 2);
            return;
        }
        case 1:
        {
            string file, tempData;
            folder = "Marks/";
            cout << "Enter Class: ";
            cin >> _class;
            cout << "Enter Section: ";
            cin >> section;
            fileName = _class + section;
            viewAllStudents(_class, section);
            cout << "Enter Roll Number: ";
            cin >> rollNumb;
            clearScreen();
            inFile.open(filePath + folder + fileName + extension, ios::in);
            while (getline(inFile, tempData))
            {
                file += tempData + "\n";
            }
            inFile.close();
            infoDisplay(file, fileName, rollNumb, "", 2);
            return;
        }
        default:
            cout << "Option has exceeded the limit, Please try again";
            break;
        }
    }

protected:
    void viewAllStudents(string &_class, string &section)
    {
        cout << "\n___Students List___\n";
        string file, tempData, statement, statement2;
        folder = "Students/";
        fileName = _class + section;
        statement = "Roll Number: ", statement2 = "Name: ";
        inFile.open(filePath + folder + fileName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        infoDisplay(file, fileName, statement, "", 1);
        infoDisplay(file, fileName, statement2, "", 1);
    }

    string marksChecker(int &marks)
    {
        if (marks >= 95)
        {
            return "A+";
        }
        else if (marks >= 89 && marks <= 94)
        {
            return "A ";
        }
        else if (marks >= 85 && marks <= 88)
        {
            return "A-";
        }
        else if (marks >= 80 && marks <= 84)
        {
            return "B+";
        }
        else if (marks >= 75 && marks <= 79)
        {
            return "B ";
        }
        else if (marks >= 70 && marks <= 74)
        {
            return "B-";
        }
        else if (marks >= 65 && marks <= 69)
        {
            return "C+";
        }
        else if (marks >= 60 && marks <= 64)
        {
            return "C ";
        }
        else if (marks >= 55 && marks <= 59)
        {
            return "C-";
        }
        else if (marks >= 50 && marks <= 54)
        {
            return "D+";
        }
        else if (marks >= 45 && marks <= 49)
        {
            return "D ";
        }
        else if (marks >= 40 && marks <= 44)
        {
            return "D-";
        }
        else
        {
            return "F ";
        }
    }

private:
    virtual void store()
    {
        folder = "Students/";
        int i = 0;
        outFile.open(filePath + folder + arr[i]._class + arr[i].section + extension);
        for (i; i < studentSize; i++)
        {
            outFile << "\n$ Student_" << i << "\n";
            outFile << "Roll Number: " << arr[i]._class << "F" << arr[i].rollNumb << '\n'
                    << "Name: " << arr[i].firstName + " " + arr[i].lastName << '\n';
            outFile << "Class: " << arr[i]._class << '\n'
                    << "Email: " << arr[i].email << '\n'
                    << "Registration Date: "
                    << arr[i].registrationDate << '\n';
            outFile << "Gender: " << arr[i].gender << '\n'
                    << "Contact Number: " << arr[i].contactNumb << '\n'
                    << "Father_Name: " << arr[i].fatherName << '\n';
            outFile << "Father Profession: " << arr[i].fatherProfession << '\n'
                    << "Parent Contact: " << arr[i].parentContact << '\n'
                    << "Fee Submitted: "
                    << arr[i].feeSubmitted << '\n';
            outFile << "Blood Group: " << arr[i].bloodGroup << '\n'
                    << "Address: " << arr[i].address << '\n';
        }
        outFile << "\n#\n";
        outFile.close();
        cout << "\n[+] Congratulations! You're data has been stored\n";
    }
    void storeAssessmentMarks(string &name, string &rollNumb, string &fileName, string &type, int &marks, int &totalMarks, int &count, int &studentCount, int option)
    {
        folder = "Assessment Marks/";
        outFile.open(filePath + folder + fileName + extension, ios::app);
        switch (option)
        {
        case 0:
            outFile << "$ Student_" << studentCount << '\n';
            outFile << "Roll Number: " << rollNumb << '\n';
            outFile << "Name: " << name << '\n';
            break;
        case 1:
            outFile << type << count << " | "
                    << "Obtained Marks: " << marks << " "
                    << "Total Marks: " << totalMarks << '\n';
            break;
        }
        outFile.close();
    }
};

class Teacher : protected Students
{
protected:
    int teacherSize;
    string password, confirmPassword, qualification, DOB, salary, degree, CNIC;
    Teacher *teacherArr;

public:
    Teacher()
    {
        password = "", confirmPassword = "", qualification = "", DOB = "", salary = "", teacherSize = 0, CNIC = "";
    }
    void addTeacher()
    {
        cout << "Enter Number Of Teachers: ";
        cin >> teacherSize;
        teacherArr = new Teacher[teacherSize];
        for (int i = 0; i < teacherSize; i++)
        {
            cout << "Teacher_" << i << '\n';
            cout << "Enter First Name: ";
            cin >> teacherArr[i].firstName;
            cout << "Enter Last Name: ";
            cin >> teacherArr[i].lastName;
            cout << "Enter Email: ";
            cin >> teacherArr[i].email;
            cout << "Enter Joining Date: ";
            cin >> teacherArr[i].joiningDate;
            cout << "Enter Password: ";
            cin >> teacherArr[i].password;
        loop:
            cout << "Enter Confirm Password: ";
            cin >> teacherArr[i].confirmPassword;
            if (teacherArr[i].password.length() == teacherArr[i].confirmPassword.length())
            {
                for (int j = 0; j < teacherArr[i].password.length(); j++)
                {
                    if (teacherArr[i].password[j] != teacherArr[i].confirmPassword[j])
                    {
                        cout << "You're password doesn't match from the password given above, Please try again\n";
                        goto loop;
                    }
                }
            }
            else
            {
                goto loop;
            }
            cout << "Enter CNIC[Only Integers]: ";
            cin >> teacherArr[i].CNIC;
            cout << "Enter Gender: ";
            cin >> teacherArr[i].gender;
            cout << "Enter Qualification[Press '.' & Enter to end]: ";
            cin.ignore();
            getline(cin, teacherArr[i].qualification, '.');
            cout << "Enter Contact Number: ";
            cin >> teacherArr[i].contactNumb;
            cout << "Enter Date Of Birth: ";
            cin >> teacherArr[i].DOB;
            cout << "Enter Address[Press '.' & Enter to end]: ";
            cin.ignore();
            getline(cin, teacherArr[i].address, '.');
            cout << "Enter Salary: ";
            cin >> teacherArr[i].salary;
        }
        store();
    }

    void editTeacher()
    {
        folder = "Teachers/", fileName = "Teachers";
        int countCohesiveness = 0, opt, staticPosition = 0, start = 0, reset = 0;
        char dec;
        string file, tempData, statement;
        inFile.open(filePath + folder + "Teachers" + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
    loop:
        statement = "Name: ";
        viewAllTeachers(statement);
        cout << "Enter Name: ";
        cin >> firstName >> lastName;
        firstName = firstName + " " + lastName;
        for (int i = 0; i < file.length(); i++)
        {
            if (file[i] == firstName[start])
            {
                while (file[i] == firstName[start] && file[i] != '\n')
                {
                    ++countCohesiveness, ++i, ++start;
                    if (countCohesiveness >= (firstName.length()))
                        continue;
                }
            }
            else
            {
                countCohesiveness = reset, start = reset;
            }
            if (countCohesiveness >= (firstName.length()))
            {
                staticPosition = i;
                cout << "0. Address\n1. Contact Number\n2. Qualification\n3. Salary\n";
                cout << "Option: ";
                cin >> opt;
                clearScreen();
                while (cin.fail())
                {
                    clearScreen();
                    cin.clear();
                    cin.ignore(INT_MAX, '\n');
                    cout << "You can only enter numbers.\n";
                    cout << "0. Address\n1. Contact Number\n2. Qualification\n3. Salary\n";
                    cout << "Option: ";
                    cin >> opt;
                }
                switch (opt)
                {
                case 0:
                    cout << "Address[Press '.' & then enter to end]: ";
                    statement = "Address: ";
                    cin.ignore();
                    getline(cin, address, '.');
                    modifyInfo(folder, file, statement, address, fileName, 1, staticPosition);
                    break;
                case 1:
                    statement = "Contact Number: ";
                    cout << statement;
                    cin >> contactNumb;
                    modifyInfo(folder, file, statement, contactNumb, fileName, 0, staticPosition);
                    break;
                case 2:
                    statement = "Qualification: ";
                    cout << statement;
                    cin.ignore();
                    getline(cin, qualification, '.');
                    modifyInfo(folder, file, statement, qualification, fileName, 1, staticPosition);
                    break;
                case 3:
                    statement = "Salary: ";
                    cout << statement;
                    cin >> salary;
                    modifyInfo(folder, file, statement, salary, fileName, 0, staticPosition);
                    break;
                default:
                    cout << "Your input exceeded the number of options\n";
                }
            }
        }
    }
    void viewAllTeachers()
    {
        cout << "\n____Teachers____\n";
        string file, tempData, statement = "Name: ";
        folder = "Teachers/", fileName = "Teachers";
        inFile.open(filePath + folder + fileName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        infoDisplay(file, fileName, statement, "", 2);
    }

    void viewAssignedCoursesToTeacher()
    {
        folder = "Assigned Courses/";
        string tempData, file;
        cout << "Enter Name: ";
        cin >> firstName >> lastName;
        firstName = firstName + " " + lastName;
        cout << "\n___Assigned Courses To " << firstName << "____\n";
        inFile.open(filePath + folder + firstName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        string statement = "Name: ";
        infoDisplay(file, firstName, statement, "", 2);
    }

    void modifyStudentMarks()
    {
        int countCohesiveness = 0, opt, staticPosition = 0, start = 0, reset = 0, countCohesiveness2 = 0;
        char dec;
        cout << "Enter Teacher Name: ";
        cin >> firstName >> lastName;
        firstName = firstName + " " + lastName;
        viewAssignedCoursesToTeacher(firstName);
        cout << "Enter Class: ";
        cin >> _class;
        cout << "Enter Section: ";
        cin >> section;
        fileName = _class + section;
        cout << "Enter Course[Press '.' & and Enter to end]: ";
        cin.ignore();
        getline(cin, courseName, '.');
        string file, tempData, statement;
        viewAllStudents(_class, section);
        folder = "Marks/";
        inFile.open(filePath + folder + fileName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        cout << "Roll Number: ";
        cin >> rollNumb;
        cout << "Enter Marks: ";
        cin >> marks;
        for (int i = 0; i < file.length(); i++)
        {
            if (file[i] == rollNumb[start])
            {
                while (file[i] == rollNumb[start] && file[i] != '\n')
                {
                    ++countCohesiveness, ++i, ++start;
                    if (countCohesiveness >= (rollNumb.length()))
                        continue;
                }
            }
            else
            {
                countCohesiveness = reset, start = reset;
            }
            if (countCohesiveness >= (rollNumb.length()))
            {

                start = reset;
                if (file[i] != courseName[start])
                {
                    i = i + 1;
                    cout << file[i];
                    while (file[i] != courseName[start])
                    {
                        i = i + 1;
                        if (file[i] == courseName[start])
                        {
                            continue;
                        }
                    }
                }
                if (file[i] == courseName[start])
                {
                    while (file[i] == courseName[start] && file[i] != '\n')
                    {
                        ++countCohesiveness2, ++i, ++start;
                        if (countCohesiveness2 >= (courseName.length()))
                            continue;
                    }
                }
                else
                {
                    countCohesiveness2 = reset, start = reset;
                }
                if (countCohesiveness2 >= (courseName.length()))
                {
                    staticPosition = i;
                    studentGrade = marksChecker(marks);
                    string statement = "Marks: ";
                    stringstream ostr;
                    ostr << marks;
                    string content = ostr.str();
                    modifyInfo(folder, file, statement, content, fileName, 0, staticPosition);
                    statement = "Grade: ";
                    modifyInfo(folder,file,statement,studentGrade,fileName,1,staticPosition);
                    countCohesiveness2 = reset, start = reset;
                    return;
                }
            }
        }
    }

private:
    void viewAssignedCoursesToTeacher(string &name)
    {
        cout << "\n___Assigned Courses To " << name << "____\n";
        folder = "Assigned Courses/";
        string tempData, file;
        inFile.open(filePath + folder + name + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        string statement = "Name: ";
        infoDisplay(file, name, statement, "", 2);
    }
    void viewAllTeachers(string &statement)
    {
        cout << "\n____Teachers____\n";
        string file, tempData;
        folder = "Teachers/", fileName = "Teachers";
        inFile.open(filePath + folder + fileName + extension, ios::in);
        while (getline(inFile, tempData))
        {
            file += tempData + "\n";
        }
        inFile.close();
        infoDisplay(file, fileName, statement, "", 1);
    }
    virtual void store()
    {
        folder = "Teachers/";
        outFile.open(filePath + folder + "Teachers" + extension, ios::app);
        for (int i = 0; i < teacherSize; i++)
        {
            outFile << "\n$ Teacher_" << i << '\n';
            outFile << "Name: " << teacherArr[i].firstName + " " + teacherArr[i].lastName << '\n';
            outFile << "Email: " << teacherArr[i].email << '\n'
                    << "CNIC: " << teacherArr[i].CNIC << '\n'
                    << "Gender: " << teacherArr[i].gender << '\n'
                    << "Joining Date: " << teacherArr[i].joiningDate << '\n';
            outFile << "Qualification: " << teacherArr[i].qualification << '\n'
                    << "Contact Number: " << teacherArr[i].contactNumb << '\n';
            outFile << "Date Of Birth: " << teacherArr[i].DOB << '\n';
            outFile << "Address: " << teacherArr[i].address << '\n'
                    << "Salary: " << teacherArr[i].salary << '\n';
        }
        outFile << "\n#\n";
        outFile.close();
        cout << "\n[+] Congratulations! You're data has been stored";
    }
};

void studentMenu(Students &student)
{
    char dec;
    int opt;
loop:
    cout << "0. Add Student\n1. Edit Student\n2. Update Student Marks\n3. View Students\n4. Update Fee Status\n5. View Marks\n6. View Fee Status\n";
    cout << "Option: ";
    cin >> opt;
    clearScreen();
    while (cin.fail())
    {
        clearScreen();
        cin.clear();
        cin.ignore(INT_MAX, '\n');
        cout << "You can only enter numbers.\n";
        cout << "0. Add Student\n1. Edit Student\n2. Update Student Marks\n3. View Students\n4. Update Fee Status\n5. View Marks\n6. View Fee Status\n";
        cout << "Option: ";
        cin >> opt;
    }
    switch (opt)
    {
    case 0:
        student.addStudents();
        break;
    case 1:
        student.editStudent();
        break;
    case 2:
        student.updateStudentMarks();
        break;
    case 3:
        student.viewAllStudents();
        break;
    case 4:
        student.feeStatus();
        break;
    case 5:
        student.viewMarks();
        break;
    case 6:
        student.viewFeeStatus();
        break;
    default:
        cout << "Your input has exceeded the number of options\n";
        break;
    }
    cout << "Do you want to continue[Press 'y' || 'Y']?\n";
    cin >> dec;
    if (dec == 'y' || dec == 'Y')
    {
        goto loop;
    }
}

void teacherMenu(Teacher &teacher)
{
    char dec;
    int opt;
loop:
    cout << "0. Add Teacher\n1. Edit Teacher\n2. View All Teachers\n";
    cout << "Option: ";
    cin >> opt;
    clearScreen();
    while (cin.fail())
    {
        clearScreen();
        cin.clear();
        cin.ignore(INT_MAX, '\n');
        cout << "You can only enter numbers.\n";
        cout << "0. Add Teacher\n1. Edit Teacher\n2. View All Teachers\n";
        cout << "Option: ";
        cin >> opt;
    }
    switch (opt)
    {
    case 0:
        teacher.addTeacher();
        break;
    case 1:
        teacher.editTeacher();
        break;
    case 2:
        teacher.viewAllTeachers();
        break;
    default:
        cout << "Your input has exceeded the number of options\n";
    }
    cout << "Do you want to continue[Press 'y' || 'Y']?\n";
    cin >> dec;
    if (dec == 'y' || dec == 'Y')
    {
        goto loop;
    }
}

void coursesMenu(Courses courses)
{
    char dec;
    int opt;
loop:
    cout << "0. Add Courses\n1. View All Courses\n2. Assign Courses\n";
    cout << "Option: ";
    cin >> opt;
    clearScreen();
    while (cin.fail())
    {
        clearScreen();
        cin.clear();
        cin.ignore(INT_MAX, '\n');
        cout << "You can only enter numbers.\n";
        cout << "0. Add Courses\n1. View All Courses\n2. Assign Courses\n";
        cout << "Option: ";
        cin >> opt;
    }
    switch (opt)
    {
    case 0:
        courses.addCourse();
        break;
    case 1:
        courses.viewAllCourses();
        break;
    case 2:
        courses.assignCourse();
        break;
    default:
        cout << "Your input has exceeded the number of options\n";
    }
    cout << "Do you want to continue[Press 'y' || 'Y']?\n";
    cin >> dec;
    if (dec == 'y' || dec == 'Y')
    {
        goto loop;
    }
}

void TeachersModule(Teacher &teacher)
{
    int opt;
    cout << "0. Teachers Courses\n1. Modify Marks\n";
    cout << "Option: ";
    cin >> opt;
    clearScreen();
    while (cin.fail())
    {
        clearScreen();
        cin.clear();
        cin.ignore(INT_MAX, '\n');
        cout << "You can only enter numbers.\n";
        cout << "0. Teachers Courses\n1. Modify Marks\n";
        cout << "Option: ";
        cin >> opt;
    }
    switch (opt)
    {
    case 0:
    {
        teacher.viewAssignedCoursesToTeacher();
        break;
    }
    case 1:
    {
        teacher.modifyStudentMarks();
        break;
    }
    default:
        cout << "Your input has exceeded the number of options\n";
    }
}

int main()
{
    char dec;
    int opt;
loop:
    cout << "0. Administrator Module\n1. Teacher Module\n";
    cout << "Option: ";
    cin >> opt;
    clearScreen();
    while (cin.fail())
    {
        clearScreen();
        cin.clear();
        cin.ignore(INT_MAX, '\n');
        cout << "You can only enter numbers.\n";
        cout << "0. Administrator Module\n1. Teacher Module\n";
        cout << "Option: ";
        cin >> opt;
    }
    switch (opt)
    {
    case 0:
    {
        cout << "0. Students\n1. Teachers\n2. Courses\n";
        cout << "Option: ";
        cin >> opt;
        clearScreen();
        while (cin.fail())
        {
            clearScreen();
            cin.clear();
            cin.ignore(INT_MAX, '\n');
            cout << "You can only enter numbers.\n";
            cout << "0. Students\n1. Teachers\n2. Courses\n";
            cout << "Option: ";
            cin >> opt;
        }
        switch (opt)
        {
        case 0:
        {
            Students student;
            studentMenu(student);
            break;
        }
        case 1:
        {
            Teacher teacher;
            teacherMenu(teacher);
            break;
        }
        case 2:
        {
            Courses courses;
            coursesMenu(courses);
            break;
        }
        default:
            cout << "Your input has exceeded the number of options\n";
            break;
        }
    }
    break;
    case 1:
    {
        Teacher teacher;
        TeachersModule(teacher);
        break;
    }
    default:
        cout << "Your input has exceeded the number of options\n";
    }
    cout << "Do you want to continue[Press 'y' || 'Y']?\n";
    cin >> dec;
    if (dec == 'y' || dec == 'Y')
    {
        goto loop;
    }
}
