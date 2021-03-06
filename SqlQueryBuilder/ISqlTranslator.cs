﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SqlQueryBuilder
{
    public interface ISqlTranslator
    {
        bool HasError { get; }
        bool AddTable(Type type, string tableAlias);
        string GetFirstTranslation(Type type, Expression lambda, string tableAlias);
        IEnumerable<string> Translate(Type type, Expression lambda, string tableAlias);
        string Translate(Type type, string col, string tableAlias);
    }
}