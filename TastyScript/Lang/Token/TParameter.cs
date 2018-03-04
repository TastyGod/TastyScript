﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyScript.Lang.Tokens;

namespace TastyScript.Lang.TokenOLD
{
    [Serializable]
    internal class TParameter : Token<List<IBaseToken>>
    {
        protected override string _name { get; set; }
        protected override BaseValue<List<IBaseToken>> _value { get; set; }
        public TParameter(string name, List<IBaseToken> value)
        {
            _name = name;
            _value = new BaseValue<List<IBaseToken>>(value);
        }
        public override string ToString()
        {
            var str = "[" + String.Join(",",_value.Value);
            
            return str += "]";
        }
    }
}
