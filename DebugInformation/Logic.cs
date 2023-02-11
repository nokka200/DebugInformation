namespace DebugInformation
{
    public static class DebugInf
    {
        /// <summary>
        /// Returns the variables name and type with time stamp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="variableToFormat"></param>
        /// <param name="variableName"></param>
        /// <returns>Formated string</returns>
        public static string FormatVariables<T> (T variableToFormat, string variableName)
        {
            if (variableToFormat == null)
                return string.Empty;

            string re = string.Empty;
            DateTime dateObj = DateTime.Now;


            re = $"{dateObj} / Name: {variableName} | Value: {variableToFormat} | Type: {typeof(T)}";
            return re;
        }

        public static string FormatFunctionCall(string functionName)
        {
            string re = string.Empty;
            DateTime dateObj = DateTime.Now;

            re = $"{dateObj} / Calling: {functionName}";

            return re;
        }
    }
}