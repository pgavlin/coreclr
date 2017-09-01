using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_dev10_b392262_b392262_b392262_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b392262_b392262_b392262_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b392262\\b392262\\b392262.cmd");
        }
    }
}
