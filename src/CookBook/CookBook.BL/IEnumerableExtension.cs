﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CookBook.BL;

public static class IEnumerableExtension
{
    public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> values)
        => new (values);
}