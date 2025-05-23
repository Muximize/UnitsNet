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

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToMagneticField
{
    /// <summary>
    /// A number to MagneticField Extensions
    /// </summary>
    public static class NumberToMagneticFieldExtensions
    {
        /// <inheritdoc cref="MagneticField.FromGausses(double)" />
        public static MagneticField Gausses<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromGausses(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromGausses(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MagneticField.FromMicroteslas(double)" />
        public static MagneticField Microteslas<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromMicroteslas(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromMicroteslas(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MagneticField.FromMilligausses(double)" />
        public static MagneticField Milligausses<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromMilligausses(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromMilligausses(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MagneticField.FromMilliteslas(double)" />
        public static MagneticField Milliteslas<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromMilliteslas(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromMilliteslas(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MagneticField.FromNanoteslas(double)" />
        public static MagneticField Nanoteslas<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromNanoteslas(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromNanoteslas(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MagneticField.FromTeslas(double)" />
        public static MagneticField Teslas<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MagneticField.FromTeslas(double.CreateChecked(value));
#else
            , IConvertible
            => MagneticField.FromTeslas(value.ToDouble(null));
#endif

    }
}
