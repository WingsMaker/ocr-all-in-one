﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Wrapper
{
    public interface IMappableToGenericResponse
    {
        string InputImage { get; set; }

        GenericOcrResponse Map();
    }
}
