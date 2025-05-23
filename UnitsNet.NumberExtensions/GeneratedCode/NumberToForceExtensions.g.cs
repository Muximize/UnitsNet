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

namespace UnitsNet.NumberExtensions.NumberToForce
{
    /// <summary>
    /// A number to Force Extensions
    /// </summary>
    public static class NumberToForceExtensions
    {
        /// <inheritdoc cref="Force.FromDecanewtons(double)" />
        public static Force Decanewtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromDecanewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromDecanewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromDyne(double)" />
        public static Force Dyne<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromDyne(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromDyne(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromKilogramsForce(double)" />
        public static Force KilogramsForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromKilogramsForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromKilogramsForce(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromKilonewtons(double)" />
        public static Force Kilonewtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromKilonewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromKilonewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromKiloPonds(double)" />
        public static Force KiloPonds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromKiloPonds(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromKiloPonds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromKilopoundsForce(double)" />
        public static Force KilopoundsForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromKilopoundsForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromKilopoundsForce(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromMeganewtons(double)" />
        public static Force Meganewtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromMeganewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromMeganewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromMicronewtons(double)" />
        public static Force Micronewtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromMicronewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromMicronewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromMillinewtons(double)" />
        public static Force Millinewtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromMillinewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromMillinewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromNewtons(double)" />
        public static Force Newtons<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromNewtons(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromNewtons(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromOunceForce(double)" />
        public static Force OunceForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromOunceForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromOunceForce(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromPoundals(double)" />
        public static Force Poundals<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromPoundals(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromPoundals(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromPoundsForce(double)" />
        public static Force PoundsForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromPoundsForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromPoundsForce(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromShortTonsForce(double)" />
        public static Force ShortTonsForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromShortTonsForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromShortTonsForce(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Force.FromTonnesForce(double)" />
        public static Force TonnesForce<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Force.FromTonnesForce(double.CreateChecked(value));
#else
            , IConvertible
            => Force.FromTonnesForce(value.ToDouble(null));
#endif

    }
}
