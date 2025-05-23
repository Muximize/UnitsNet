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

namespace UnitsNet.NumberExtensions.NumberToInformation
{
    /// <summary>
    /// A number to Information Extensions
    /// </summary>
    public static class NumberToInformationExtensions
    {
        /// <inheritdoc cref="Information.FromBits(double)" />
        public static Information Bits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromBits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromBits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromBytes(double)" />
        public static Information Bytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromBytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromBytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExabits(double)" />
        public static Information Exabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExabits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExabits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExabytes(double)" />
        public static Information Exabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExabytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExabytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExaoctets(double)" />
        public static Information Exaoctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExaoctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExaoctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExbibits(double)" />
        public static Information Exbibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExbibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExbibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExbibytes(double)" />
        public static Information Exbibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExbibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExbibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromExbioctets(double)" />
        public static Information Exbioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromExbioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromExbioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGibibits(double)" />
        public static Information Gibibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGibibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGibibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGibibytes(double)" />
        public static Information Gibibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGibibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGibibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGibioctets(double)" />
        public static Information Gibioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGibioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGibioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGigabits(double)" />
        public static Information Gigabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGigabits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGigabits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGigabytes(double)" />
        public static Information Gigabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGigabytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGigabytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromGigaoctets(double)" />
        public static Information Gigaoctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromGigaoctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromGigaoctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKibibits(double)" />
        public static Information Kibibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKibibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKibibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKibibytes(double)" />
        public static Information Kibibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKibibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKibibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKibioctets(double)" />
        public static Information Kibioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKibioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKibioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKilobits(double)" />
        public static Information Kilobits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKilobits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKilobits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKilobytes(double)" />
        public static Information Kilobytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKilobytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKilobytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromKilooctets(double)" />
        public static Information Kilooctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromKilooctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromKilooctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMebibits(double)" />
        public static Information Mebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMebibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMebibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMebibytes(double)" />
        public static Information Mebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMebibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMebibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMebioctets(double)" />
        public static Information Mebioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMebioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMebioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMegabits(double)" />
        public static Information Megabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMegabits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMegabits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMegabytes(double)" />
        public static Information Megabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMegabytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMegabytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromMegaoctets(double)" />
        public static Information Megaoctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromMegaoctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromMegaoctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromOctets(double)" />
        public static Information Octets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromOctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromOctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPebibits(double)" />
        public static Information Pebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPebibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPebibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPebibytes(double)" />
        public static Information Pebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPebibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPebibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPebioctets(double)" />
        public static Information Pebioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPebioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPebioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPetabits(double)" />
        public static Information Petabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPetabits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPetabits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPetabytes(double)" />
        public static Information Petabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPetabytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPetabytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromPetaoctets(double)" />
        public static Information Petaoctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromPetaoctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromPetaoctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTebibits(double)" />
        public static Information Tebibits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTebibits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTebibits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTebibytes(double)" />
        public static Information Tebibytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTebibytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTebibytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTebioctets(double)" />
        public static Information Tebioctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTebioctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTebioctets(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTerabits(double)" />
        public static Information Terabits<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTerabits(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTerabits(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTerabytes(double)" />
        public static Information Terabytes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTerabytes(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTerabytes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Information.FromTeraoctets(double)" />
        public static Information Teraoctets<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Information.FromTeraoctets(double.CreateChecked(value));
#else
            , IConvertible
            => Information.FromTeraoctets(value.ToDouble(null));
#endif

    }
}
