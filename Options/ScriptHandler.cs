using System.Collections.Generic;

namespace webhookshell.Options
{
    public class ScriptHandler
    {
        public string ScriptsLocation { get; set; }
        public string ProcessName { get; set; }
        public string FileExtension { get; set; }
        public string Key { get; set; }
        public Dictionary<string, string> KeysMapping { get; set;} = new();
    }
}