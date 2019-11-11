//
// Created by user3301 on 5/6/2019.
//
#include <vector>
#include <unordered_set>
#include <queue>
#include <sstream>
using namespace std;
class EscapeALargeMaze {
public:
    bool isEscapePossible(vector<vector<int>>& blocked, vector<int>& source, vector<int>& target) {
        if(blocked.size() == 0) return true;
        unordered_set<string> blockers;
        for (int i = 0;
             i < blocked.size(); ++i) {
            stringstream ss;
            ss<<blocked[i][0]<<","<<blocked[i][1];
            blockers.emplace(ss.str());
        }
        unordered_set<string> seen;
        return bfs(blockers, source, target, seen) && bfs(blockers, target, source, seen);
    }

private:
    bool bfs(unordered_set<string>& blockers, vector<int>& source, vector<int>& target, unordered_set<string>& seen) {
        if(target[0] < 0 || target[1]< 0 || target[0]>=1e6 || target[1]>= 1e6) return false;

        vector<vector<int>> dirs{{1,0},{0,1},{-1,0}, {0,-1}};

        queue<vector<int>> q;

        q.emplace(source);

        while(q.size()!=0) {
            int size = q.size();

            for (int i = 0;
                 i < size; ++i) {
                auto point = q.front();
                q.pop();
                if(point[0]==target[0] && point[1]==target[1]) return true;

                for(auto dir:dirs) {
                    int x = point[0] + dir[0];
                    int y = point[1] + dir[1];
                    stringstream ss;
                    ss<<x<<","<<y;
                    string str = ss.str();
                    if(x >=0 && x < 1e6 && y >=0 && y < 1e6 && blockers.find(str)==blockers.end() && seen.find(str)==seen.end()) {
                        if(target[0]==x && target[1] == y) return true;
                        vector<int> temp{x,y};
                        q.emplace(temp);
                        seen.emplace(str);
                        if(seen.size() >=2e4) return true;
                    }
                }
            }
        }
        return false;
    }
};
