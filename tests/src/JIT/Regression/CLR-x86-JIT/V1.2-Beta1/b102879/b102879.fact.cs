using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_Beta1_b102879_b102879_b102879_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_Beta1_b102879_b102879_b102879_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-Beta1\\b102879\\b102879\\b102879.cmd");
        }
    }
}
