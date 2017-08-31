using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP1b_SP1b_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1b_SP1b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1b\\SP1b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
