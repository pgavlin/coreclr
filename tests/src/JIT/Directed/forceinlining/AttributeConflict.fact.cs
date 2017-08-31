using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _forceinlining_AttributeConflict_AttributeConflict_
    {
        [OuterLoop]
        [Fact]
        public void _forceinlining_AttributeConflict_AttributeConflict_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\forceinlining\\AttributeConflict\\AttributeConflict.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
