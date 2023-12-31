using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OpenAINameGenerator.Util
{
    public static partial class Constants
    {
        public const string SystemPrompt = "You provide list of names for the user inputs. Generated names must be in a Json formatted string array with no newlines.";
        public const string AuthenticationFailBody = "Failed to authenticate with OpenAI. Please check your API key and try again.";
        public const string AuthenticationFailTitle = "Authentication Error";
        public const string KeyloadedMessage = "Key loaded externally";
        public const string FavoritesClearBody = "Are you sure you want to clear your favorites?";
        public static readonly string OpenAIGenerationErrorBody = $"Failed to generate names.{Environment.NewLine + Environment.NewLine}OpenAI error:";
        [GeneratedRegex("^sk-[a-zA-Z0-9]{32,}$", RegexOptions.Compiled)]
        public static partial Regex OpenAIKeyRegex();
    }
}
