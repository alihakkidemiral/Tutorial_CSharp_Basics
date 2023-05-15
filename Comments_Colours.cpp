// this is my comments style example
// for todotree and bettercomment extensions combination
// for vscode. i see them colored and if i mark any line like "// Todo"
// i can see it in a list on todotree tree menu.

#include <iostream>
#include <limits>

using namespace std;

int main()
{
    // Extension: Todo Tree (Gruntfuggly)
    // Extension: Better Comments (Aaron Bond)

    // Simple comment
    // * Highlight comment
    // ! Alert comment
    // ? Question mark

    /*
    Simple multiline comment
    * Highlight comment
    ? Question mark
    ! Alert comment
    */

    /**
     * Simple multiline comment
     * * Highlight comment
     * ? Question mark
     * ! Alert comment
    */

    // Todo
    // Bug
    // Mark
    // Check
    // Done

    // [ ] todo: some entry
    // [x] Done: We already have done that
    // - [ ] todo: some list entry
    // ! [ ] BUG: important things
    // ? [ ] MARK: still todo?
    // ? [x] CHECK: should be fixed but check once more
    // - [x] DONE: We already have done that

    // TODO multiline example
    //  second line
    //  third line

    cin.clear();
    cin.ignore(numeric_limits<streamsize>::max(), '\n');
    cin.get();
}