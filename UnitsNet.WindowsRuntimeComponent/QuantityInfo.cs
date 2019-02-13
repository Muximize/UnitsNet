﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Information about the quantity, such as names, unit values and zero quantity.
    ///     This is useful to enumerate units and present names with quantities and units
    ///     chose dynamically at runtime, such as unit conversion apps or allowing the user to change the
    ///     unit representation.
    /// </summary>
    /// <remarks>
    ///     Typically you obtain this by looking it up via quantities, like <see cref="Length.Info" /> or <see cref="Length.QuantityInfo"/>.
    /// </remarks>
    internal class QuantityInfo
    {
        private static readonly string UnitEnumNamespace = typeof(LengthUnit).Namespace;

        private static readonly Type[] UnitEnumTypes = typeof(Length)
            .Wrap()
            .Assembly
            .GetExportedTypes()
            .Where(t => t.Wrap().IsEnum && t.Namespace == UnitEnumNamespace && t.Name.EndsWith("Unit"))
            .ToArray();

        public QuantityInfo(QuantityType quantityType, [NotNull] Enum[] units, [NotNull] Enum baseUnit, [NotNull] IQuantity zero, [NotNull] BaseDimensions baseDimensions)
        {
            if(quantityType == QuantityType.Undefined) throw new ArgumentException("Quantity type can not be undefined.", nameof(quantityType));
            if(units == null) throw new ArgumentNullException(nameof(units));
            if(baseUnit == null) throw new ArgumentNullException(nameof(baseUnit));
            if(zero == null) throw new ArgumentNullException(nameof(zero));
            if(baseDimensions == null) throw new ArgumentNullException(nameof(baseDimensions));

            Name = quantityType.ToString();
            QuantityType = quantityType;
            UnitType = UnitEnumTypes.First(t => t.Name == $"{quantityType}Unit");
            UnitInfos = units.Select(unit => new UnitInfo(unit)).ToArray();
            UnitNames = UnitInfos.Select(unitInfo => unitInfo.Name).ToArray();
            Units = units;
            BaseUnitInfo = new UnitInfo(baseUnit);
            BaseUnit = BaseUnitInfo.Value;
            Zero = zero;
            ValueType = zero.GetType();
            BaseDimensions = baseDimensions;
        }

        /// <summary>
        ///     Quantity name, such as "Length" or "Mass".
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Quantity type, such as <see cref="UnitsNet.QuantityType.Length" /> or <see cref="UnitsNet.QuantityType.Mass" />.
        /// </summary>
        public QuantityType QuantityType { get; }

        public UnitInfo[] UnitInfos { get; }

        /// <summary>
        ///     All unit names for the quantity, such as ["Centimeter", "Decimeter", "Meter", ...].
        /// </summary>
        [Obsolete("This property is deprecated and will be removed at a future release. Please use the UnitInfos property.")]
        public string[] UnitNames { get; }

        /// <summary>
        ///     All unit enum values for the quantity, such as [<see cref="LengthUnit.Centimeter" />,
        ///     <see cref="LengthUnit.Decimeter" />, <see cref="LengthUnit.Meter" />, ...].
        /// </summary>
        [Obsolete("This property is deprecated and will be removed at a future release. Please use the UnitInfos property.")]
        public Enum[] Units { get; }

        public UnitInfo BaseUnitInfo { get; }

        /// <summary>
        ///     The base unit for the quantity, such as <see cref="LengthUnit.Meter" />.
        /// </summary>
        [Obsolete("This property is deprecated and will be removed at a future release. Please use the BaseUnitInfo property.")]
        public Enum BaseUnit { get; }

        /// <summary>
        ///     Zero value of quantity, such as <see cref="Length.Zero" />.
        /// </summary>
        public IQuantity Zero { get; }

        /// <summary>
        ///     Unit enum type, such as <see cref="LengthUnit"/> or <see cref="MassUnit"/>.
        /// </summary>
        public Type UnitType { get; }

        /// <summary>
        ///     Quantity value type, such as <see cref="Length"/> or <see cref="Mass"/>.
        /// </summary>
        public Type ValueType { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> for a quantity.
        /// </summary>
        public BaseDimensions BaseDimensions { get; }
    }
}
