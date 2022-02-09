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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Time is a dimension in which events can be ordered from the past through the present into the future, and also the measure of durations of events and the intervals between them.
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class Duration : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DurationUnit? _unit;

        static Duration()
        {
            BaseDimensions = new BaseDimensions(0, 0, 1, 0, 0, 0, 0);
            BaseUnit = DurationUnit.Second;
            MaxValue = new Duration(double.MaxValue, BaseUnit);
            MinValue = new Duration(double.MinValue, BaseUnit);
            QuantityType = QuantityType.Duration;
            Units = Enum.GetValues(typeof(DurationUnit)).Cast<DurationUnit>().Except(new DurationUnit[]{ DurationUnit.Undefined }).ToArray();
            Zero = new Duration(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.Duration, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit Second.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public Duration()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private Duration(double value, DurationUnit unit)
        {
            if (unit == DurationUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static DurationUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Duration MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Duration MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the Duration quantity.
        /// </summary>
        public static DurationUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Duration Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public DurationUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => Duration.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Duration.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Duration in Days.
        /// </summary>
        public double Days => As(DurationUnit.Day);

        /// <summary>
        ///     Get Duration in Hours.
        /// </summary>
        public double Hours => As(DurationUnit.Hour);

        /// <summary>
        ///     Get Duration in JulianYears.
        /// </summary>
        public double JulianYears => As(DurationUnit.JulianYear);

        /// <summary>
        ///     Get Duration in Microseconds.
        /// </summary>
        public double Microseconds => As(DurationUnit.Microsecond);

        /// <summary>
        ///     Get Duration in Milliseconds.
        /// </summary>
        public double Milliseconds => As(DurationUnit.Millisecond);

        /// <summary>
        ///     Get Duration in Minutes.
        /// </summary>
        public double Minutes => As(DurationUnit.Minute);

        /// <summary>
        ///     Get Duration in Months30.
        /// </summary>
        public double Months30 => As(DurationUnit.Month30);

        /// <summary>
        ///     Get Duration in Nanoseconds.
        /// </summary>
        public double Nanoseconds => As(DurationUnit.Nanosecond);

        /// <summary>
        ///     Get Duration in Seconds.
        /// </summary>
        public double Seconds => As(DurationUnit.Second);

        /// <summary>
        ///     Get Duration in Weeks.
        /// </summary>
        public double Weeks => As(DurationUnit.Week);

        /// <summary>
        ///     Get Duration in Years365.
        /// </summary>
        public double Years365 => As(DurationUnit.Year365);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Day, new CultureInfo("en-US"), false, true, new string[]{"d", "day", "days"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Day, new CultureInfo("ru-RU"), false, true, new string[]{"сут", "д"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Hour, new CultureInfo("en-US"), false, true, new string[]{"h", "hr", "hrs", "hour", "hours"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Hour, new CultureInfo("ru-RU"), false, true, new string[]{"ч", "час"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.JulianYear, new CultureInfo("en-US"), false, true, new string[]{"jyr", "jyear", "jyears"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Microsecond, new CultureInfo("en-US"), false, true, new string[]{"µs", "µsec", "µsecs", "µsecond", "µseconds"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Microsecond, new CultureInfo("ru-RU"), false, true, new string[]{"мксек", "мкс"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Millisecond, new CultureInfo("en-US"), false, true, new string[]{"ms", "msec", "msecs", "msecond", "mseconds"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Millisecond, new CultureInfo("ru-RU"), false, true, new string[]{"мсек", "мс"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Minute, new CultureInfo("en-US"), false, true, new string[]{"m", "min", "minute", "minutes"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Minute, new CultureInfo("ru-RU"), false, true, new string[]{"мин"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Month30, new CultureInfo("en-US"), false, true, new string[]{"mo", "month", "months"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Month30, new CultureInfo("ru-RU"), false, true, new string[]{"месяц"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Nanosecond, new CultureInfo("en-US"), false, true, new string[]{"ns", "nsec", "nsecs", "nsecond", "nseconds"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Nanosecond, new CultureInfo("ru-RU"), false, true, new string[]{"нсек", "нс"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Second, new CultureInfo("en-US"), false, true, new string[]{"s", "sec", "secs", "second", "seconds"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Second, new CultureInfo("ru-RU"), false, true, new string[]{"сек", "с"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Week, new CultureInfo("en-US"), false, true, new string[]{"wk", "week", "weeks"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Week, new CultureInfo("ru-RU"), false, true, new string[]{"нед"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Year365, new CultureInfo("en-US"), false, true, new string[]{"yr", "year", "years"});
            unitAbbreviationsCache.PerformAbbreviationMapping(DurationUnit.Year365, new CultureInfo("ru-RU"), false, true, new string[]{"год"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(DurationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(DurationUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Duration from Days.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromDays(double days)
        {
            double value = (double) days;
            return new Duration(value, DurationUnit.Day);
        }
        /// <summary>
        ///     Get Duration from Hours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromHours(double hours)
        {
            double value = (double) hours;
            return new Duration(value, DurationUnit.Hour);
        }
        /// <summary>
        ///     Get Duration from JulianYears.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromJulianYears(double julianyears)
        {
            double value = (double) julianyears;
            return new Duration(value, DurationUnit.JulianYear);
        }
        /// <summary>
        ///     Get Duration from Microseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMicroseconds(double microseconds)
        {
            double value = (double) microseconds;
            return new Duration(value, DurationUnit.Microsecond);
        }
        /// <summary>
        ///     Get Duration from Milliseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMilliseconds(double milliseconds)
        {
            double value = (double) milliseconds;
            return new Duration(value, DurationUnit.Millisecond);
        }
        /// <summary>
        ///     Get Duration from Minutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMinutes(double minutes)
        {
            double value = (double) minutes;
            return new Duration(value, DurationUnit.Minute);
        }
        /// <summary>
        ///     Get Duration from Months30.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMonths30(double months30)
        {
            double value = (double) months30;
            return new Duration(value, DurationUnit.Month30);
        }
        /// <summary>
        ///     Get Duration from Nanoseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromNanoseconds(double nanoseconds)
        {
            double value = (double) nanoseconds;
            return new Duration(value, DurationUnit.Nanosecond);
        }
        /// <summary>
        ///     Get Duration from Seconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromSeconds(double seconds)
        {
            double value = (double) seconds;
            return new Duration(value, DurationUnit.Second);
        }
        /// <summary>
        ///     Get Duration from Weeks.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromWeeks(double weeks)
        {
            double value = (double) weeks;
            return new Duration(value, DurationUnit.Week);
        }
        /// <summary>
        ///     Get Duration from Years365.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromYears365(double years365)
        {
            double value = (double) years365;
            return new Duration(value, DurationUnit.Year365);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DurationUnit" /> to <see cref="Duration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Duration unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Duration From(double value, DurationUnit fromUnit)
        {
            return new Duration((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Duration Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Duration Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<Duration, DurationUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Duration result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out Duration result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<Duration, DurationUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static DurationUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static DurationUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<DurationUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out DurationUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out DurationUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<DurationUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is Duration objDuration)) throw new ArgumentException("Expected type Duration.", nameof(obj));

            return CompareTo(objDuration);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(Duration other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Duration objDuration))
                return false;

            return Equals(objDuration);
        }

        public bool Equals(Duration other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Duration within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Duration other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Duration.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((DurationUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(DurationUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Duration ToUnit(DurationUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Duration(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case DurationUnit.Day: return _value*24*3600;
                case DurationUnit.Hour: return _value*3600;
                case DurationUnit.JulianYear: return _value*365.25*24*3600;
                case DurationUnit.Microsecond: return (_value) * 1e-6d;
                case DurationUnit.Millisecond: return (_value) * 1e-3d;
                case DurationUnit.Minute: return _value*60;
                case DurationUnit.Month30: return _value*30*24*3600;
                case DurationUnit.Nanosecond: return (_value) * 1e-9d;
                case DurationUnit.Second: return _value;
                case DurationUnit.Week: return _value*7*24*3600;
                case DurationUnit.Year365: return _value*365*24*3600;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(DurationUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case DurationUnit.Day: return baseUnitValue/(24*3600);
                case DurationUnit.Hour: return baseUnitValue/3600;
                case DurationUnit.JulianYear: return baseUnitValue/(365.25*24*3600);
                case DurationUnit.Microsecond: return (baseUnitValue) / 1e-6d;
                case DurationUnit.Millisecond: return (baseUnitValue) / 1e-3d;
                case DurationUnit.Minute: return baseUnitValue/60;
                case DurationUnit.Month30: return baseUnitValue/(30*24*3600);
                case DurationUnit.Nanosecond: return (baseUnitValue) / 1e-9d;
                case DurationUnit.Second: return baseUnitValue;
                case DurationUnit.Week: return baseUnitValue/(7*24*3600);
                case DurationUnit.Year365: return baseUnitValue/(365*24*3600);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}