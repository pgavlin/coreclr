using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP2b_SP2b_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2b_SP2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2b\\SP2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
