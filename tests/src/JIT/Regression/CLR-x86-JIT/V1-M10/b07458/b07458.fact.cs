using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b07458_b07458_b07458_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b07458_b07458_b07458_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b07458\\b07458\\b07458.cmd");
        }
    }
}
