using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _clr_x64_JIT_v4_0_DevDiv34372_overRepLocalOpt_overRepLocalOpt_
    {
        [OuterLoop]
        [Fact]
        public void _clr_x64_JIT_v4_0_DevDiv34372_overRepLocalOpt_overRepLocalOpt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\clr-x64-JIT\\v4.0\\DevDiv34372\\overRepLocalOpt\\overRepLocalOpt.cmd");
        }
    }
}
