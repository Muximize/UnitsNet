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
    ///     Molality is a measure of the amount of solute in a solution relative to a given mass of solvent.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molality
    /// </remarks>
    public struct  Molality
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolalityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolalityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Molality(double value, MolalityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Molality, which is Second. All conversions go via this value.
        /// </summary>
        public static MolalityUnit BaseUnit { get; } = MolalityUnit.MolePerKilogram;

        /// <summary>
        /// Represents the largest possible value of Molality.
        /// </summary>
        public static Molality MaxValue { get; } = new Molality(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Molality.
        /// </summary>
        public static Molality MinValue { get; } = new Molality(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Molality Zero { get; } = new Molality(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolalityUnit.MolePerGram"/>
        /// </summary>
        public double MolesPerGram => As(MolalityUnit.MolePerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolalityUnit.MolePerKilogram"/>
        /// </summary>
        public double MolesPerKilogram => As(MolalityUnit.MolePerKilogram);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Molality"/> from <see cref="MolalityUnit.MolePerGram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molality FromMolesPerGram(double molespergram) => new Molality(molespergram, MolalityUnit.MolePerGram);

        /// <summary>
        ///     Creates a <see cref="Molality"/> from <see cref="MolalityUnit.MolePerKilogram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molality FromMolesPerKilogram(double molesperkilogram) => new Molality(molesperkilogram, MolalityUnit.MolePerKilogram);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolalityUnit" /> to <see cref="Molality" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molality unit value.</returns>
        public static Molality From(double value, MolalityUnit fromUnit)
        {
            return new Molality(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MolalityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Molality to another Molality with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Molality with the specified unit.</returns>
                public Molality ToUnit(MolalityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Molality(convertedValue, unit);
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
                        MolalityUnit.MolePerGram => _value / 1e-3,
                        MolalityUnit.MolePerKilogram => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MolalityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MolalityUnit.MolePerGram => baseUnitValue * 1e-3,
                        MolalityUnit.MolePerKilogram => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

