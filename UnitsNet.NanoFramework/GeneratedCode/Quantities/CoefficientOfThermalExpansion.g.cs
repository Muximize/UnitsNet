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
    ///     A unit that represents a fractional change in size in response to a change in temperature.
    /// </summary>
    public struct  CoefficientOfThermalExpansion
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly CoefficientOfThermalExpansionUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public CoefficientOfThermalExpansionUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of CoefficientOfThermalExpansion, which is Second. All conversions go via this value.
        /// </summary>
        public static CoefficientOfThermalExpansionUnit BaseUnit { get; } = CoefficientOfThermalExpansionUnit.PerKelvin;

        /// <summary>
        /// Represents the largest possible value of CoefficientOfThermalExpansion.
        /// </summary>
        public static CoefficientOfThermalExpansion MaxValue { get; } = new CoefficientOfThermalExpansion(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of CoefficientOfThermalExpansion.
        /// </summary>
        public static CoefficientOfThermalExpansion MinValue { get; } = new CoefficientOfThermalExpansion(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static CoefficientOfThermalExpansion Zero { get; } = new CoefficientOfThermalExpansion(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PerDegreeCelsius"/>
        /// </summary>
        public double PerDegreeCelsius => As(CoefficientOfThermalExpansionUnit.PerDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit"/>
        /// </summary>
        public double PerDegreeFahrenheit => As(CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PerKelvin"/>
        /// </summary>
        public double PerKelvin => As(CoefficientOfThermalExpansionUnit.PerKelvin);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius"/>
        /// </summary>
        public double PpmPerDegreeCelsius => As(CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit"/>
        /// </summary>
        public double PpmPerDegreeFahrenheit => As(CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="CoefficientOfThermalExpansionUnit.PpmPerKelvin"/>
        /// </summary>
        public double PpmPerKelvin => As(CoefficientOfThermalExpansionUnit.PpmPerKelvin);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PerDegreeCelsius"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPerDegreeCelsius(double perdegreecelsius) => new CoefficientOfThermalExpansion(perdegreecelsius, CoefficientOfThermalExpansionUnit.PerDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPerDegreeFahrenheit(double perdegreefahrenheit) => new CoefficientOfThermalExpansion(perdegreefahrenheit, CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PerKelvin"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPerKelvin(double perkelvin) => new CoefficientOfThermalExpansion(perkelvin, CoefficientOfThermalExpansionUnit.PerKelvin);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPpmPerDegreeCelsius(double ppmperdegreecelsius) => new CoefficientOfThermalExpansion(ppmperdegreecelsius, CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPpmPerDegreeFahrenheit(double ppmperdegreefahrenheit) => new CoefficientOfThermalExpansion(ppmperdegreefahrenheit, CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit);

        /// <summary>
        ///     Creates a <see cref="CoefficientOfThermalExpansion"/> from <see cref="CoefficientOfThermalExpansionUnit.PpmPerKelvin"/>.
        /// </summary>
        public static CoefficientOfThermalExpansion FromPpmPerKelvin(double ppmperkelvin) => new CoefficientOfThermalExpansion(ppmperkelvin, CoefficientOfThermalExpansionUnit.PpmPerKelvin);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="CoefficientOfThermalExpansionUnit" /> to <see cref="CoefficientOfThermalExpansion" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>CoefficientOfThermalExpansion unit value.</returns>
        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit fromUnit)
        {
            return new CoefficientOfThermalExpansion(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(CoefficientOfThermalExpansionUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this CoefficientOfThermalExpansion to another CoefficientOfThermalExpansion with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A CoefficientOfThermalExpansion with the specified unit.</returns>
                public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new CoefficientOfThermalExpansion(convertedValue, unit);
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
                        CoefficientOfThermalExpansionUnit.PerDegreeCelsius => _value,
                        CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit => _value * 9 / 5,
                        CoefficientOfThermalExpansionUnit.PerKelvin => _value,
                        CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius => _value / 1e6,
                        CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit => _value * 9 / 5e6,
                        CoefficientOfThermalExpansionUnit.PpmPerKelvin => _value / 1e6,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(CoefficientOfThermalExpansionUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        CoefficientOfThermalExpansionUnit.PerDegreeCelsius => baseUnitValue,
                        CoefficientOfThermalExpansionUnit.PerDegreeFahrenheit => baseUnitValue * 5 / 9,
                        CoefficientOfThermalExpansionUnit.PerKelvin => baseUnitValue,
                        CoefficientOfThermalExpansionUnit.PpmPerDegreeCelsius => baseUnitValue * 1e6,
                        CoefficientOfThermalExpansionUnit.PpmPerDegreeFahrenheit => baseUnitValue * 5e6 / 9,
                        CoefficientOfThermalExpansionUnit.PpmPerKelvin => baseUnitValue * 1e6,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

