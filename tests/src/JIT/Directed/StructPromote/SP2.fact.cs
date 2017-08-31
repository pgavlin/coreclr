using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SP2_SP2_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2_SP2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2\\SP2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
