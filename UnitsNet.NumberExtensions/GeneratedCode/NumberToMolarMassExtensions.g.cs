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

namespace UnitsNet.NumberExtensions.NumberToMolarMass
{
    /// <summary>
    /// A number to MolarMass Extensions
    /// </summary>
    public static class NumberToMolarMassExtensions
    {
        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)" />
        public static MolarMass CentigramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromCentigramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromCentigramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)" />
        public static MolarMass DecagramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromDecagramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromDecagramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)" />
        public static MolarMass DecigramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromDecigramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromDecigramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)" />
        public static MolarMass GramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromGramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromGramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)" />
        public static MolarMass HectogramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromHectogramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromHectogramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromKilogramsPerKilomole(double)" />
        public static MolarMass KilogramsPerKilomole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromKilogramsPerKilomole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromKilogramsPerKilomole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)" />
        public static MolarMass KilogramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromKilogramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromKilogramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)" />
        public static MolarMass KilopoundsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromKilopoundsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromKilopoundsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)" />
        public static MolarMass MegapoundsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromMegapoundsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromMegapoundsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)" />
        public static MolarMass MicrogramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromMicrogramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromMicrogramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)" />
        public static MolarMass MilligramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromMilligramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromMilligramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)" />
        public static MolarMass NanogramsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromNanogramsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromNanogramsPerMole(value.ToDouble(null));
#endif

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)" />
        public static MolarMass PoundsPerMole<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => MolarMass.FromPoundsPerMole(double.CreateChecked(value));
#else
            , IConvertible
            => MolarMass.FromPoundsPerMole(value.ToDouble(null));
#endif

    }
}
