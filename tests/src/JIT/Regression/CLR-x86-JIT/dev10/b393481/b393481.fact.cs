using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_dev10_b393481_b393481_b393481_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev10_b393481_b393481_b393481_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev10\\b393481\\b393481\\b393481.cmd");
        }
    }
}
