﻿using System;
using System.Runtime.Serialization;

namespace ZhonTai.Admin.Core.Exceptions;

/// <summary>
/// 系统异常
/// </summary>
public class AppException : Exception
{
    public AppException()
    {
    }

    public AppException(SerializationInfo serializationInfo, StreamingContext context)
        : base(serializationInfo, context)
    {
    }

    public AppException(string message)
        : base(message)
    {
    }


    public AppException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
    