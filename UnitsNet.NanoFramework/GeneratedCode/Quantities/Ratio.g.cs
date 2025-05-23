//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In mathematics, a ratio is a relationship between two numbers of the same kind (e.g., objects, persons, students, spoonfuls, units of whatever identical dimension), usually expressed as "a to b" or a:b, sometimes expressed arithmetically as a dimensionless quotient of the two that explicitly indicates how many times the first number contains the second (not necessarily an integer).
    /// </summary>
    public struct  Ratio
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RatioUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RatioUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Ratio(double value, RatioUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Ratio, which is Second. All conversions go via this value.
        /// </summary>
        public static RatioUnit BaseUnit { get; } = RatioUnit.DecimalFraction;

        /// <summary>
        /// Represents the largest possible value of Ratio.
        /// </summary>
        public static Ratio MaxValue { get; } = new Ratio(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Ratio.
        /// </summary>
        public static Ratio MinValue { get; } = new Ratio(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Ratio Zero { get; } = new Ratio(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.DecimalFraction"/>
        /// </summary>
        public double DecimalFractions => As(RatioUnit.DecimalFraction);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.PartPerBillion"/>
        /// </summary>
        public double PartsPerBillion => As(RatioUnit.PartPerBillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.PartPerMillion"/>
        /// </summary>
        public double PartsPerMillion => As(RatioUnit.PartPerMillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.PartPerThousand"/>
        /// </summary>
        public double PartsPerThousand => As(RatioUnit.PartPerThousand);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.PartPerTrillion"/>
        /// </summary>
        public double PartsPerTrillion => As(RatioUnit.PartPerTrillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioUnit.Percent"/>
        /// </summary>
        public double Percent => As(RatioUnit.Percent);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.DecimalFraction"/>.
        /// </summary>
        public static Ratio FromDecimalFractions(double decimalfractions) => new Ratio(decimalfractions, RatioUnit.DecimalFraction);

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.PartPerBillion"/>.
        /// </summary>
        public static Ratio FromPartsPerBillion(double partsperbillion) => new Ratio(partsperbillion, RatioUnit.PartPerBillion);

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.PartPerMillion"/>.
        /// </summary>
        public static Ratio FromPartsPerMillion(double partspermillion) => new Ratio(partspermillion, RatioUnit.PartPerMillion);

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.PartPerThousand"/>.
        /// </summary>
        public static Ratio FromPartsPerThousand(double partsperthousand) => new Ratio(partsperthousand, RatioUnit.PartPerThousand);

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.PartPerTrillion"/>.
        /// </summary>
        public static Ratio FromPartsPerTrillion(double partspertrillion) => new Ratio(partspertrillion, RatioUnit.PartPerTrillion);

        /// <summary>
        ///     Creates a <see cref="Ratio"/> from <see cref="RatioUnit.Percent"/>.
        /// </summary>
        public static Ratio FromPercent(double percent) => new Ratio(percent, RatioUnit.Percent);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RatioUnit" /> to <see cref="Ratio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Ratio unit value.</returns>
        public static Ratio From(double value, RatioUnit fromUnit)
        {
            return new Ratio(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(RatioUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Ratio to another Ratio with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Ratio with the specified unit.</returns>
                public Ratio ToUnit(RatioUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Ratio(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        RatioUnit.DecimalFraction => _value,
                        RatioUnit.PartPerBillion => _value / 1e9,
                        RatioUnit.PartPerMillion => _value / 1e6,
                        RatioUnit.PartPerThousand => _value / 1e3,
                        RatioUnit.PartPerTrillion => _value / 1e12,
                        RatioUnit.Percent => _value / 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(RatioUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        RatioUnit.DecimalFraction => baseUnitValue,
                        RatioUnit.PartPerBillion => baseUnitValue * 1e9,
                        RatioUnit.PartPerMillion => baseUnitValue * 1e6,
                        RatioUnit.PartPerThousand => baseUnitValue * 1e3,
                        RatioUnit.PartPerTrillion => baseUnitValue * 1e12,
                        RatioUnit.Percent => baseUnitValue * 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

