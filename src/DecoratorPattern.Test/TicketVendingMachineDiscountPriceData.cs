using System;
using System.Collections;
using System.Collections.Generic;

namespace DesingPatterns.Test.Decorator;

internal class TicketVendingMachineDiscountPriceData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 0, 0, new DateTime(2022, 3, 28) };
        yield return new object[] { 1, 0, new DateTime(2022, 3, 28) };
        yield return new object[] { 2, 0, new DateTime(2022, 3, 28) };
        yield return new object[] { 3, 0, new DateTime(2022, 3, 28) };
        yield return new object[] { 4, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 5, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 6, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 7, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 8, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 9, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 10, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 11, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 12, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 13, 12, new DateTime(2022, 3, 28) };
        yield return new object[] { 14, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 15, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 16, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 17, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 18, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 19, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 20, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 21, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 22, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 23, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 24, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 25, 15, new DateTime(2022, 3, 28) };
        yield return new object[] { 26, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 27, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 28, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 29, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 30, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 31, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 32, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 33, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 34, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 35, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 36, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 37, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 38, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 39, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 40, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 41, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 42, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 43, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 44, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 45, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 46, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 47, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 48, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 49, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 50, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 51, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 52, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 53, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 54, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 55, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 56, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 57, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 58, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 59, 20, new DateTime(2022, 3, 28) };
        yield return new object[] { 60, 12, new DateTime(2022, 4, 2) };
        yield return new object[] { 61, 12, new DateTime(2022, 4, 3) };
        yield return new object[] { 62, 15, new DateTime(2022, 4, 5) };
        yield return new object[] { 63, 15, new DateTime(2022, 4, 6) };
        yield return new object[] { 64, 15, new DateTime(2022, 4, 7) };
        yield return new object[] { 65, 15, new DateTime(2022, 4, 8) };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
