using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_gcref2_gcref2_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_gcref2_gcref2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\gcref2\\gcref2.cmd");
        }
    }
}
