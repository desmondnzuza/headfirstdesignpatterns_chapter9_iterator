using System;

namespace MenuTestDrive.Iterators
{
    interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
