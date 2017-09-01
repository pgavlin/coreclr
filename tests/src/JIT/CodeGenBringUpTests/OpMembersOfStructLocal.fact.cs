using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _OpMembersOfStructLocal_OpMembersOfStructLocal_
    {
        [OuterLoop]
        [Fact]
        public void _OpMembersOfStructLocal_OpMembersOfStructLocal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\OpMembersOfStructLocal\\OpMembersOfStructLocal.cmd");
        }
    }
}
