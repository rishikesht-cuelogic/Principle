using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Common.Utilities
{
    public static class StringComparer
    {
        static int tolerance = 3;
        public static bool Compare(string source, string target)
        {
            source = source.Replace(" ", string.Empty).ToLower();
            target = target.Replace(" ", string.Empty).ToLower();
            return (source == target);
        }

        public static bool SpecialContains(string source, string target)
        {
            var specialCharacters = new[] { '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '-', '*', '/', '|', '=', '\"' };

            var targets = target.Split(specialCharacters);
            var sources = source.Split(specialCharacters);

            var isSourceContainsSpecialCharacter = sources.Count() > 1;
            var isTargetContainsSpecialCharacter = targets.Count() > 1;

            if (isSourceContainsSpecialCharacter && isTargetContainsSpecialCharacter)
            {
                var isPresent = targets.Intersect(sources).Count() > 0;

                if (!isPresent)
                {
                    foreach (var itemSource in sources)
                    {
                        if (isPresent)
                        {
                            break;
                        }
                        isPresent = CompareSourceWithTargets(itemSource, targets);
                    }
                }
                return isPresent;
            }
            else if (isSourceContainsSpecialCharacter && !isTargetContainsSpecialCharacter)
            {
                return CompareSourceWithTargets(source, targets);
            }
            else if (!isSourceContainsSpecialCharacter && isTargetContainsSpecialCharacter)
            {
                return CompareSourceWithTargets(target, sources);
            }
            else
            {
                var isPresent = true;
                if (!(source.Contains(target, StringComparison.OrdinalIgnoreCase) ||
                      target.Contains(source, StringComparison.OrdinalIgnoreCase)))
                {
                    isPresent = (LevenshteinDistance.Compute(source, target) <= tolerance);
                }
                return isPresent;
            }
        }

        private static bool CompareSourceWithTargets(string source, string[] targets)
        {
            var isSourceContainsInTarget = targets.Contains(source);
            var isTargetContainsInSource = false;

            if (!isSourceContainsInTarget)
            {
                foreach (var item in targets)
                {
                    if (LevenshteinDistance.Compute(source, item) <= tolerance)
                    {
                        isTargetContainsInSource = true;
                        break;
                    }
                }
            }
            return (isSourceContainsInTarget || isTargetContainsInSource);
        }
    }

    public static class StringExtensions
    {
        public static bool Contains(this string source, string target, StringComparison comparison)
        {
            return source.IndexOf(target, comparison) >= 0;
        }
    }
}
