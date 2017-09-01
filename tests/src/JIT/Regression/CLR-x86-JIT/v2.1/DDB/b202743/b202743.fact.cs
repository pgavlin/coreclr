using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_v2_1_DDB_b202743_b202743_b202743_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b202743_b202743_b202743_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b202743\\b202743\\b202743.cmd");
        }
    }
}
