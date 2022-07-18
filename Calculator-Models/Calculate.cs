using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Models;
public class Calculate
{
    public double Left { get; set; }

    public double Right { get; set; }

    public string? Calculation { get; set; }
}

