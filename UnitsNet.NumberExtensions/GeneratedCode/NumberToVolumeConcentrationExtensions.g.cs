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

namespace UnitsNet.NumberExtensions.NumberToVolumeConcentration
{
    /// <summary>
    /// A number to VolumeConcentration Extensions
    /// </summary>
    public static class NumberToVolumeConcentrationExtensions
    {
        /// <inheritdoc cref="VolumeConcentration.FromCentilitersPerLiter(double)" />
        public static VolumeConcentration CentilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromCentilitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromCentilitersPerMilliliter(double)" />
        public static VolumeConcentration CentilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromCentilitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromDecilitersPerLiter(double)" />
        public static VolumeConcentration DecilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromDecilitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromDecilitersPerMilliliter(double)" />
        public static VolumeConcentration DecilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromDecilitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromDecimalFractions(double)" />
        public static VolumeConcentration DecimalFractions<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromDecimalFractions(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromLitersPerLiter(double)" />
        public static VolumeConcentration LitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromLitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromLitersPerMilliliter(double)" />
        public static VolumeConcentration LitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromLitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromMicrolitersPerLiter(double)" />
        public static VolumeConcentration MicrolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromMicrolitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromMicrolitersPerMilliliter(double)" />
        public static VolumeConcentration MicrolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromMicrolitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromMillilitersPerLiter(double)" />
        public static VolumeConcentration MillilitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromMillilitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromMillilitersPerMilliliter(double)" />
        public static VolumeConcentration MillilitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromMillilitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromNanolitersPerLiter(double)" />
        public static VolumeConcentration NanolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromNanolitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromNanolitersPerMilliliter(double)" />
        public static VolumeConcentration NanolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromNanolitersPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerBillion(double)" />
        public static VolumeConcentration PartsPerBillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPartsPerBillion(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerMillion(double)" />
        public static VolumeConcentration PartsPerMillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPartsPerMillion(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerThousand(double)" />
        public static VolumeConcentration PartsPerThousand<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPartsPerThousand(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPartsPerTrillion(double)" />
        public static VolumeConcentration PartsPerTrillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPartsPerTrillion(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPercent(double)" />
        public static VolumeConcentration Percent<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPercent(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPicolitersPerLiter(double)" />
        public static VolumeConcentration PicolitersPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPicolitersPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="VolumeConcentration.FromPicolitersPerMilliliter(double)" />
        public static VolumeConcentration PicolitersPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => VolumeConcentration.FromPicolitersPerMilliliter(Convert.ToDouble(value));

    }
}
