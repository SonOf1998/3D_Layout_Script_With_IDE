using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

using alert = Alert.Alert;
using error = Alert.Error;
using warning = Alert.Warning;

namespace _3D_layout_script
{
    class SyntaxErrorListener : BaseErrorListener
    {
        private List<alert> alerts;

        public SyntaxErrorListener()
        {
            alerts = new List<alert>();
        }

        public IReadOnlyList<alert> GetAlerts()
        {
            return alerts;
        }

        public override void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine, [NotNull] string msg, [Nullable] RecognitionException e)
        {
            base.SyntaxError(recognizer, offendingSymbol, line, charPositionInLine, msg, e);
            alerts.Add(new error(line, msg));
        }
    }
}
