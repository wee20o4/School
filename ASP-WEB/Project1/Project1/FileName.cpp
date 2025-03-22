#include <iostream>

int main() {
    std::string sentence = "I'm sleepy, I want to go to sleep.";
    int repeatCount = 1000;

    for (int i = 0; i < repeatCount; ++i) {
        std::cout << sentence << std::endl;
    }

    return 0;
}
