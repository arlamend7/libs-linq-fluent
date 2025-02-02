﻿using Linq.Fluent.Funcs.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Fluent.Funcs
{
    public static partial class LinqConditionsExtension
    {
        #region Contains
        public static TResult Contains<T, TResult, TValue>(this ILinqFluentFuncBuilder<T, TResult> fluentLinq, TValue item)
           where T : IEnumerable<TValue>
        {
            return fluentLinq.Condition(x => x.Contains(item));
        }
        #endregion Contains
        #region Have
        public static TResult Have<T, TResult>(this ILinqFluentFuncBuilder<IQueryable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() == qt);
        }
        public static TResult Have<T, TResult>(this ILinqFluentFuncBuilder<List<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() == qt);
        }
        public static TResult Have<T, TResult>(this ILinqFluentFuncBuilder<IEnumerable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() == qt);
        }
        #endregion Have
        #region HaveLessThen
        public static TResult HaveLessThen<T, TResult>(this ILinqFluentFuncBuilder<IQueryable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() < qt);
        }
        public static TResult HaveLessThen<T, TResult>(this ILinqFluentFuncBuilder<List<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() < qt);
        }
        public static TResult HaveLessThen<T, TResult>(this ILinqFluentFuncBuilder<IEnumerable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() < qt);
        }
        #endregion HaveLessThen
        #region HaveMoreThen
        public static TResult HaveMoreThen<T, TResult>(this ILinqFluentFuncBuilder<IQueryable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() > qt);
        }
        public static TResult HaveMoreThen<T, TResult>(this ILinqFluentFuncBuilder<List<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() > qt);
        }
        public static TResult HaveMoreThen<T, TResult>(this ILinqFluentFuncBuilder<IEnumerable<T>, TResult> fluentLinq, int qt)
        {
            return fluentLinq.Condition(x => x.Count() > qt);
        }
        #endregion HaveMoreThen
        #region In
        public static TResult In<T, TResult>(this ILinqFluentFuncBuilder<T, TResult> fluentLinq, params T[] list)
            where T : struct
        {
            return fluentLinq.Condition(x => list.Contains(x));
        }
        public static TResult In<T, TResult>(this ILinqFluentFuncBuilder<T, TResult> fluentLinq, IEnumerable<T> list)
            where T : struct
        {
            return fluentLinq.Condition(x => list.Contains(x));
        }
        public static TResult In<TResult>(this ILinqFluentFuncBuilder<DateTime, TResult> fluentLinq, params DateTime[] list)
        {
            return fluentLinq.Condition(x => list.Contains(x));
        }
        public static TResult In<TResult>(this ILinqFluentFuncBuilder<DateTime?, TResult> fluentLinq, params DateTime?[] list)
        {
            return fluentLinq.Condition(x => list.Contains(x));
        }
        public static TResult In<TResult>(this ILinqFluentFuncBuilder<int?, TResult> fluentLinq, params int[] list)
        {
            return fluentLinq.Condition(x => x != null && list.Contains(x.Value));
        }
        public static TResult In<TResult>(this ILinqFluentFuncBuilder<long?, TResult> fluentLinq, params long[] list)
        {
            return fluentLinq.Condition(x => x != null && list.Contains(x.Value));
        }
        #endregion In
        #region IsBetween
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<DateTime, TResult> fluentLinq, DateTime de, DateTime ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<int, TResult> fluentLinq, int de, int ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<long, TResult> fluentLinq, long de, long ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<decimal, TResult> fluentLinq, decimal de, decimal ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }

        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<DateTime?, TResult> fluentLinq, DateTime de, DateTime ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<int?, TResult> fluentLinq, int de, int ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<long?, TResult> fluentLinq, long de, long ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        public static TResult IsBetween<TResult>(this ILinqFluentFuncBuilder<decimal?, TResult> fluentLinq, decimal de, decimal ate)
        {
            return fluentLinq.Condition(x => x >= de && x <= ate);
        }
        #endregion IsBetween
        #region IsBiggerThen
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<DateTime, TResult> fluentLinq, DateTime value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<int, TResult> fluentLinq, int value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<long, TResult> fluentLinq, long value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<decimal, TResult> fluentLinq, decimal value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<int?, TResult> fluentLinq, int value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<long?, TResult> fluentLinq, long value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        public static TResult IsBiggerThen<TResult>(this ILinqFluentFuncBuilder<decimal?, TResult> fluentLinq, decimal value)
        {
            return fluentLinq.Condition(x => x >= value);
        }
        #endregion IsBiggerThen
        #region IsEqual
        public static TResult IsEqual<T, TResult>(this ILinqFluentFuncBuilder<T, TResult> fluentLinq, T value)
        {
            T[] list = new T[1] { value };
            return fluentLinq.Condition(x => list.Contains(x));
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<DateTime, TResult> fluentLinq, DateTime value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<DateTime?, TResult> fluentLinq, DateTime value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<int, TResult> fluentLinq, int value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<long, TResult> fluentLinq, long value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<decimal, TResult> fluentLinq, decimal value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<int?, TResult> fluentLinq, int? value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<long?, TResult> fluentLinq, long? value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        public static TResult IsEqual<TResult>(this ILinqFluentFuncBuilder<decimal?, TResult> fluentLinq, decimal? value)
        {
            return fluentLinq.Condition(x => x == value);
        }
        #endregion IsEqual
        #region IsNullOrEmpty
        public static TResult IsNullOrEmpty<T, TResult>(this ILinqFluentFuncBuilder<IQueryable<T>, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == null || x.Any());
        }
        public static TResult IsNullOrEmpty<T, TResult>(this ILinqFluentFuncBuilder<List<T>, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == null || x.Any());
        }
        public static TResult IsNullOrEmpty<T, TResult>(this ILinqFluentFuncBuilder<IEnumerable<T>, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == null || x.Any());
        }
        #endregion IsNullOrEmpty
        #region IsSmallerThen
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<DateTime, TResult> fluentLinq, DateTime value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<int, TResult> fluentLinq, int value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<long, TResult> fluentLinq, long value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<decimal, TResult> fluentLinq, decimal value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<int?, TResult> fluentLinq, int value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<long?, TResult> fluentLinq, long value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        public static TResult IsSmallerThen<TResult>(this ILinqFluentFuncBuilder<decimal?, TResult> fluentLinq, decimal value)
        {
            return fluentLinq.Condition(x => x <= value);
        }
        #endregion IsSmallerThen
        #region Like
        public static TResult Like<T, TResult>(this ILinqFluentFuncBuilder<string, TResult> fluentLinq, T value)
        {
            return fluentLinq.Condition(x => x.ToString().Trim().ToUpper().Contains(value.ToString().Trim().ToUpper()));
        }
        public static TResult Like<T, TResult, TValue>(this ILinqFluentFuncBuilder<T, TResult> fluentLinq, TValue value)
            where T : struct
        {
            return fluentLinq.Condition(x => x.ToString().Contains(value.ToString()));
        }
        public static TResult Like<T, TResult, TValue>(this ILinqFluentFuncBuilder<Nullable<T>, TResult> fluentLinq, TValue value)
           where T : struct
        {
            return fluentLinq.Condition(x => x != null && x.Value.ToString().Contains(value.ToString()));
        }
        #endregion Like
        public static TResult IsNotNull<T, TResult>(this ILinqFluentFuncBuilder<T, TResult> expression)
        {
            return expression.Condition(x => x != null);
        }
        public static TResult IsNull<T, TResult>(this ILinqFluentFuncBuilder<T, TResult> expression)
        {
            return expression.Condition(x => x == null);
        }
        public static TResult IsTrue<TResult>(this ILinqFluentFuncBuilder<bool?, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == true);
        }
        public static TResult IsFalse<TResult>(this ILinqFluentFuncBuilder<bool?, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == false);
        }
        public static TResult IsTrue<TResult>(this ILinqFluentFuncBuilder<bool, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == true);
        }
        public static TResult IsFalse<TResult>(this ILinqFluentFuncBuilder<bool, TResult> fluentLinq)
        {
            return fluentLinq.Condition(x => x == false);
        }
    }
}
