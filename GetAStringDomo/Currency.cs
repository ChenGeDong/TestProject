using System;
using System.Collections.Generic;
using System.Text;

namespace GetAStringDomo
{
    /// <summary>
    /// 委托学习测试
    /// </summary>
    public struct Currency
    {
        public uint Dollars;
        public ushort Cents;
        public Currency(uint dollars,ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }
        public override string ToString() => $"${Dollars}.{Cents}";

        public static string GetCurrencyUnit() => "Dollar";

        /// <summary>
        /// explicit operator 显示类型转换
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        /// <summary>
        /// implicit operator 隐式类型转换
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator float(Currency value) => 
            value.Dollars + (value.Cents / 100.0f);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Currency(uint value)=> 
            new Currency(value,0);
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator uint(Currency value)=>
            value.Dollars;
        
    }
}
