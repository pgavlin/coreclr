using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_simple_simple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\simple\\simple.cmd");
        }
    }
}
