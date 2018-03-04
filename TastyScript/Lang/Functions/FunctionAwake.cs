﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyScript.Lang.Extensions;
using TastyScript.Lang.Token;

namespace TastyScript.Lang.Functions
{
    [Function("Awake", FunctionObsolete: true)]
    internal class FunctionAwake : FDefinition<object>
    {
        public override void TryParse(TParameter args, IBaseFunction caller, string lineval = "{0}")
        {
        }
        public override object CallBase(TParameter args)
        {
            Compiler.ExceptionListener.Throw(new ExceptionHandler(ExceptionType.CompilerException, $"{this.Name} can only be called by internal functions.", LineValue));
            return null;
        }
        protected override void ForExtension(TParameter args, ExtensionFor findFor, string lineval)
        {
            Compiler.ExceptionListener.Throw(new ExceptionHandler(ExceptionType.CompilerException, $"Cannot call 'For' on {this.Name}.", LineValue));
        }
    }
}