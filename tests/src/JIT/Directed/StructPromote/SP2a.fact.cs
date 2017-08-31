using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP2a_SP2a_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2a_SP2a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2a\\SP2a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
