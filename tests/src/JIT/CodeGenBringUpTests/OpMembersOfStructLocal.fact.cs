using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _OpMembersOfStructLocal_OpMembersOfStructLocal_
    {
        [OuterLoop]
        [Fact]
        public void _OpMembersOfStructLocal_OpMembersOfStructLocal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\OpMembersOfStructLocal\\OpMembersOfStructLocal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
