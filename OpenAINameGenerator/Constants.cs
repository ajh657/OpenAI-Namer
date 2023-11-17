using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OpenAINameGenerator
{
    internal static class Constants
    {
        internal const string SystemPrompt = "You provide list of names for the user inputs. Generated names must be in a Json formatted string array with no newlines.";
    }
}
