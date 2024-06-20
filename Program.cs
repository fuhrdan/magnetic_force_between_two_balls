//*****************************************************************************
//** 1552. Magnetic Force Between Two Balls leetcode                         **
//**                                                                         **
//**                                                                         **
//**                                                                         **
//**                                                                         **
//*****************************************************************************

class Solution {
public:
    int maxDistance(vector<int>& position, int m) {
        sort(position.begin(), position.end());
        int left = 1, right = position[position.size() - 1];
        while (left < right) {
            int middle = (left + right + 1) >> 1;
            if (check(position, middle, m))
                left = middle;
            else
                right = middle - 1;
        }
        return left;
    }

    bool check(vector<int>& position, int f, int m) {
        int previous = position[0];
        int count = 1;
        for (int i = 1; i < position.size(); i++) {
            int current = position[i];
            if (current - previous >= f) {
                previous = current;
                count++;
            }
        }
        return count >= m;
    }
};