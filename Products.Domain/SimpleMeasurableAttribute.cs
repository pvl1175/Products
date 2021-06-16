using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Domain
{
    public enum UnitOfMeasurement
    {
        M1,
        M2,
        M3
    }

    public class SimpleMeasurableAttribute<TValue> : UserAttribute<TValue>
    {
        public UnitOfMeasurement Unit { get; set; }
    }
}
