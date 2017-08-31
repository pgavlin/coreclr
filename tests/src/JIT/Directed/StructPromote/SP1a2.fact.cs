using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP1a2_SP1a2_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1a2_SP1a2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1a2\\SP1a2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
