using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _forceinlining_AttributeConflict_AttributeConflict_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_AttributeConflict_AttributeConflict_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\AttributeConflict\\AttributeConflict.cmd");
        }
    }
}
