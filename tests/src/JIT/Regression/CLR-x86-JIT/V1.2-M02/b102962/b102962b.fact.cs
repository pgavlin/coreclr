using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_M02_b102962_b102962b_b102962b_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M02_b102962_b102962b_b102962b_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M02\\b102962\\b102962b\\b102962b.cmd");
        }
    }
}
