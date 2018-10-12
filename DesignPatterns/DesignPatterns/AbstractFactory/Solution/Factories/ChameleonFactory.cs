using System;

namespace DesignPatterns.AbstractFactory.Solution
{
    public abstract class ChameleonFactory
    {
        public abstract Leg ConstructRightLeg();
        public abstract Leg ConstructLeftLeg();
        public abstract Body ConstructBody();
        public abstract Head ConstructHead();
    }
}