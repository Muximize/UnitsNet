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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.Helpers;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LeakRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LeakRateTestsBase : QuantityTestsBase
    {
        protected abstract double MillibarLitersPerSecondInOnePascalCubicMeterPerSecond { get; }
        protected abstract double PascalCubicMetersPerSecondInOnePascalCubicMeterPerSecond { get; }
        protected abstract double TorrLitersPerSecondInOnePascalCubicMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MillibarLitersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PascalCubicMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double TorrLitersPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(LeakRateUnit unit)
        {
            return unit switch
            {
                LeakRateUnit.MillibarLiterPerSecond => (MillibarLitersPerSecondInOnePascalCubicMeterPerSecond, MillibarLitersPerSecondTolerance),
                LeakRateUnit.PascalCubicMeterPerSecond => (PascalCubicMetersPerSecondInOnePascalCubicMeterPerSecond, PascalCubicMetersPerSecondTolerance),
                LeakRateUnit.TorrLiterPerSecond => (TorrLitersPerSecondInOnePascalCubicMeterPerSecond, TorrLitersPerSecondTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { LeakRateUnit.MillibarLiterPerSecond },
            new object[] { LeakRateUnit.PascalCubicMeterPerSecond },
            new object[] { LeakRateUnit.TorrLiterPerSecond },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new LeakRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LeakRate(double.PositiveInfinity, LeakRateUnit.PascalCubicMeterPerSecond));
            Assert.Throws<ArgumentException>(() => new LeakRate(double.NegativeInfinity, LeakRateUnit.PascalCubicMeterPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new LeakRate(double.NaN, LeakRateUnit.PascalCubicMeterPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new LeakRate(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new LeakRate(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (LeakRate) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void LeakRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new LeakRate(1, LeakRateUnit.PascalCubicMeterPerSecond);

            QuantityInfo<LeakRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(LeakRate.Zero, quantityInfo.Zero);
            Assert.Equal("LeakRate", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<LeakRateUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void PascalCubicMeterPerSecondToLeakRateUnits()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(MillibarLitersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.MillibarLitersPerSecond, MillibarLitersPerSecondTolerance);
            AssertEx.EqualTolerance(PascalCubicMetersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(TorrLitersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.TorrLitersPerSecond, TorrLitersPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = LeakRate.From(1, LeakRateUnit.MillibarLiterPerSecond);
            AssertEx.EqualTolerance(1, quantity00.MillibarLitersPerSecond, MillibarLitersPerSecondTolerance);
            Assert.Equal(LeakRateUnit.MillibarLiterPerSecond, quantity00.Unit);

            var quantity01 = LeakRate.From(1, LeakRateUnit.PascalCubicMeterPerSecond);
            AssertEx.EqualTolerance(1, quantity01.PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, quantity01.Unit);

            var quantity02 = LeakRate.From(1, LeakRateUnit.TorrLiterPerSecond);
            AssertEx.EqualTolerance(1, quantity02.TorrLitersPerSecond, TorrLitersPerSecondTolerance);
            Assert.Equal(LeakRateUnit.TorrLiterPerSecond, quantity02.Unit);

        }

        [Fact]
        public void FromPascalCubicMetersPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LeakRate.FromPascalCubicMetersPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => LeakRate.FromPascalCubicMetersPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromPascalCubicMetersPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LeakRate.FromPascalCubicMetersPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(MillibarLitersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.As(LeakRateUnit.MillibarLiterPerSecond), MillibarLitersPerSecondTolerance);
            AssertEx.EqualTolerance(PascalCubicMetersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.As(LeakRateUnit.PascalCubicMeterPerSecond), PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(TorrLitersPerSecondInOnePascalCubicMeterPerSecond, pascalcubicmeterpersecond.As(LeakRateUnit.TorrLiterPerSecond), TorrLitersPerSecondTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new LeakRate(value: 1, unit: LeakRate.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = LeakRate.Parse("1 mbar·l/s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MillibarLitersPerSecond, MillibarLitersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.MillibarLiterPerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = LeakRate.Parse("1 Pa·m³/s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = LeakRate.Parse("1 Torr·l/s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.TorrLitersPerSecond, TorrLitersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.TorrLiterPerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(LeakRate.TryParse("1 mbar·l/s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MillibarLitersPerSecond, MillibarLitersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.MillibarLiterPerSecond, parsed.Unit);
            }

            {
                Assert.True(LeakRate.TryParse("1 Pa·m³/s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, parsed.Unit);
            }

            {
                Assert.True(LeakRate.TryParse("1 Torr·l/s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.TorrLitersPerSecond, TorrLitersPerSecondTolerance);
                Assert.Equal(LeakRateUnit.TorrLiterPerSecond, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = LeakRate.ParseUnit("mbar·l/s", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LeakRateUnit.MillibarLiterPerSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = LeakRate.ParseUnit("Pa·m³/s", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = LeakRate.ParseUnit("Torr·l/s", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(LeakRateUnit.TorrLiterPerSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(LeakRate.TryParseUnit("mbar·l/s", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LeakRateUnit.MillibarLiterPerSecond, parsedUnit);
            }

            {
                Assert.True(LeakRate.TryParseUnit("Pa·m³/s", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LeakRateUnit.PascalCubicMeterPerSecond, parsedUnit);
            }

            {
                Assert.True(LeakRate.TryParseUnit("Torr·l/s", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(LeakRateUnit.TorrLiterPerSecond, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(LeakRateUnit unit)
        {
            var inBaseUnits = LeakRate.From(1.0, LeakRate.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(LeakRateUnit unit)
        {
            var quantity = LeakRate.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(LeakRateUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = LeakRate.Units.First(u => u != LeakRate.BaseUnit);

            var quantity = LeakRate.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(LeakRateUnit unit)
        {
            var quantity = default(LeakRate);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(1, LeakRate.FromMillibarLitersPerSecond(pascalcubicmeterpersecond.MillibarLitersPerSecond).PascalCubicMetersPerSecond, MillibarLitersPerSecondTolerance);
            AssertEx.EqualTolerance(1, LeakRate.FromPascalCubicMetersPerSecond(pascalcubicmeterpersecond.PascalCubicMetersPerSecond).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, LeakRate.FromTorrLitersPerSecond(pascalcubicmeterpersecond.TorrLitersPerSecond).PascalCubicMetersPerSecond, TorrLitersPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LeakRate v = LeakRate.FromPascalCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (LeakRate.FromPascalCubicMetersPerSecond(3)-v).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (LeakRate.FromPascalCubicMetersPerSecond(10)/5).PascalCubicMetersPerSecond, PascalCubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, LeakRate.FromPascalCubicMetersPerSecond(10)/LeakRate.FromPascalCubicMetersPerSecond(5), PascalCubicMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LeakRate onePascalCubicMeterPerSecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            LeakRate twoPascalCubicMetersPerSecond = LeakRate.FromPascalCubicMetersPerSecond(2);

            Assert.True(onePascalCubicMeterPerSecond < twoPascalCubicMetersPerSecond);
            Assert.True(onePascalCubicMeterPerSecond <= twoPascalCubicMetersPerSecond);
            Assert.True(twoPascalCubicMetersPerSecond > onePascalCubicMeterPerSecond);
            Assert.True(twoPascalCubicMetersPerSecond >= onePascalCubicMeterPerSecond);

            Assert.False(onePascalCubicMeterPerSecond > twoPascalCubicMetersPerSecond);
            Assert.False(onePascalCubicMeterPerSecond >= twoPascalCubicMetersPerSecond);
            Assert.False(twoPascalCubicMetersPerSecond < onePascalCubicMeterPerSecond);
            Assert.False(twoPascalCubicMetersPerSecond <= onePascalCubicMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.Equal(0, pascalcubicmeterpersecond.CompareTo(pascalcubicmeterpersecond));
            Assert.True(pascalcubicmeterpersecond.CompareTo(LeakRate.Zero) > 0);
            Assert.True(LeakRate.Zero.CompareTo(pascalcubicmeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => pascalcubicmeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => pascalcubicmeterpersecond.CompareTo(null));
        }

        [Theory]
        [InlineData(1, LeakRateUnit.PascalCubicMeterPerSecond, 1, LeakRateUnit.PascalCubicMeterPerSecond, true)]  // Same value and unit.
        [InlineData(1, LeakRateUnit.PascalCubicMeterPerSecond, 2, LeakRateUnit.PascalCubicMeterPerSecond, false)] // Different value.
        [InlineData(2, LeakRateUnit.PascalCubicMeterPerSecond, 1, LeakRateUnit.MillibarLiterPerSecond, false)] // Different value and unit.
        [InlineData(1, LeakRateUnit.PascalCubicMeterPerSecond, 1, LeakRateUnit.MillibarLiterPerSecond, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, LeakRateUnit unitA, double valueB, LeakRateUnit unitB, bool expectEqual)
        {
            var a = new LeakRate(valueA, unitA);
            var b = new LeakRate(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = LeakRate.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.True(v.Equals(LeakRate.FromPascalCubicMetersPerSecond(1), PascalCubicMetersPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LeakRate.Zero, PascalCubicMetersPerSecondTolerance, ComparisonType.Relative));
            Assert.True(LeakRate.FromPascalCubicMetersPerSecond(100).Equals(LeakRate.FromPascalCubicMetersPerSecond(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(LeakRate.FromPascalCubicMetersPerSecond(100).Equals(LeakRate.FromPascalCubicMetersPerSecond(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(LeakRate.FromPascalCubicMetersPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.False(pascalcubicmeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LeakRate pascalcubicmeterpersecond = LeakRate.FromPascalCubicMetersPerSecond(1);
            Assert.False(pascalcubicmeterpersecond.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(LeakRateUnit)).Cast<LeakRateUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(LeakRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 mbar·l/s", new LeakRate(1, LeakRateUnit.MillibarLiterPerSecond).ToString());
            Assert.Equal("1 Pa·m³/s", new LeakRate(1, LeakRateUnit.PascalCubicMeterPerSecond).ToString());
            Assert.Equal("1 Torr·l/s", new LeakRate(1, LeakRateUnit.TorrLiterPerSecond).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 mbar·l/s", new LeakRate(1, LeakRateUnit.MillibarLiterPerSecond).ToString(swedishCulture));
            Assert.Equal("1 Pa·m³/s", new LeakRate(1, LeakRateUnit.PascalCubicMeterPerSecond).ToString(swedishCulture));
            Assert.Equal("1 Torr·l/s", new LeakRate(1, LeakRateUnit.TorrLiterPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s1"));
            Assert.Equal("0.12 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s2"));
            Assert.Equal("0.123 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s3"));
            Assert.Equal("0.1235 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 Pa·m³/s", new LeakRate(0.123456, LeakRateUnit.PascalCubicMeterPerSecond).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(LeakRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(LeakRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(LeakRate.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(LeakRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(1.0);
            Assert.Equal(new {LeakRate.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = LeakRate.FromPascalCubicMetersPerSecond(value);
            Assert.Equal(LeakRate.FromPascalCubicMetersPerSecond(-value), -quantity);
        }
    }
}
