using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Exceptions
{
    /// <summary>
    /// EntityData의 Controllers에서 Type과 Controller가 같지 않을 때 던지는 예외
    /// </summary>
    public class InvalidEntityControllerException : Exception
    {
        public InvalidEntityControllerException() : base() { }

        public InvalidEntityControllerException(string message) : base(message) { }

        public InvalidEntityControllerException(string message, Exception innerException) : base(message, innerException) { }
    }
}
