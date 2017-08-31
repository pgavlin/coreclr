using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_v4_delegatetail_delegatetail_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall_v4_delegatetail_delegatetail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\delegatetail\\delegatetail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
