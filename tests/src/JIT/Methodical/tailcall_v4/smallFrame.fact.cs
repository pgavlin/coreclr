using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall_v4_smallFrame_smallFrame_
    {
        [Fact]
        public void _tailcall_v4_smallFrame_smallFrame_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\smallFrame\\smallFrame.cmd");
        }
    }
}
