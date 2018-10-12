using System;

namespace DesignPatterns.AbstractFactory
{
    public class Head
    {
        public static implicit operator Head(BlueRightLeg v)
        {
            throw new NotImplementedException();
        }
    }
}