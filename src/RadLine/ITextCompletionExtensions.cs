using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace RadLine
{
    public static class ITextCompletionExtensions
    {
        public static bool TryGetCompletions(
            this ITextCompletion completion,
            string currentString,
            [NotNullWhen(true)] out string[]? result)
        {
            var completions = completion.GetCompletions(currentString);
            if (completions == null || !completions.Any())
            {
                result = null;
                return false;
            }

            result = completions.ToArray();
            return true;
        }
    }
}
