using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using Platform.Common.Flux.Domain;
using Platform.Common.Flux.Error;
using Platform.Common.Platform;

namespace Platform.Common.Flux.Parser
{
    public class FluxResultMapper
    {
        /**
         * Maps FluxRecord into custom POCO class.
         *
         * @param record flux record
         * @param <T>    poco type
         * @return
         */

        public T ToPoco<T>(FluxRecord record)
        {
            Arguments.CheckNotNull(record, "Record is required");

            try
            {
                Type type = typeof(T);
                T poco = (T) Activator.CreateInstance(type);

                var properties = type.GetProperties();

                foreach (var property in properties)
                {
                    var attributes = property.GetCustomAttributes(typeof(ColumnAttribute), false);

                    ColumnAttribute attribute = null;

                    if (attributes.Length > 0)
                    {
                        attribute = (ColumnAttribute) attributes.First();
                    }

                    string columnName = property.Name;

                    if (attribute != null && !string.IsNullOrEmpty(attribute.Name))
                    {
                        columnName = attribute.Name;
                    }

                    // copy record to case insensitive dictionary
                    Dictionary<string, object> recordValues =
                                    new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase);

                    foreach (KeyValuePair<string, object> entry in record.Values)
                    {
                        recordValues.Add(entry.Key, entry.Value);
                    }

                    string col = null;

                    if (recordValues.ContainsKey(columnName))
                    {
                        col = columnName;
                    }
                    else if (recordValues.ContainsKey("_" + columnName))
                    {
                        col = "_" + columnName;
                    }

                    if (!string.IsNullOrEmpty(col))
                    {
                        recordValues.TryGetValue(col, out var value);

                        SetFieldValue(poco, property, value);
                    }
                }

                return poco;
            }
            catch (Exception e)
            {
                throw new InfluxException(new QueryErrorResponse(0,
                                new List<string>() {e.Message}.AsReadOnly()));
            }
        }

        private void SetFieldValue<T>(T poco, PropertyInfo property, object value)
        {
            if (property == null || value == null || !property.CanWrite)
            {
                return;
            }

            try
            {
                var propertyType = property.GetType();

                //the same type
                if (propertyType == value.GetType())
                {
                    property.SetValue(poco, value);
                    return;
                }

                //convert primitives
                if (typeof(double).IsAssignableFrom(propertyType))
                {
                    property.SetValue(poco, ToDoubleValue(value));
                    return;
                }

                if (typeof(long).IsAssignableFrom(propertyType))
                {
                    property.SetValue(poco, ToLongValue(value));
                    return;
                }

                if (typeof(int).IsAssignableFrom(propertyType))
                {
                    property.SetValue(poco, ToIntValue(value));
                    return;
                }

                if (typeof(bool).IsAssignableFrom(propertyType))
                {
                    property.SetValue(poco, bool.TryParse(value.ToString(), out var v) && v);
                    return;
                }

                property.SetValue(poco, value);

            }
            catch (InvalidCastException)
            {
                throw new InfluxException($"Class '{poco.GetType().Name}' field '{property.Name}' was defined with a different field type and caused a InvalidCastException. " +
                                $"The correct type is '{value.GetType().Name}' (current field value: '{value}').");
            }
        }

        private double ToDoubleValue(object value)
        {
            if (value.GetType().IsAssignableFrom(typeof(double)))
            {
                return (double) value;
            }

            return (double) value;
        }

        private long ToLongValue(object value)
        {
            if (value.GetType().IsAssignableFrom(typeof(long)))
            {
                return (long) value;
            }

            return (long) value;
        }
        
        private int ToIntValue(object value)
        {
            if (value.GetType().IsAssignableFrom(typeof(int)))
            {
                return (int) value;
            }

            return (int) value;
        }
    }
}

