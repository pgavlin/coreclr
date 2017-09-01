using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_M02_b102962_b102962a_b102962a_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M02_b102962_b102962a_b102962a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M02\\b102962\\b102962a\\b102962a.cmd");
        }
    }
}
