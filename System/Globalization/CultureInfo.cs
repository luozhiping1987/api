// Copyright (C) 2014 dot42
//
// Original filename: CultureInfo.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Runtime.InteropServices;
using System.Text;
using Dot42;
using Dot42.Internal;
using Java.Text;
using Locale = Java.Util.Locale;

namespace System.Globalization
{
    [SerializableAttribute]
    [ComVisible(true)]
	public class CultureInfo : IFormatProvider
    {
        private readonly Locale _locale;
        private readonly LazyAndWeak<NumberFormatInfo> _numberFormat;
        private readonly LazyAndWeak<DateTimeFormatInfo > _dateTimeFormat;

        private static readonly CultureInfo TheInvariantCulture;
        private static volatile CultureInfo _currentCulture;
        internal static readonly ICustomFormatter DefaultCustomFormatter = new DefaultFormatter();

        internal Locale Locale
        {
            get { return _locale; }
        }

        static CultureInfo ()
        {
            // US comes much closer to CultureInfo.InvariantCulture 
            // than Locale.ROOT, when it comes to Date/Time formatting/parsing.
            
            // just fix this at startup,so that reads are non-volatile.
            TheInvariantCulture = new CultureInfo(Locale.US, true); 

            _currentCulture = new CultureInfo(Locale.Default);

            Application.LocaleChanged += OnLocaleChanged;

        }

        /// <summary>
        /// Default ctor
        /// </summary>
        private CultureInfo(Locale locale, bool isInvariant = false)
        {
            this._locale = locale;
            _numberFormat = new LazyAndWeak<NumberFormatInfo>(()=>new NumberFormatInfo(locale));
            _dateTimeFormat = new LazyAndWeak<DateTimeFormatInfo>(() => new DateTimeFormatInfo(locale, isInvariant));

        }

        public CultureInfo(string locale) : this(new Locale(locale))
        {
        }

        public static CultureInfo CurrentCulture { get { return _currentCulture; }  }
        public static CultureInfo CurrentUICulture { get { return _currentCulture; } }

        public static CultureInfo InvariantCulture { [Inline] get { return TheInvariantCulture; } }

        public virtual DateTimeFormatInfo DateTimeFormat
        {
            get { return _dateTimeFormat.Value; }
        }

        internal Java.Text.NumberFormat JavaNumberFormat
        {
            get { return _numberFormat.Value.JavaNumberFormat; }
        }

        public virtual NumberFormatInfo NumberFormat
        {
            get { return _numberFormat.Value; }
        }

        public bool IsReadOnly { get { return true; } }

        public override string ToString()
        {
            return _locale.ToString(); //.Replace('_', '-');
        }

        /// <summary>
        /// Returns an object that provides formatting services for the specified type.
        /// </summary>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return DefaultCustomFormatter;
            }
            if (formatType == typeof(NumberFormatInfo))
            {
                return NumberFormat;
            }
            if (formatType == typeof(DateTimeFormatInfo))
            {
                return DateTimeFormat;
            }

            return null; // not supported.
            //throw new NotImplementedException("System.Globalization.CultureInfo.GetFormat: " + formatType.FullName);
        }

        private static void OnLocaleChanged(object sender, EventArgs e)
        {
            _currentCulture = new CultureInfo(Locale.Default);
        }

        internal class DefaultFormatter : ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (arg == null)   return string.Empty;
                if (arg is byte)   return NumberFormatter.Format(format, (int)(byte)arg, formatProvider);
                if (arg is short)  return NumberFormatter.Format(format, (int)(short)arg, formatProvider);
                if (arg is int)    return NumberFormatter.Format(format, (int)arg, formatProvider);
                if (arg is long)   return NumberFormatter.Format(format, (long)arg, formatProvider);
                if (arg is float)  return NumberFormatter.Format(format, (float)arg, formatProvider);
                if (arg is double) return NumberFormatter.Format(format, (double)arg, formatProvider);
                if (arg is Type)   return ((Type) arg).FullName;
                if (arg is string) return (string)arg;

                // default handling.
                var formattable = CompilerHelper.AsNativeIFormattable(arg);
                if (formattable != null)
                    return formattable.ToString(format, formatProvider);
                return arg.ToString();
            }
        }
	}

    internal static class FormatProviderExtensions
    {
        public static Locale ToLocale(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            if (cultureInfo != null) return cultureInfo.Locale;

            var dateTime = provider as DateTimeFormatInfo;
            if (dateTime != null) return dateTime.Locale;

            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat.Locale;
            
            return Locale.Default;
        }

        public static CultureInfo ToCultureInfo(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            return cultureInfo ?? CultureInfo.CurrentCulture;

        }

        public static bool IsInvariantCulture(this IFormatProvider provider)
        {
            var cultureInfo = provider as CultureInfo;
            return cultureInfo != null && cultureInfo == CultureInfo.InvariantCulture;
        }

        public static NumberFormatInfo ToNumberFormatInfo(this IFormatProvider provider)
        {
            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat;

            var cultureInfo = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            return cultureInfo.NumberFormat;
        }

        internal static NumberFormat ToJavaNumberFormat(this IFormatProvider provider)
        {
            var numberFormat = provider as NumberFormatInfo;
            if (numberFormat != null) return numberFormat.JavaNumberFormat;

            var cultureInfo = provider as CultureInfo ?? CultureInfo.CurrentCulture;
            return cultureInfo.NumberFormat.JavaNumberFormat;
        }


    }
}

