﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCAbstraction.Services.Exceptions
{
    /**
    * Author: Kedrian James
    * Service Load Exception
    * Thrown when the application fails to
     * load a service
    * */
    class ServiceLoadException : Exception
    {
        public ServiceLoadException(String s)
            : base(s)
        {

        }
    }
}
