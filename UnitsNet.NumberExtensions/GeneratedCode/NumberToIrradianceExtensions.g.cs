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

namespace UnitsNet.NumberExtensions.NumberToIrradiance
{
    /// <summary>
    /// A number to Irradiance Extensions
    /// </summary>
    public static class NumberToIrradianceExtensions
    {
        /// <inheritdoc cref="Irradiance.FromKilowattsPerSquareCentimeter(double)" />
        public static Irradiance KilowattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromKilowattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromKilowattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromKilowattsPerSquareMeter(double)" />
        public static Irradiance KilowattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromKilowattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromKilowattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMegawattsPerSquareCentimeter(double)" />
        public static Irradiance MegawattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMegawattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMegawattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMegawattsPerSquareMeter(double)" />
        public static Irradiance MegawattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMegawattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMegawattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMicrowattsPerSquareCentimeter(double)" />
        public static Irradiance MicrowattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMicrowattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMicrowattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMicrowattsPerSquareMeter(double)" />
        public static Irradiance MicrowattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMicrowattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMicrowattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMilliwattsPerSquareCentimeter(double)" />
        public static Irradiance MilliwattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMilliwattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMilliwattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromMilliwattsPerSquareMeter(double)" />
        public static Irradiance MilliwattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromMilliwattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromMilliwattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromNanowattsPerSquareCentimeter(double)" />
        public static Irradiance NanowattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromNanowattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromNanowattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromNanowattsPerSquareMeter(double)" />
        public static Irradiance NanowattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromNanowattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromNanowattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromPicowattsPerSquareCentimeter(double)" />
        public static Irradiance PicowattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromPicowattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromPicowattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromPicowattsPerSquareMeter(double)" />
        public static Irradiance PicowattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromPicowattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromPicowattsPerSquareMeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromWattsPerSquareCentimeter(double)" />
        public static Irradiance WattsPerSquareCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromWattsPerSquareCentimeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromWattsPerSquareCentimeter(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Irradiance.FromWattsPerSquareMeter(double)" />
        public static Irradiance WattsPerSquareMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Irradiance.FromWattsPerSquareMeter(double.CreateChecked(value));
#else
            , IConvertible
            => Irradiance.FromWattsPerSquareMeter(value.ToDouble(null));
#endif

    }
}
