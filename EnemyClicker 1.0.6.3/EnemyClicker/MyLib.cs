using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;

namespace MyLib
{

	#region Получить инфо об этой библиотеке классов || Get info about this class library
	public static class GetInfo
	{
		//Возвращает и, если надо, выводит информацию о создателю данной библиотеки классов
		public static string CreatorInfo(bool needPrint = false)
		{
			string creatorInfo = @"
|---------------------------Информация о библиотеке---------------------------|
|Информация о создателе данной библиотеки:                                    |
|ФИО: Шмыков Филипп Андреевич                                                 |
|Дата рождения: 22.08.2005                                                    |
|Целевой язык программирования для этой библиотеки: C#                        |
|Целевая версия языка программирования для этой библиотеки: .NET Framework 4.8|
|_____________________________________________________________________________|
";

			if (needPrint == true)
				Console.Write(creatorInfo);

			return creatorInfo;
		}
	}
	#endregion




	#region Универсальные методы || Universal methods
	public static class MyUniversal
	{
		//Усовершенствованная конвертация
		//Vanced convert
		public static class VancedConvert
		{
			//toBool
			//Converting to type Bool || Конвертирование в тип Bool
			#region "toBool", it safety converts any type to bool
			public static bool toBool(in bool pre_str)
			{
				return pre_str;
			}

			public static bool toBool(in byte pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in sbyte pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in short pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in ushort pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in int pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in uint pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in long pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in ulong pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in float pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in double pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in decimal pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in char pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}

			public static bool toBool(in string pre_str)
			{
				if (pre_str.Replace(" ", "") != "")
					return true;
				else
					return false;
			}

			public static bool toBool(in BigInteger pre_str)
			{
				if (pre_str > 0)
					return true;
				else
					return false;
			}
			#endregion

