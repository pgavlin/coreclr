using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP1_SP1_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1_SP1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1\\SP1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
