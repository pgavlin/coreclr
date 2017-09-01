using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M13_RTM_b90129_b90129_b90129_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M13_RTM_b90129_b90129_b90129_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M13-RTM\\b90129\\b90129\\b90129.cmd");
        }
    }
}
