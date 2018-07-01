﻿using System;
using System.Linq.Expressions;

namespace SqlQueryBuilder
{
    public interface IQueryBuilderOrderBy<T>: IBuild
    {
        IQueryBuilderOrderBy<T> OrderBy<U>(Expression<Func<U, object>> lambda, bool desc = false, string tableNameAs = null);
    }
}
