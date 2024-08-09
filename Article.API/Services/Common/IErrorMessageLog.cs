﻿namespace Blog.API.Services.Common
{
    public interface IErrorMessageLog
    {
        bool LogError(string layerName, string className, string methodName, string msg);
    }
}
