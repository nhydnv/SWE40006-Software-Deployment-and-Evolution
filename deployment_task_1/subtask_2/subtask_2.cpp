#include <iostream>

int main() {
    int mark;
    
    std::cout << "Enter a mark from 0 to 100: ";
    std::cin >> mark;

    while (std::cin.fail() || mark < 0 || mark > 100)
    {
        std::cin.clear();
        std::cin.ignore(1000, '\n');

        std::cout << "Invalid input. Enter a mark from 0 to 100: ";
        std::cin >> mark;
    }

    std::cout << "Grade: ";

    if (mark < 45) {
        std::cout << "Fail";
    }
    else if (mark < 50) {
        std::cout << "Conceded Pass";
    }
    else if (mark < 60) {
        std::cout << "Pass";
    }
    else if (mark < 70) {
        std::cout << "Credit";
    }
    else if (mark < 80) {
        std::cout << "Distinction";
    }
    else {
        std::cout << "High Distinction";
    }

    return 0;
}
