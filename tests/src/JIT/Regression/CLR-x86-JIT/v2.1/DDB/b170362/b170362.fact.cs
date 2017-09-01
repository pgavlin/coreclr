using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_v2_1_DDB_b170362_b170362_b170362_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b170362_b170362_b170362_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b170362\\b170362\\b170362.cmd");
        }
    }
}
