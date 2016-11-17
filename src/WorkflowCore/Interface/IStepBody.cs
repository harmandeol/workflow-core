﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Models;

namespace WorkflowCore.Interface
{
    public interface IStepBody
    {        
        ExecutionResult Run(IStepExecutionContext context);
    }
}