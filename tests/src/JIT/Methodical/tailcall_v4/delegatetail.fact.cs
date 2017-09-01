using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall_v4_delegatetail_delegatetail_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall_v4_delegatetail_delegatetail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\delegatetail\\delegatetail.cmd");
        }
    }
}
