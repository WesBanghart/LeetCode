#include "Solution.h"
class Tree;
class Node;


int Solution::numDecodings(string s)
{
    Tree t;

    //Push each element of our string into a stack
    stack<int> num_stack;
    for (size_t i = 0; i < s.length(); i++)
    {
        num_stack.push(s[i] - 48);
    }

    //Build a Tree from the stack using my tree implementation
    
    t.build_tree(num_stack);

    //Retrieve the num of decodings from the tree
    return t.get_num_of_decodings();
}

class Tree {
private:
    Node* root;
    int numOfDecodings = 0;
public:
    void build_tree(stack<int> input);
    int get_num_of_decodings();
};


class Node {
public:
    stack<int> data;
    Node* left = nullptr;
    Node* right = nullptr;
    bool isLeaf;
    Node(stack<int> val)
    {
        data = val;        
    }
};

void Tree::build_tree(stack<int> input)
{
    //Create root element
    root = new Node(input);

    //Base case = stack is empty
    if(input.empty() || root->isLeaf)
    {
        return;
    }
    else{
        
        input.pop();
        root->left = new Node(input);

        //Left element
        if(input.top() == 0)
        {
            //Invalid element, make it a leaf
            root->left->isLeaf == true;
        }
        else{
            if (input.size() == 1)
            {
                numOfDecodings++;
            }
            build_tree(input);
        }
        //Right element
        

    }

    //Create root element
    root = new Node(input);
}

int Tree::get_num_of_decodings()
{
    return this->numOfDecodings;
}