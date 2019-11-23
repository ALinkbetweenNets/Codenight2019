#include <iostream>
#include <string>

int main(int argc, char** argv) {
    int encrypted = 81273;
    std::string plaintext = "SUPERSECRETKEY";
    std::cout << "Key: " << "0" <<  (encrypted - 11111) << std::endl;
}