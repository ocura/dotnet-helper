<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [CompareHelper](#T-Ocura-Helper-CompareHelper 'Ocura.Helper.CompareHelper')
  - [In(value,values)](#M-Ocura-Helper-CompareHelper-In-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}- 'Ocura.Helper.CompareHelper.In(System.Int64,System.Collections.Generic.IEnumerable{System.Int64})')
  - [In(value,values)](#M-Ocura-Helper-CompareHelper-In-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'Ocura.Helper.CompareHelper.In(System.Int32,System.Collections.Generic.IEnumerable{System.Int32})')
  - [In(value,values)](#M-Ocura-Helper-CompareHelper-In-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}- 'Ocura.Helper.CompareHelper.In(System.Int16,System.Collections.Generic.IEnumerable{System.Int16})')
  - [NotIn(value,values)](#M-Ocura-Helper-CompareHelper-NotIn-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}- 'Ocura.Helper.CompareHelper.NotIn(System.Int64,System.Collections.Generic.IEnumerable{System.Int64})')
  - [NotIn(value,values)](#M-Ocura-Helper-CompareHelper-NotIn-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'Ocura.Helper.CompareHelper.NotIn(System.Int32,System.Collections.Generic.IEnumerable{System.Int32})')
  - [NotIn(value,values)](#M-Ocura-Helper-CompareHelper-NotIn-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}- 'Ocura.Helper.CompareHelper.NotIn(System.Int16,System.Collections.Generic.IEnumerable{System.Int16})')
- [ConvertHelper](#T-Ocura-Helper-ConvertHelper 'Ocura.Helper.ConvertHelper')
  - [ToChar(value)](#M-Ocura-Helper-ConvertHelper-ToChar-System-String- 'Ocura.Helper.ConvertHelper.ToChar(System.String)')
  - [ToDateTime(value)](#M-Ocura-Helper-ConvertHelper-ToDateTime-System-String- 'Ocura.Helper.ConvertHelper.ToDateTime(System.String)')
  - [ToDateTime(value,format)](#M-Ocura-Helper-ConvertHelper-ToDateTime-System-String,System-String- 'Ocura.Helper.ConvertHelper.ToDateTime(System.String,System.String)')
  - [ToInt(value)](#M-Ocura-Helper-ConvertHelper-ToInt-System-String- 'Ocura.Helper.ConvertHelper.ToInt(System.String)')
  - [ToInt16(value)](#M-Ocura-Helper-ConvertHelper-ToInt16-System-String- 'Ocura.Helper.ConvertHelper.ToInt16(System.String)')
  - [ToInt32(value)](#M-Ocura-Helper-ConvertHelper-ToInt32-System-String- 'Ocura.Helper.ConvertHelper.ToInt32(System.String)')
  - [ToInt64(value)](#M-Ocura-Helper-ConvertHelper-ToInt64-System-String- 'Ocura.Helper.ConvertHelper.ToInt64(System.String)')
  - [ToIntShort(value)](#M-Ocura-Helper-ConvertHelper-ToIntShort-System-String- 'Ocura.Helper.ConvertHelper.ToIntShort(System.String)')
  - [ToLong(value)](#M-Ocura-Helper-ConvertHelper-ToLong-System-String- 'Ocura.Helper.ConvertHelper.ToLong(System.String)')
- [DateTimeHelper](#T-Ocura-Helper-DateTimeHelper 'Ocura.Helper.DateTimeHelper')
  - [LastWeek](#P-Ocura-Helper-DateTimeHelper-LastWeek 'Ocura.Helper.DateTimeHelper.LastWeek')
  - [AddBusinessDays(date,days)](#M-Ocura-Helper-DateTimeHelper-AddBusinessDays-System-DateTime,System-Int32- 'Ocura.Helper.DateTimeHelper.AddBusinessDays(System.DateTime,System.Int32)')
  - [BeginOfMonth(date)](#M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-DateTime- 'Ocura.Helper.DateTimeHelper.BeginOfMonth(System.DateTime)')
  - [BeginOfMonth(date)](#M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-Nullable{System-DateTime}- 'Ocura.Helper.DateTimeHelper.BeginOfMonth(System.Nullable{System.DateTime})')
  - [DateFromYearWeek(year,weekOfYear)](#M-Ocura-Helper-DateTimeHelper-DateFromYearWeek-System-Int32,System-Int32- 'Ocura.Helper.DateTimeHelper.DateFromYearWeek(System.Int32,System.Int32)')
  - [EndOfMonth(date)](#M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-DateTime- 'Ocura.Helper.DateTimeHelper.EndOfMonth(System.DateTime)')
  - [EndOfMonth(date)](#M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-Nullable{System-DateTime}- 'Ocura.Helper.DateTimeHelper.EndOfMonth(System.Nullable{System.DateTime})')
  - [GetLastWeek()](#M-Ocura-Helper-DateTimeHelper-GetLastWeek 'Ocura.Helper.DateTimeHelper.GetLastWeek')
  - [IsBusinessDay(date)](#M-Ocura-Helper-DateTimeHelper-IsBusinessDay-System-DateTime- 'Ocura.Helper.DateTimeHelper.IsBusinessDay(System.DateTime)')
  - [IsHoliday(date)](#M-Ocura-Helper-DateTimeHelper-IsHoliday-System-DateTime- 'Ocura.Helper.DateTimeHelper.IsHoliday(System.DateTime)')
  - [MonthName(month)](#M-Ocura-Helper-DateTimeHelper-MonthName-System-Int32- 'Ocura.Helper.DateTimeHelper.MonthName(System.Int32)')
  - [WeekOfYear(time)](#M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-DateTime- 'Ocura.Helper.DateTimeHelper.WeekOfYear(System.DateTime)')
  - [WeekOfYear(time)](#M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-Nullable{System-DateTime}- 'Ocura.Helper.DateTimeHelper.WeekOfYear(System.Nullable{System.DateTime})')
- [DirectoryHelper](#T-Ocura-Helper-DirectoryHelper 'Ocura.Helper.DirectoryHelper')
  - [ClearFolderContent(folderPath)](#M-Ocura-Helper-DirectoryHelper-ClearFolderContent-System-String- 'Ocura.Helper.DirectoryHelper.ClearFolderContent(System.String)')
- [DynamicObjectHelper](#T-Ocura-Helper-DynamicObjectHelper 'Ocura.Helper.DynamicObjectHelper')
  - [AddIDictionary(objA,objB)](#M-Ocura-Helper-DynamicObjectHelper-AddIDictionary-System-Dynamic-ExpandoObject,System-Dynamic-ExpandoObject- 'Ocura.Helper.DynamicObjectHelper.AddIDictionary(System.Dynamic.ExpandoObject,System.Dynamic.ExpandoObject)')
  - [GenerateNestedObject(key,value)](#M-Ocura-Helper-DynamicObjectHelper-GenerateNestedObject-System-String,System-Object- 'Ocura.Helper.DynamicObjectHelper.GenerateNestedObject(System.String,System.Object)')
- [EnumHelper](#T-Ocura-Helper-EnumHelper 'Ocura.Helper.EnumHelper')
  - [Description(value)](#M-Ocura-Helper-EnumHelper-Description-System-Enum- 'Ocura.Helper.EnumHelper.Description(System.Enum)')
  - [GetKeyValues\`\`1()](#M-Ocura-Helper-EnumHelper-GetKeyValues``1 'Ocura.Helper.EnumHelper.GetKeyValues``1')
  - [GetValues\`\`1()](#M-Ocura-Helper-EnumHelper-GetValues``1 'Ocura.Helper.EnumHelper.GetValues``1')
  - [ToInt32(value)](#M-Ocura-Helper-EnumHelper-ToInt32-System-Enum- 'Ocura.Helper.EnumHelper.ToInt32(System.Enum)')
- [LinqHelper](#T-Ocura-Helper-LinqHelper 'Ocura.Helper.LinqHelper')
  - [CombineWith\`\`1(first,second)](#M-Ocura-Helper-LinqHelper-CombineWith``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}- 'Ocura.Helper.LinqHelper.CombineWith``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0})')
  - [Concat(source,delimiter)](#M-Ocura-Helper-LinqHelper-Concat-System-Collections-Generic-IEnumerable{System-Int64},System-String- 'Ocura.Helper.LinqHelper.Concat(System.Collections.Generic.IEnumerable{System.Int64},System.String)')
  - [Page\`\`1(source,page,pageSize)](#M-Ocura-Helper-LinqHelper-Page``1-System-Linq-IQueryable{``0},System-Int32,System-Int32- 'Ocura.Helper.LinqHelper.Page``1(System.Linq.IQueryable{``0},System.Int32,System.Int32)')
  - [Page\`\`1(source,page,pageSize)](#M-Ocura-Helper-LinqHelper-Page``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32- 'Ocura.Helper.LinqHelper.Page``1(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Int32)')
- [MathHelper](#T-Ocura-Helper-MathHelper 'Ocura.Helper.MathHelper')
  - [RoundUp(input,places)](#M-Ocura-Helper-MathHelper-RoundUp-System-Decimal,System-Int32- 'Ocura.Helper.MathHelper.RoundUp(System.Decimal,System.Int32)')
  - [RoundUp(input)](#M-Ocura-Helper-MathHelper-RoundUp-System-Decimal- 'Ocura.Helper.MathHelper.RoundUp(System.Decimal)')
  - [Share(partialValue,totalValue)](#M-Ocura-Helper-MathHelper-Share-System-Decimal,System-Decimal- 'Ocura.Helper.MathHelper.Share(System.Decimal,System.Decimal)')
  - [Variation(newValue,oldValue)](#M-Ocura-Helper-MathHelper-Variation-System-Decimal,System-Decimal- 'Ocura.Helper.MathHelper.Variation(System.Decimal,System.Decimal)')
- [NullHelper](#T-Ocura-Helper-NullHelper 'Ocura.Helper.NullHelper')
  - [CheckNull(value)](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-Int64}- 'Ocura.Helper.NullHelper.CheckNull(System.Nullable{System.Int64})')
  - [CheckNull(value)](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime}- 'Ocura.Helper.NullHelper.CheckNull(System.Nullable{System.DateTime})')
  - [CheckNull(value,defaultValue)](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime},System-Nullable{System-DateTime}- 'Ocura.Helper.NullHelper.CheckNull(System.Nullable{System.DateTime},System.Nullable{System.DateTime})')
- [StringHelper](#T-Ocura-Helper-StringHelper 'Ocura.Helper.StringHelper')
  - [Like(text,searchValue,normalize)](#M-Ocura-Helper-StringHelper-Like-System-String,System-String,System-Boolean- 'Ocura.Helper.StringHelper.Like(System.String,System.String,System.Boolean)')
  - [Pluralize(text,count,plural)](#M-Ocura-Helper-StringHelper-Pluralize-System-String,System-Int32,System-String- 'Ocura.Helper.StringHelper.Pluralize(System.String,System.Int32,System.String)')
  - [RemoveDiacritics(text)](#M-Ocura-Helper-StringHelper-RemoveDiacritics-System-String- 'Ocura.Helper.StringHelper.RemoveDiacritics(System.String)')
  - [ToLowerNormalize(text)](#M-Ocura-Helper-StringHelper-ToLowerNormalize-System-String- 'Ocura.Helper.StringHelper.ToLowerNormalize(System.String)')
  - [ToTitleCase(text)](#M-Ocura-Helper-StringHelper-ToTitleCase-System-String- 'Ocura.Helper.StringHelper.ToTitleCase(System.String)')
  - [ToUpperNormalize(text)](#M-Ocura-Helper-StringHelper-ToUpperNormalize-System-String- 'Ocura.Helper.StringHelper.ToUpperNormalize(System.String)')

<a name='assembly'></a>
# Ocura.Helper [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Ocura-Helper-CompareHelper'></a>
## CompareHelper [#](#T-Ocura-Helper-CompareHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-CompareHelper-In-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}-'></a>
### In(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-In-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the long value is in the specified long values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int64}') | The values. |

<a name='M-Ocura-Helper-CompareHelper-In-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### In(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-In-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the int value is in the specified int values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | The values. |

<a name='M-Ocura-Helper-CompareHelper-In-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}-'></a>
### In(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-In-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the short value is in the specified short values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int16}') | The values. |

<a name='M-Ocura-Helper-CompareHelper-NotIn-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}-'></a>
### NotIn(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-NotIn-System-Int64,System-Collections-Generic-IEnumerable{System-Int64}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the long value is not in the specified long values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int64}') | The values. |

<a name='M-Ocura-Helper-CompareHelper-NotIn-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### NotIn(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-NotIn-System-Int32,System-Collections-Generic-IEnumerable{System-Int32}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the int value is not in the specified int values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | The values. |

<a name='M-Ocura-Helper-CompareHelper-NotIn-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}-'></a>
### NotIn(value,values) `method` [#](#M-Ocura-Helper-CompareHelper-NotIn-System-Int16,System-Collections-Generic-IEnumerable{System-Int16}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Check if the short value is not in the specified short values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The value. |
| values | [System.Collections.Generic.IEnumerable{System.Int16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int16}') | The values. |

<a name='T-Ocura-Helper-ConvertHelper'></a>
## ConvertHelper [#](#T-Ocura-Helper-ConvertHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-ConvertHelper-ToChar-System-String-'></a>
### ToChar(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToChar-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a char to an char.

##### Returns

The value converted in chart

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToDateTime-System-String-'></a>
### ToDateTime(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToDateTime-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a DateTime to an DateTime.

##### Returns

The value converted in DateTime

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToDateTime-System-String,System-String-'></a>
### ToDateTime(value,format) `method` [#](#M-Ocura-Helper-ConvertHelper-ToDateTime-System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a DateTime to an DateTime based in a format.

##### Returns

The value converted in DateTime

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format |

<a name='M-Ocura-Helper-ConvertHelper-ToInt-System-String-'></a>
### ToInt(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToInt-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int32.

##### Returns

The value converted in Int32

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToInt16-System-String-'></a>
### ToInt16(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToInt16-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int16.

##### Returns

The value converted in Int16

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToInt32-System-String-'></a>
### ToInt32(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToInt32-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int32.

##### Returns

The value converted in Int32

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToInt64-System-String-'></a>
### ToInt64(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToInt64-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int64.

##### Returns

The value converted in Int64

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToIntShort-System-String-'></a>
### ToIntShort(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToIntShort-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int16.

##### Returns

The value converted in Int16

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='M-Ocura-Helper-ConvertHelper-ToLong-System-String-'></a>
### ToLong(value) `method` [#](#M-Ocura-Helper-ConvertHelper-ToLong-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Converts the string representation of a number to an Int64.

##### Returns

The value converted in Int64

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value |

<a name='T-Ocura-Helper-DateTimeHelper'></a>
## DateTimeHelper [#](#T-Ocura-Helper-DateTimeHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='P-Ocura-Helper-DateTimeHelper-LastWeek'></a>
### LastWeek `property` [#](#P-Ocura-Helper-DateTimeHelper-LastWeek 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the last week.

<a name='M-Ocura-Helper-DateTimeHelper-AddBusinessDays-System-DateTime,System-Int32-'></a>
### AddBusinessDays(date,days) `method` [#](#M-Ocura-Helper-DateTimeHelper-AddBusinessDays-System-DateTime,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds the business days.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date. |
| days | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The days. |

<a name='M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-DateTime-'></a>
### BeginOfMonth(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the first day of the month

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-Nullable{System-DateTime}-'></a>
### BeginOfMonth(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-BeginOfMonth-System-Nullable{System-DateTime}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the first day of the month

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-DateFromYearWeek-System-Int32,System-Int32-'></a>
### DateFromYearWeek(year,weekOfYear) `method` [#](#M-Ocura-Helper-DateTimeHelper-DateFromYearWeek-System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Dates based in an year and week.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The year. |
| weekOfYear | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The week of year. |

<a name='M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-DateTime-'></a>
### EndOfMonth(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the last day of the month

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-Nullable{System-DateTime}-'></a>
### EndOfMonth(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-EndOfMonth-System-Nullable{System-DateTime}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the last day of the month

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-GetLastWeek'></a>
### GetLastWeek() `method` [#](#M-Ocura-Helper-DateTimeHelper-GetLastWeek 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the last week.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Ocura-Helper-DateTimeHelper-IsBusinessDay-System-DateTime-'></a>
### IsBusinessDay(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-IsBusinessDay-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is business day].

##### Returns

`true` if [is business day] [the specified date]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-IsHoliday-System-DateTime-'></a>
### IsHoliday(date) `method` [#](#M-Ocura-Helper-DateTimeHelper-IsHoliday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is holiday.

##### Returns

`true` if the specified date is holiday; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The date. |

<a name='M-Ocura-Helper-DateTimeHelper-MonthName-System-Int32-'></a>
### MonthName(month) `method` [#](#M-Ocura-Helper-DateTimeHelper-MonthName-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the month name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The month. |

<a name='M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-DateTime-'></a>
### WeekOfYear(time) `method` [#](#M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Weeks the of year.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The time. |

<a name='M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-Nullable{System-DateTime}-'></a>
### WeekOfYear(time) `method` [#](#M-Ocura-Helper-DateTimeHelper-WeekOfYear-System-Nullable{System-DateTime}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Weeks the of year.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The time. |

<a name='T-Ocura-Helper-DirectoryHelper'></a>
## DirectoryHelper [#](#T-Ocura-Helper-DirectoryHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-DirectoryHelper-ClearFolderContent-System-String-'></a>
### ClearFolderContent(folderPath) `method` [#](#M-Ocura-Helper-DirectoryHelper-ClearFolderContent-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Clears the content of the folder.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The folder path. |

<a name='T-Ocura-Helper-DynamicObjectHelper'></a>
## DynamicObjectHelper [#](#T-Ocura-Helper-DynamicObjectHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-DynamicObjectHelper-AddIDictionary-System-Dynamic-ExpandoObject,System-Dynamic-ExpandoObject-'></a>
### AddIDictionary(objA,objB) `method` [#](#M-Ocura-Helper-DynamicObjectHelper-AddIDictionary-System-Dynamic-ExpandoObject,System-Dynamic-ExpandoObject- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds the IDictionary.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objA | [System.Dynamic.ExpandoObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Dynamic.ExpandoObject 'System.Dynamic.ExpandoObject') | The object a. |
| objB | [System.Dynamic.ExpandoObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Dynamic.ExpandoObject 'System.Dynamic.ExpandoObject') | The object b. |

<a name='M-Ocura-Helper-DynamicObjectHelper-GenerateNestedObject-System-String,System-Object-'></a>
### GenerateNestedObject(key,value) `method` [#](#M-Ocura-Helper-DynamicObjectHelper-GenerateNestedObject-System-String,System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generates the nested object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value. |

<a name='T-Ocura-Helper-EnumHelper'></a>
## EnumHelper [#](#T-Ocura-Helper-EnumHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-EnumHelper-Description-System-Enum-'></a>
### Description(value) `method` [#](#M-Ocura-Helper-EnumHelper-Description-System-Enum- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Descriptions the specified value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | The value. |

<a name='M-Ocura-Helper-EnumHelper-GetKeyValues``1'></a>
### GetKeyValues\`\`1() `method` [#](#M-Ocura-Helper-EnumHelper-GetKeyValues``1 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the key values.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Ocura-Helper-EnumHelper-GetValues``1'></a>
### GetValues\`\`1() `method` [#](#M-Ocura-Helper-EnumHelper-GetValues``1 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the values.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Ocura-Helper-EnumHelper-ToInt32-System-Enum-'></a>
### ToInt32(value) `method` [#](#M-Ocura-Helper-EnumHelper-ToInt32-System-Enum- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

To the int32.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | The value. |

<a name='T-Ocura-Helper-LinqHelper'></a>
## LinqHelper [#](#T-Ocura-Helper-LinqHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-LinqHelper-CombineWith``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}-'></a>
### CombineWith\`\`1(first,second) `method` [#](#M-Ocura-Helper-LinqHelper-CombineWith``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Combines with.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The first. |
| second | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The second. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Ocura-Helper-LinqHelper-Concat-System-Collections-Generic-IEnumerable{System-Int64},System-String-'></a>
### Concat(source,delimiter) `method` [#](#M-Ocura-Helper-LinqHelper-Concat-System-Collections-Generic-IEnumerable{System-Int64},System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Concats the specified delimiter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int64}') | The source. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The delimiter. |

<a name='M-Ocura-Helper-LinqHelper-Page``1-System-Linq-IQueryable{``0},System-Int32,System-Int32-'></a>
### Page\`\`1(source,page,pageSize) `method` [#](#M-Ocura-Helper-LinqHelper-Page``1-System-Linq-IQueryable{``0},System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pages the specified page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable 'System.Linq.IQueryable{``0}') | The source. |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The page. |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Size of the page. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of the source. |

<a name='M-Ocura-Helper-LinqHelper-Page``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32-'></a>
### Page\`\`1(source,page,pageSize) `method` [#](#M-Ocura-Helper-LinqHelper-Page``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pages the specified page.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source. |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The page. |
| pageSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Size of the page. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSource | The type of the source. |

<a name='T-Ocura-Helper-MathHelper'></a>
## MathHelper [#](#T-Ocura-Helper-MathHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-MathHelper-RoundUp-System-Decimal,System-Int32-'></a>
### RoundUp(input,places) `method` [#](#M-Ocura-Helper-MathHelper-RoundUp-System-Decimal,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Rounds up.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The input. |
| places | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The places. |

<a name='M-Ocura-Helper-MathHelper-RoundUp-System-Decimal-'></a>
### RoundUp(input) `method` [#](#M-Ocura-Helper-MathHelper-RoundUp-System-Decimal- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Rounds up.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The input. |

<a name='M-Ocura-Helper-MathHelper-Share-System-Decimal,System-Decimal-'></a>
### Share(partialValue,totalValue) `method` [#](#M-Ocura-Helper-MathHelper-Share-System-Decimal,System-Decimal- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Shares the specified partial value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| partialValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The partial value. |
| totalValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The total value. |

<a name='M-Ocura-Helper-MathHelper-Variation-System-Decimal,System-Decimal-'></a>
### Variation(newValue,oldValue) `method` [#](#M-Ocura-Helper-MathHelper-Variation-System-Decimal,System-Decimal- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Variations the specified new value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The new value. |
| oldValue | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The old value. |

<a name='T-Ocura-Helper-NullHelper'></a>
## NullHelper [#](#T-Ocura-Helper-NullHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-Int64}-'></a>
### CheckNull(value) `method` [#](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-Int64}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks the null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | The value. |

<a name='M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime}-'></a>
### CheckNull(value) `method` [#](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks the null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The value. |

<a name='M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime},System-Nullable{System-DateTime}-'></a>
### CheckNull(value,defaultValue) `method` [#](#M-Ocura-Helper-NullHelper-CheckNull-System-Nullable{System-DateTime},System-Nullable{System-DateTime}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Checks the null.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The value. |
| defaultValue | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The default value. |

<a name='T-Ocura-Helper-StringHelper'></a>
## StringHelper [#](#T-Ocura-Helper-StringHelper 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Ocura.Helper

<a name='M-Ocura-Helper-StringHelper-Like-System-String,System-String,System-Boolean-'></a>
### Like(text,searchValue,normalize) `method` [#](#M-Ocura-Helper-StringHelper-Like-System-String,System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Likes normalize.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |
| searchValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The search value. |
| normalize | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [normalize string]. |

<a name='M-Ocura-Helper-StringHelper-Pluralize-System-String,System-Int32,System-String-'></a>
### Pluralize(text,count,plural) `method` [#](#M-Ocura-Helper-StringHelper-Pluralize-System-String,System-Int32,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pluralizes the specified count.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The count. |
| plural | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The plural. |

<a name='M-Ocura-Helper-StringHelper-RemoveDiacritics-System-String-'></a>
### RemoveDiacritics(text) `method` [#](#M-Ocura-Helper-StringHelper-RemoveDiacritics-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes the diacritics.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |

<a name='M-Ocura-Helper-StringHelper-ToLowerNormalize-System-String-'></a>
### ToLowerNormalize(text) `method` [#](#M-Ocura-Helper-StringHelper-ToLowerNormalize-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Remove diacritics and set to lower

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |

<a name='M-Ocura-Helper-StringHelper-ToTitleCase-System-String-'></a>
### ToTitleCase(text) `method` [#](#M-Ocura-Helper-StringHelper-ToTitleCase-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

To title case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |

<a name='M-Ocura-Helper-StringHelper-ToUpperNormalize-System-String-'></a>
### ToUpperNormalize(text) `method` [#](#M-Ocura-Helper-StringHelper-ToUpperNormalize-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Remove diacritics and set to upper

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |
