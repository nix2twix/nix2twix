#pragma once
#include <iostream>
#include <vector>
using namespace std;

/* SIZES IN BYTE (8 BIT) */

constexpr int FULL_KEY_BYTE_SIZE = 64;
constexpr int FULL_BLOCK_BYTE_SIZE = 16;
constexpr int SUBKEY_BYTE_SIZE = FULL_KEY_BYTE_SIZE / 8;
constexpr int BLOCK_BYTE_SIZE = FULL_BLOCK_BYTE_SIZE / 2;

/* SIZES IN BIT */

constexpr int FULL_KEY_BIT_SIZE = 512;
constexpr int FULL_BLOCK_BIT_SIZE = 128;
constexpr int SUBKEY_BIT_SIZE = FULL_KEY_BIT_SIZE / 8;
constexpr int BLOCK_BIT_SIZE = FULL_BLOCK_BIT_SIZE / 2;

const string KEY_PATH = "D:\\WORK\\NIX2TWIX\\CODE\\Magma\\key.txt";
const string DATA_PATH = "D:\\WORK\\NIX2TWIX\\CODE\\Magma\\input.txt";
const string OUTPUT_PATH = "D:\\WORK\\NIX2TWIX\\CODE\\Magma\\output.txt";

const vector<vector<int>> ReplacementTable = {
    {1, 7, 4, 9, 8, 15, 10, 3, 12, 5, 14, 13, 6, 0, 11, 2},
    {9, 14, 11, 0, 15, 6, 5, 10, 8, 12, 13, 2, 3, 1, 7, 4},
    {14, 13, 6, 5, 10, 2, 1, 7, 9, 4, 3, 12, 0, 11, 8, 15},
    {5, 2, 10, 15, 3, 9, 4, 13, 11, 1, 7, 8, 12, 6, 0, 14},
    {8, 12, 0, 11, 13, 4, 6, 15, 5, 14, 2, 1, 9, 7, 10, 3},
    {12, 11, 8, 2, 6, 14, 13, 1, 7, 10, 4, 0, 15, 3, 5, 9},
    {10, 4, 1, 6, 9, 12, 7, 14, 15, 8, 11, 5, 2, 13, 3, 0},
    {7, 3, 9, 4, 1, 0, 8, 6, 13, 15, 10, 14, 11, 2, 12, 5},
    {0, 5, 15, 14, 7, 8, 12, 9, 3, 6, 1, 10, 4, 11, 2, 13},
    {15, 6, 7, 12, 5, 10, 11, 0, 2, 9, 0, 4, 14, 8, 13, 1},
    {11, 8, 3, 13, 0, 5, 15, 2, 1, 7, 9, 3, 10, 14, 4, 6},
    {13, 10, 14, 8, 4, 11, 2, 12, 6, 3, 5, 7, 1, 9, 15, 0},
    {3, 9, 12, 10, 2, 13, 0, 11, 4, 15, 6, 9, 7, 5, 1, 8},
    {2, 0, 13, 1, 14, 7, 3, 4, 10, 11, 8, 15, 5, 12, 6, 7},
    {6, 15, 2, 7, 12, 1, 9, 8, 14, 13, 0, 6, 3, 10, 4, 11},
    {4, 1, 0, 3, 11, 6, 14, 5, 7, 2, 12, 9, 8, 15, 13, 10}
};