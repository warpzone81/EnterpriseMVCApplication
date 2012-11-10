﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCAbstraction.Services.Exceptions
{
    /**
     * General Product manager Exception
     * */
    class ProductMgrException: Exception
    {
        public ProductMgrException(String s)
            : base(s)
        {

        }
    
    }
}