			//toByte
			//Converting to type Byte || Конвертирование в тип Byte
			#region "toByte", it safety converts any type to byte
			public static byte toByte(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static byte toByte(in byte pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in sbyte pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in short pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in ushort pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in int pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in uint pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in long pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in ulong pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in float pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in double pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in decimal pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in char pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in string pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in object pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static byte toByte(in BigInteger pre_value)
			{
				byte value;

				if (pre_value.ToString().Contains(','))
					byte.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					byte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}
			#endregion

			//toSbyte
			//Converting to type Byte || Конвертирование в тип Sbyte
			#region "toSbyte", it safety converts any type to sbyte
			public static sbyte toSbyte(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static sbyte toSbyte(in byte pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in sbyte pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in short pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in ushort pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in int pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in uint pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in long pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in ulong pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in float pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in double pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in decimal pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in char pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in string pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in object pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}

			public static sbyte toSbyte(in BigInteger pre_value)
			{
				sbyte.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out sbyte value);
				return value;
			}
			#endregion

			//toShort
			//Converting to type Short || Конвертирование в тип Short
			#region "toShort", it safety converts any type to short
			public static short toShort(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static short toShort(in byte pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in sbyte pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in short pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in ushort pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in int pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in uint pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in long pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in ulong pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in float pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in double pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in decimal pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in char pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in string pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in object pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static short toShort(in BigInteger pre_value)
			{
				short value;

				if (pre_value.ToString().Contains(','))
					short.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					short.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}
			#endregion

			//toUshort
			//Converting to type Ushort || Конвертирование в тип Ushort
			#region "toUshort", it safety converts any type to short
			public static ushort toUshort(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static ushort toUshort(in byte pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in sbyte pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in short pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in ushort pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in int pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in uint pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in long pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in ulong pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in float pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in double pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in decimal pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in char pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in string pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in object pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}

			public static ushort toUshort(in BigInteger pre_value)
			{
				ushort value;

				if (pre_value.ToString().Contains(','))
					ushort.TryParse(pre_value.ToString().Replace(" ", ""), out value);
				else
					ushort.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out value);
				return value;
			}
			#endregion

			//toInt
			//Converting to type Int || Конвертирование в тип Int
			#region "toInt", it safety converts any type to int
			public static int toInt(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static int toInt(in byte pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in sbyte pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in short pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in ushort pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in int pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in uint pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in long pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in ulong pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in float pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in double pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in decimal pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in char pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in string pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}

			public static int toInt(in object pre_value)
			{
				double.TryParse((pre_value.ToString().Replace(".", "").Replace(" ", "")), out double value);
				int.TryParse(Math.Floor(value).ToString(), out int resultInt);

				return resultInt;
			}
			#endregion

			//toDouble
			//Converting to type Double || Конвертирование в тип Double
			#region "toDouble", it safety converts any type to double
			public static double toDouble(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static double toDouble(in byte pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in sbyte pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in short pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in ushort pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in int pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in uint pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in long pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in ulong pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in float pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in double pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in decimal pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in char pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in string pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}

			public static double toDouble(in object pre_value)
			{
				double.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out double value);
				return value;
			}
			#endregion

			//toString
			//Converting to type String || Конвертирование в тип String
			#region "toString", it safety converts any type to string
			public static string toString(in bool pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in byte pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in sbyte pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in short pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in ushort pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in int pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in uint pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in long pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in ulong pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in float pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in double pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in decimal pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in char pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in string pre_value)
			{
				return pre_value.ToString();
			}

			public static string toString(in object pre_value)
			{
				return pre_value.ToString();
			}
			#endregion

			//toBigInteger
			//Converting to type Double || Конвертирование в тип Double
			#region "toBigInteger", it safety converts any type to double
			public static BigInteger toBigInteger(in bool pre_value)
			{
				if (pre_value == true)
					return 1;

				return 0;
			}

			public static BigInteger toBigInteger(in byte pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in sbyte pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in short pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in ushort pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in int pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in uint pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in long pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in ulong pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in float pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in double pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in decimal pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in char pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in string pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}

			public static BigInteger toBigInteger(in object pre_value)
			{
				BigInteger.TryParse(pre_value.ToString().Replace(".", ",").Replace(" ", ""), out BigInteger value);
				return value;
			}
			#endregion
		}


		//Values control by borders
		//Контроль значений по границам
		public static class BorderValuesControl
		{
			//Value control by bottom border
			//Контроль значения по нижней границе
			#region Сделать больше чем... (если меньше, то приводится к значению сравнения)
			public static void MakeBiggerThan(ref byte number, byte MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref sbyte number, sbyte MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref short number, short MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref ushort number, ushort MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref int number, int MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref uint number, uint MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref long number, long MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref ulong number, ulong MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref float number, float MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref double number, double MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			public static void MakeBiggerThan(ref decimal number, decimal MakeBiggerThan = 0)
			{
				if (number < MakeBiggerThan)
					number = MakeBiggerThan;
			}

			#endregion

			//Value control by top border
			//Контроль значения по верхней границе
			#region Сделать меньше чем... (если больше, то приводится к значению сравнения)
			public static void MakeLessThan(ref byte number, byte MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref sbyte number, sbyte MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref short number, short MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref ushort number, ushort MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref int number, int MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref uint number, uint MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref long number, long MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref ulong number, ulong MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref float number, float MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref double number, double MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			public static void MakeLessThan(ref decimal number, decimal MakeLessThan = 0)
			{
				if (number > MakeLessThan)
					number = MakeLessThan;
			}

			#endregion
		}
	}

	#endregion




	#region Методы для работы с типом string (строками) и походими типами || Methods for working with strings and similar types

	//Work with strings
	//Работа со строками
	public static class MyStrings
	{
		#region Divide to grades || Разбиение числа по разрядам

		//Dividing a number to grades
		//Разбиение числа по разрядам
		#region DivideToGrades
		public static string DivideToGradesEndlessNewVersion(in BigInteger Number)
		{
			// Данные
			string number = Number.ToString(); // начальное число
			string resultMiddleNum = ""; // промежуточное число
			string resultNum = ""; // промежуточное число

			// Конструирование числа
			for (int i = number.Length - 1; i >= 0;)
			{
				// Добавление сразу до 3х разрядов в число
				for (int g = 3; g > 0 && i >= 0; g--, i--)
				{
					resultMiddleNum += number[i];
				}
				if (i >= 0)
				{
					// Добавление пробелов между разрядами
					resultMiddleNum += " ";
				}
			}

			// Переворачиваем число
			for (int i = resultMiddleNum.Length - 1; i >= 0; i--)
			{
				resultNum += resultMiddleNum[i];
			}

			// Возвращаем результат
			return resultNum;
		}
		#endregion


		//Dividing a number to grades (old)
		//Разбиение числа по разрядам (old)
		#region DivideToGrades Old
		public static string DivideToGradesEndlessOld(BigInteger number)
		{
			List<string> Grades = new List<string> { };


			for (int powCount = 0; number >= GetPowOf10Endless(powCount); powCount += 3)
			{
				if (powCount > 0)
				{
					//Добавление в лист 
					Grades.Add((number % GetPowOf10Endless(powCount + 3) / GetPowOf10Endless(powCount)).ToString() + " ");

					//Редактирование предыдущего значения
					Grades[powCount / 3 - 1] = AddSomeZeroes(Grades[powCount / 3 - 1]) + " ";
				}
				else //Редактирование значения, где лишь 3 разряда
					Grades.Add((number % GetPowOf10Endless(powCount + 3)).ToString());
			}


			//Объединение разрядов в число
			string result = "";
			Grades.Reverse();
			foreach (string grade in Grades)
				result += grade;
			return result;

		}

		public static string DivideToGrades(long number)
		{
			List<string> Grades = new List<string> { };


			for (int powCount = 0; number >= GetPowOf10(powCount); powCount += 3)
			{
				if (powCount > 0)
				{
					//Добавление в лист 
					Grades.Add((number % GetPowOf10(powCount + 3) / GetPowOf10(powCount)).ToString() + " ");

					//Редактирование предыдущего значения
					Grades[powCount / 3 - 1] = AddSomeZeroes(Grades[powCount / 3 - 1]) + " ";
				}
				else //Редактирование значения, где лишь 3 разряда
					Grades.Add((number % GetPowOf10(powCount + 3)).ToString());
			}


			//Объединение разрядов в число
			string result = "";
			Grades.Reverse();
			foreach (string grade in Grades)
				result += grade;
			return result;

		}

		public static string DivideToGrades(int number)
		{
			List<string> Grades = new List<string> { };


			for (int powCount = 0; number >= GetPowOf10(powCount); powCount += 3)
			{
				if (powCount > 0)
				{
					//Добавление в лист 
					Grades.Add((number % GetPowOf10(powCount + 3) / GetPowOf10(powCount)).ToString() + " ");

					//Редактирование предыдущего значения
					Grades[powCount / 3 - 1] = AddSomeZeroes(Grades[powCount / 3 - 1]) + " ";
				}
				else //Редактирование значения, где лишь 3 разряда
					Grades.Add((number % GetPowOf10(powCount + 3)).ToString());
			}


			//Объединение разрядов в число
			string result = "";
			Grades.Reverse();
			foreach (string grade in Grades)
				result += grade;
			return result;

		}



		//Adding the desired zeros
		//Увеличение количества нолей до определённого количества
		private static string AddSomeZeroes(string number, in int zeroesCount = 3)
		{
			//Удаляем лишние пробелы
			number = number.Replace(" ", "");

			//Ищем длинну строки из нулей
			int lenght = zeroesCount - number.ToString().Length;

			//Добавляем недостающие ноли
			for (int i = 0; i < lenght; i++)
			{
				number += '0';
			}

			//Возвращаем итоговый рещультат
			return number;
		}


		//Getting 10 to the right power (without number's limit)
		//Получение 10 в нужной степени (без ограничения числа)
		#region GetPowOf10
		private static BigInteger GetPowOf10Endless(in BigInteger power)
		{
			if (power > 0)
			{
				BigInteger result = 10;
				for (BigInteger i = 1; i < power; i++)
					result *= 10;

				return result;
			}
			else
				return 1;
		}
		private static double GetPowOf10(in double power)
		{
			if (power > 0)
			{
				double result = 10;
				for (double i = 1; i < power; i++)
					result *= 10;

				return result;
			}
			else
				return 1;
		}
		private static int GetPowOf10(in int power)
		{
			if (power > 0)
			{
				int result = 10;
				for (double i = 1; i < power; i++)
					result *= 10;

				return result;
			}
			else
				return 1;
		}
		#endregion
		#endregion

		#endregion


		#region Rewrites || Изменения текстов

		//Removing extra symbols from string
		//Удаление лишних символов из string
		public static void DelExtraSymbols(ref string str, char symbolToDelete = ' ')
		{
			//Подготовка
			string resultStr = "";//итоговая строка
			bool otherCharDisabled = false;//отключена ли вставка символов далее
			int countUnnecessaryCharsInTheEnd = 0;//количество лишних символов удаляемого типа в конце слова


			//Сам процесс удаления лишних символов
			foreach (char symbol in str)
			{
				if (symbol == symbolToDelete && otherCharDisabled == true)
				{
					otherCharDisabled = false;
					resultStr += symbolToDelete;

					//надо удалить ещё 1 лишний символ в конце строчки
					countUnnecessaryCharsInTheEnd++;
				}
				else if (symbol != symbolToDelete)
				{
					otherCharDisabled = true;
					resultStr += symbol;

					//обнуляем лишние символы в конце строчки
					countUnnecessaryCharsInTheEnd = 0;
				}
			}

			//Удаление лишних символов в конце строки
			if (countUnnecessaryCharsInTheEnd > 0)
				str = resultStr.Remove(resultStr.Length - countUnnecessaryCharsInTheEnd, countUnnecessaryCharsInTheEnd);
			else
				str = resultStr;
		}


		//Rewrite the first letter of first word/all words into a capital
		//Переписывание первой буквы слова в большую в 1ом слове/во сех словах
		public static void RewriteLetterUp(ref string str, in bool rewriteInAllWords = true)
		{
			string resultString = "";// результат
			int i = 0;// счётчик

			if (str != "" && str != null) // проверяем на нулёвость строки
				if (rewriteInAllWords == true)
				{
					// Делаем большой все буквы
					bool firstLetterIsNow = true; //Первая ли буква в слове

					// Сразу пропускаем лишние пробелы и tab-ы (ch == 9)
					while (str[i] == ' ' || str[i] == 9) i++;

					// Сам процесс переписывания
					for (; i < str.Length; i++)
					{
						if (firstLetterIsNow == false)
						{
							resultString += str[i].ToString().ToLower();
						}
						else
						{
							resultString += str[i].ToString().ToUpper();
							firstLetterIsNow = false;
						}

						// Следущее слово
						if (str[i] == ' ' || str[i] == '.' || str[i] == 9)
							firstLetterIsNow = true;
					}

					str = resultString;
					return;
				}
				else
				{
					//Делаем большой только первую букву

					// Сразу пропускаем лишние пробелы и tab-ы (ch == 9)
					while (str[i] == ' ' || str[i] == 9) i++;


					// первая буква, заглавная
					resultString += str[i].ToString().ToUpper(); i++;

					// добавляем остальные буквы
					for (; i < str.Length; i++)
					{
						resultString += str[i];// не первая буква, обычная
					}

					// возвращаем значение
					str = resultString;
					return;
				}
		}


		//Remaking string to common format (without unnecessary spaces, all words with a small register)
		//Преобразование string в общий формат (без лишних пробелов, все слова с маленьким регистром)
		public static void RewriteToCommonFormat(ref string str)
		{
			//Понижаем регистр
			str = str.ToLower();

			//Удаление лишних пробелов
			DelExtraSymbols(ref str);
		}

		#endregion


		#region Sorting and correcting text || Сортировка и корректировка тестка

		#region Получение листов
		//SeverWordsToList; SeverWordsToString
		//Splitting a string by words
		//Разделение строки по словам
		#region voids SeverWordsTo...

		#region Метод возвращает лист с разъеденёнными словами, с которым можно работать, подходит также и для вычленения отдельного слова
		public static List<string> SeverWordsToList(string str)
		{
			//Источник строки в аргументах метода

			#region Главный код

			string EndedString = "";


			List<string> strList = new List<string>();


			string strEnd = "";

			#region Удаление лишних пробелов
			//Подготовка
			string RT = "";
			bool space = true;
			int lastchar = 0;

			//Удаление лишних пробелов
			foreach (char ch in str)
			{
				if (ch == ' ' && !space)
				{
					space = true;
					RT += ' ';
					lastchar++;
				}
				else if (ch != ' ')
				{
					space = false;
					RT += ch.ToString();
					lastchar = 0;
				}
			}

			RT = RT.Remove(RT.Length - lastchar, lastchar);

			str = RT;
			#endregion


			#region Анализ
			for (int g = 0; g < str.Length; g++)
			{
				for (; ; g++)
				{
					if (g != str.Length && str[g] != ' ')
					{
						strEnd += str[g];
					}
					else
					{
						strList.Add(strEnd);
						strEnd = "";
						break;
					}

				}
			}

			for (int i = 0; i < strList.Count; i++)
			{
				EndedString += strList[i] + @"
";
			}
			#endregion


			return strList;//вывод итоговых строк
			#endregion
		}
		#endregion

		#region метод возвращает строку типа string с разъеденёнными словами, с которой можно работать
		public static string SeverWordsToString(string str)
		{
			//Источник строки в аргументах метода

			#region Главный код

			string EndedString = "";


			List<string> strList = new List<string>();


			string strEnd = "";

			#region Удаление лишних пробелов
			//Подготовка
			string RT = "";
			bool space = true;
			int lastchar = 0;

			//Удаление лишних пробелов
			foreach (char ch in str)
			{
				if (ch == ' ' && !space)
				{
					space = true;
					RT += ' ';
					lastchar++;
				}
				else if (ch != ' ')
				{
					space = false;
					RT += ch.ToString();
					lastchar = 0;
				}
			}

			RT = RT.Remove(RT.Length - lastchar, lastchar);

			str = RT;
			#endregion


			#region Анализ
			for (int g = 0; g < str.Length; g++)
			{
				for (; ; g++)
				{
					if (g != str.Length && str[g] != ' ')
					{
						strEnd += str[g];
					}
					else
					{
						strList.Add(strEnd);
						strEnd = "";
						break;
					}

				}
			}

			for (int i = 0; i < strList.Count; i++)
			{
				EndedString += strList[i] + @"
";
			}
			#endregion


			return EndedString;//вывод итоговых строк
			#endregion
		}
		#endregion

		#endregion


		//Getting a list with Enter
		//Получение листа с учётом Enter
		#region SeverWithEnterToList
		public static List<string> SeverWithEnterToList(string pre_result)
		{
			List<string> list = new List<string>();
			string resultAtLine = "";


			foreach (char str in pre_result)
			{
				if (str == '\n')
				{
					list.Add(resultAtLine);
					resultAtLine = "";
				}
				else
				{
					resultAtLine += str;
				}
			}

			if (resultAtLine != "")
			{
				list.Add(resultAtLine);
			}

			return list;
		}
		#endregion


		//Getting a list with "*/", "/*", "//" and Enter
		//Получение листа с учётом "*/", "/*", "//" и Enter
		#region GetRightList
		public static List<string> GetRightList(string str)
		{
			List<string> list = new List<string> { };
			List<string> Links = new List<string> { };

			list = SeverWithEnterToList(str);

			int can_readAtAll = 1;
			bool can_read = true;
			bool ready = false;
			string final_string = "";

			foreach (string pre_item in list)
			{
				string item = pre_item.Replace("\r", "");

				if (item.Contains("/*"))
				{
					can_read = false;
					can_readAtAll -= 1;
				}
				else if (can_readAtAll > 0 && item.Contains("//"))
				{
					foreach (char ch in item)
					{
						if (ch == '/' && !ready)
						{
							ready = true;
						}
						else if (ch == '/' && ready)
						{
							ready = false;
							can_read = false;
						}

						if (ch != '/')
						{
							if (can_read)
							{
								if (ready)
								{
									final_string += '/';
									ready = false;
								}

								final_string += ch;
							}
						}
					}
				}
				else if (can_readAtAll > 0)
				{
					final_string = item;
				}


				if (item.Contains("*/"))
					can_readAtAll += 1;
				can_read = true;

				if (final_string != "" && final_string != "\n" && final_string != "\r")
				{
					Links.Add(final_string.Replace("\r", ""));
				}

				final_string = "";
			}



			return Links;
		}
		#endregion


		//Getting a list with "*/", "/*", "//", Enter and https://
		//Получение листа с учётом "*/", "/*", "//", Enter и https://
		#region GetRightListForHttps
		public static List<string> GetRightListForHttps(string str)
		{
			List<string> list = new List<string> { };
			List<string> Links = new List<string> { };

			list = SeverWithEnterToList(str);

			int can_readAtAll = 1;
			bool can_read = true;
			bool previousWasGlobalComment_part1 = false;
			string final_link = "";

			foreach (string pre_item in list)
			{
				string item = pre_item.Replace("\r", "");

				if (item.Contains("/*"))
				{
					can_read = false;
					can_readAtAll--;
				}
				else if (can_readAtAll > 0 && item.Contains("##"))
				{
					foreach (char ch in item)
					{
						if (ch == '#' && previousWasGlobalComment_part1 == false)
						{
							previousWasGlobalComment_part1 = true;
						}
						else if (ch == '#' && previousWasGlobalComment_part1 == true)
						{
							previousWasGlobalComment_part1 = false;
							can_read = false;
						}

						if (ch != '#')
						{
							if (can_read)
							{
								if (previousWasGlobalComment_part1 == true)
								{
									final_link += '#';
									previousWasGlobalComment_part1 = false;
								}

								final_link += ch;
							}
						}
					}
				}
				else if (can_readAtAll > 0)
				{
					final_link = item;
				}

				can_read = true;

				if (item.Contains("*/"))
				{
					can_read = true;
					can_readAtAll++;
				}


				if (final_link.Replace(" ", "") != "" && final_link != "\n" && final_link != "\r")
				{
					Links.Add(final_link.Replace(" ", "").Replace("\r", ""));
				}

				final_link = "";
			}


			return Links;
		}
		#endregion

		#endregion


		//Putting the word in the correct form, depending on the objects count
		//Постановка слова в правильную форму, в зависимости от количества объектов
		#region GetRightWordFrom
		public static string GetRightWordForm(int count, string _0_ОБЪЕКТОВ_correctFirstWordForm, string _1_ОБЪЕКТ_correctSecondWordForm, string _2_ОБЪЕКТА_correctThirdWordForm)
		{
			//Объектов: [11-20], last = 0, last = 5-9
			//Объект: last = 1
			//Объекта: [иначе]

			//Выяснение последней буквы
			int last = count % 10;

			//Здесь происходит определение формы слова

			if (last == 0 || (5 <= last && last <= 9) || (11 <= count && count <= 20))
			{
				//Объект[-ов]
				return $"{count} {_0_ОБЪЕКТОВ_correctFirstWordForm}";
			}
			else if (last == 1)
			{
				//Объект[]
				return $"{count} {_1_ОБЪЕКТ_correctSecondWordForm}";
			}
			else
			{
				//Объект[-а]
				return $"{count} {_2_ОБЪЕКТА_correctThirdWordForm}";
			}
		}
		#endregion

		#endregion
	}
	#endregion




	#region Математические методы || Math methods

	//Математические методы
	public static class MyMath
	{
		//Getting the biggest number
		//Получение наибольшего числа
		#region Max
		public static byte Max(params byte[] numbers)
		{
			return numbers.Max();
		}
		public static sbyte Max(params sbyte[] numbers)
		{
			return numbers.Max();
		}
		public static short Max(params short[] numbers)
		{
			return numbers.Max();
		}
		public static ushort Max(params ushort[] numbers)
		{
			return numbers.Max();
		}
		public static int Max(params int[] numbers)
		{
			return numbers.Max();
		}
		public static uint Max(params uint[] numbers)
		{
			return numbers.Max();
		}
		public static long Max(params long[] numbers)
		{
			return numbers.Max();
		}
		public static ulong Max(params ulong[] numbers)
		{
			return numbers.Max();
		}
		public static float Max(params float[] numbers)
		{
			return numbers.Max();
		}
		public static double Max(params double[] numbers)
		{
			return numbers.Max();
		}
		public static decimal Max(params decimal[] numbers)
		{
			return numbers.Max();
		}
		public static BigInteger Max(params BigInteger[] numbers)
		{
			return numbers.Max();
		}
		#endregion

		//Getting the modul of a number
		//Получение модуля числа
		#region GetModul
		public static int GetModul(in int number)
		{
			return Math.Abs(number);
		}

		public static long GetModul(in long number)
		{
			return Math.Abs(number);
		}

		public static float GetModul(in float number)
		{
			return Math.Abs(number);
		}

		public static double GetModul(in double number)
		{
			return Math.Abs(number);
		}

		public static decimal GetModul(in decimal number)
		{
			return Math.Abs(number);
		}

		public static BigInteger GetModul(in BigInteger number)
		{
			if (number < 0)
				return -number;

			return number;
		}
		#endregion


		//Getting a mixed number from an infinite fraction with a period
		//Получение смешанного числа из бесконечной дроби с периодом
		#region GetAMixedNumberFromEndlessDoubleWithPeriod

		//Основной метод
		public static string GetAMixedNumberFromEndlessDoubleWithPeriod(in string example)
		{
			#region Результаты
			string IntegerNumbers = ""; // целые числа
			string NumbersBeforePeriod = ""; // числа перед периодом
			string Period = ""; // период
			#endregion

			#region Сам рассчёт
			string mode = "IntegerNumber"; // режим

			//Разделение вычислений по режимам
			foreach (char ch in example)
			{
				if (mode == "IntegerNumber")
				{
					if (ch == ',')
						mode = "NumbersBeforePeriod";
					else
						IntegerNumbers += ch;
				} // целые числа
				else if (mode == "NumbersBeforePeriod")
				{
					if (ch == '(')
						mode = "Period";
					else
						NumbersBeforePeriod += ch;
				} // числа перед периодом
				else if (mode == "Period")
				{
					if (ch == ')')
						break;
					else
						Period += ch;
				} // период
			}
			#endregion

			#region Возвращение метода рассчёта

			// Удаляем лишние пробелы
			IntegerNumbers = IntegerNumbers.Replace(" ", "");
			NumbersBeforePeriod = NumbersBeforePeriod.Replace(" ", "");
			Period = Period.Replace(" ", "");

			// Проверяем на исчислимость
			if (double.TryParse(IntegerNumbers, out _) && (NumbersBeforePeriod == "" || double.TryParse(NumbersBeforePeriod, out _)) && double.TryParse(Period, out _))
				return GetAMixedNumberFromEndlessDoubleWithPeriodFinally(IntegerNumbers, NumbersBeforePeriod, Period);
			else
				return "System.FormatException";
			#endregion

		}

		//Вспомогательный метод - 1 (создание смешанной дроби из данных)
		private static string GetAMixedNumberFromEndlessDoubleWithPeriodFinally(string IntegerNumbers, string NumbersBeforePeriod, string Period)
		{
			#region Шаг 1: Приводим числа к конвертируемым значениям и уточняем числа перед периодом

			// Нету ли чисел перед периодом
			bool noNumBeforePeriod = false;

			if (IntegerNumbers == "") // целые числа
				IntegerNumbers = "0";
			if (NumbersBeforePeriod == "") // числа перед периодом
			{
				noNumBeforePeriod = true;
				NumbersBeforePeriod = "0";
			}
			if (Period == "")
				Period = "0"; // числа в периоде

			#endregion


			#region Шаг 2: Определяем количество чисел до периода и в периоде

			int countNumbersPrevPeriod = noNumBeforePeriod ? 0 : NumbersBeforePeriod.Length; // количество чисел до периода
			int countNumbersInPeriod = Period.Length; // количество чисел в периоде

			#endregion


			#region Шаг 3: Вычисляем результат

			// Вычисляем числитель
			double numerator = (double.Parse(NumbersBeforePeriod) * Math.Pow(10, countNumbersInPeriod) + int.Parse(Period)) - (double.Parse(NumbersBeforePeriod));

			// Вычисляем знаменатель
			double denominator = Math.Pow(10, (countNumbersPrevPeriod + countNumbersInPeriod)) - Math.Pow(10, countNumbersPrevPeriod);

			// Результат
			string fraction = "";

			// Считаем итоговую дробь, если числитель = 0, то просто возвращаем 0
			if (numerator != 0)
			{
				// сокращаем дробь
				ReduceAFraction(ref numerator, ref denominator);

				// конструируем результат
				fraction = $", {numerator} / {denominator}";
			}

			#endregion


			#region Шаг 4: Возвращаем результат

			// Возвращаем целые числа + дрорбь
			return IntegerNumbers + fraction;

			#endregion
		}

		//Вспомогательный метод - 2 (сокращение дроби)
		private static void ReduceAFraction(ref double numerator, ref double denumerator)
		{
			// если числитель = знаменатель, то вся дробь = 1
			if (numerator == denumerator)
				numerator = denumerator = 1;

			// вычисляем наибольшее значение
			double MaxValue = Math.Max(numerator, denumerator);

			// если наибольшее значение != 1, то сокращаем числа дроби
			for (double i = Math.Floor(MaxValue / 2); i > 1; i--)
			{
				// сокращаем дробь на все НОД-ы
				if (numerator % i == 0 && denumerator % i == 0)
				{
					numerator /= i;
					denumerator /= i;
				}
			}
		}

		#endregion
	}
	#endregion




	#region Проверки || Testings

	//Различные тестирования
	public static class MyTests
	{
		//Проверка, стартовал ли процесс
		public static bool IsProcessStarted(string processFullName)
		{
			// Записываем все запущенные процессы
			var allStartedProcesses = from proc in Process.GetProcesses(".")
									  orderby proc.Id
									  select proc;


			// Узнаём количество процессов с необходимым именем, если их > 0, то true, иначе false
			if (allStartedProcesses.Count(p => p.ProcessName.Contains(processFullName)) > 0)
				return true;
			else
				return false;
		}

		//Проверка, сущствует ли файл
		public static bool IsFileExists(in string process)
		{
			return File.Exists(process);//Возврат bool существует ли файл
		}
	}
	#endregion

}
